import { chromium } from "playwright";
import fetch from "node-fetch";

function extractPopupUrl(jsCode) {
	if (!jsCode.startsWith("javascript:")) return null;

	// Get the part between the parentheses
	const start = jsCode.indexOf("jspopup(") + 8;
	const end = jsCode.lastIndexOf(")");
	const inner = jsCode.slice(start, end).trim();

	// Remove surrounding quotes
	const urlPart = inner.replace(/^['"]|['"]$/g, "");

	return encodeURI(
		"https://www.smv.gob.pe/ServicioSancionesImpuestas/" + urlPart
	);
}

async function runSearch(razonSocialInput, nombreComercialInput) {
	const browser = await chromium.launch({ headless: false });
	const page = await browser.newPage();

	// Step 1: Go to the search page
	await page.goto(
		"https://www.smv.gob.pe/ServicioSancionesImpuestas/frm_SancionesEmpresas"
	);

	// Step 2: Select "personas jurídicas"
	await page.waitForSelector("#MainContent_rbTipo_0"); //TODO: Falta realizar el proceso con Tipo_1 (personas naturales)
	await page.click("#MainContent_rbTipo_0");

	// Step 3: Fill in the start date
	await page.click("#txtFechDesde");
	await page.press("#txtFechDesde", "Control+A");
	await page.type("#txtFechDesde", "01/01/2008");

	// Step 4: Click the search button
	await page.waitForSelector("#MainContent_cbBuscar");
	await page.click("#MainContent_cbBuscar");

	// Wait for loading to start and finish
	await page.waitForFunction(() => {
		const el = document.querySelector("#myLoading");
		return el && getComputedStyle(el).display === "block";
	});

	await page.waitForFunction(() => {
		const el = document.querySelector("#myLoading");
		return el && getComputedStyle(el).display === "none";
	});

	// Wait for table to load
	await page.waitForSelector("#MainContent_grdReporte tbody tr");

	// Extract data from the table rows
	const entidades = await page.$$eval(
		"#MainContent_grdReporte tbody tr",
		(rows) => {
			const parsedRows = rows.map((row) => {
				const celdas = row.querySelectorAll("td");

				if (celdas.length === 0) return null; // Skip empty rows

				const nombre = celdas[1]?.innerText.trim() || "";
				const n_sanciones = celdas[2]?.innerText.trim() || "";
				const link_raw =
					celdas[3]?.querySelector("a")?.getAttribute("href") || "";

				// Clean the javascript href to extract usable data
				const ver_detalle = link_raw.startsWith("javascript:")
					? link_raw
					: null;

				return { nombre, n_sanciones, ver_detalle, sanciones: [] };
			});

			return parsedRows.filter((row) => row !== null); // Filter out null rows
		}
	);

	console.log("Cantidad de entidades encontradas:", entidades.length);

	// Match input name against entity names
	const hits = entidades.filter((entidad) => {
		const nombre = entidad.nombre.toLowerCase();
		return (
			nombre.includes(razonSocialInput.toLowerCase()) ||
			nombre.includes(nombreComercialInput.toLowerCase())
		);
	});

	console.log(`Se encontraron ${hits.length} hits.`);

	for (const hit of hits) {
		if (!hit.ver_detalle) continue;

		const jsCode = hit.ver_detalle.replace("javascript:", "").trim();

		// Wait for popup to open as a new page
		const [popup] = await Promise.all([
			page.waitForEvent("popup"),
			page.evaluate(jsCode),
		]);

		// Wait for the content to be ready
		await popup.waitForLoadState("domcontentloaded");
		await popup.waitForSelector("#grdReporte");

		hit.sanciones = await popup.$$eval("#grdReporte tbody tr", (rows) => {
			return Array.from(rows)
				.filter((row) => row.querySelectorAll("td").length > 0)
				.map((row) => {
					const celdas = row.querySelectorAll("td");
					const fecha = celdas[0]?.innerText.trim() || "";
					const resolucionLink = celdas[1]?.querySelector("a");
					const resolucion_text =
						resolucionLink?.innerText.trim() || "";
					const resolucion_href = resolucionLink?.href || null;
					const sancionado = celdas[2]?.innerText.trim() || "";
					const detalle = celdas[3]?.innerText.trim() || "";
					const tipo = celdas[4]?.innerText.trim() || "";
					const monto = celdas[5]?.innerText.trim() || "";
					const reincidente = celdas[6]?.innerText.trim() || "";
					const recurso = celdas[7]?.innerText.trim() || "";

					return {
						fecha,
						resolucion: {
							texto: resolucion_text,
							link: resolucion_href,
						},
						sancionado,
						detalle,
						tipo,
						monto,
						reincidente,
						recurso,
					};
				});
		});

		await popup.close(); // ✅ close popup before continuing
	}

	await browser.close(); // ✅ close the main browser window
	await page.close(); // ✅ close the main page if you want to keep the browser open

	for (const hit of hits) {
		console.log("Nombre:", hit.nombre);
		console.log("Número de sanciones:", hit.n_sanciones);
		console.log("Ver detalle:", hit.ver_detalle);
		console.log("-----------------------------");
	}
}

runSearch(
	"AUTOPLAN EMPRESA ADMINISTRADORA DE FONDOS COLECTIVOS S.A.",
	"REPRESENTACIONES GENERALES"
);





async function consultarContratista(
	identificacionTributaria,
	razonSocial,
	nombreComercial
) {
	const baseUrl = "https://www.datos.gov.co/resource/4n4q-k399.json";

	// Construir URLs
	const urls = [
		`${baseUrl}?documento_contratista=${encodeURIComponent(
			identificacionTributaria
		)}`,
		`${baseUrl}?nombre_contratista=${encodeURIComponent(razonSocial)}`,
		`${baseUrl}?nombre_contratista=${encodeURIComponent(nombreComercial)}`,
	];

	// Ejecutar todas las búsquedas en paralelo
	const resultados = await Promise.all(
		urls.map((url) =>
			fetch(url)
				.then((res) => res.json())
				.catch(() => [])
		)
	);

	// Combinar y eliminar duplicados por ID de contrato (si existe)
	const hits = [];
	const idsVistos = new Set();

	for (const lista of resultados) {
		for (const item of lista) {
			const idUnico = item.id_contrato || JSON.stringify(item);
			if (!idsVistos.has(idUnico)) {
				hits.push(item);
				idsVistos.add(idUnico);
			}
		}
	}

	console.log(`Total de coincidencias: ${hits.length}`);

	//Print first 5
	console.log("Primeras 5 coincidencias:", hits.slice(0, 5));
	return hits;
}

// Ejemplo de uso
consultarContratista(
	"106781141",
	"JORGE HUMBERTO FERIAS MANJARRE",
	"FERIAS MANJARRES CONSULTORE"
);

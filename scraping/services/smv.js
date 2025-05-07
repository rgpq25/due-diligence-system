import { chromium } from "playwright";

export async function fetchSMVData({ razonSocial, nombreComercial }) {
	const browser = await chromium.launch({ headless: true });
	const page = await browser.newPage();

	const searchConfigs = ["#MainContent_rbTipo_0", "#MainContent_rbTipo_1"];
	const sancionesHits = [];

	for (let i = 0; i < searchConfigs.length; i++) {
		const currentSearchConfig = searchConfigs[i];

		await page.goto(
			"https://www.smv.gob.pe/ServicioSancionesImpuestas/frm_SancionesEmpresas"
		);

		await page.waitForSelector(currentSearchConfig);
		await page.click(currentSearchConfig);

		await page.click("#txtFechDesde");
		await page.press("#txtFechDesde", "Control+A");
		await page.type("#txtFechDesde", "01/01/2008");

		await page.waitForSelector("#MainContent_cbBuscar");
		await page.click("#MainContent_cbBuscar");

		await page.waitForFunction(() => {
			const el = document.querySelector("#myLoading");
			return el && getComputedStyle(el).display === "block";
		});
		await page.waitForFunction(() => {
			const el = document.querySelector("#myLoading");
			return el && getComputedStyle(el).display === "none";
		});

		await page.waitForSelector("#MainContent_grdReporte tbody tr");

		const entidades = await page.$$eval(
			"#MainContent_grdReporte tbody tr",
			(rows) => {
				const parsedRows = rows.map((row) => {
					const celdas = row.querySelectorAll("td");

					if (celdas.length === 0) return null;

					const nombre = celdas[1]?.innerText.trim() || "";
					const n_sanciones = celdas[2]?.innerText.trim() || "";
					const link_raw =
						celdas[3]?.querySelector("a")?.getAttribute("href") ||
						"";

					const ver_detalle = link_raw.startsWith("javascript:")
						? link_raw
						: null;

					return { nombre, n_sanciones, ver_detalle, sanciones: [] };
				});

				return parsedRows.filter((row) => row !== null);
			}
		);

		const hits = entidades.filter((entidad) => {
			const nombre = entidad.nombre.toLowerCase();
			const razon = razonSocial.toLowerCase().trim();
			const comercial = nombreComercial.toLowerCase().trim();

			return (
				(razon !== "" && nombre.includes(razon)) ||
				(comercial !== "" && nombre.includes(comercial))
			);
		});

		for (const hit of hits) {
			if (!hit.ver_detalle) continue;

			const jsCode = hit.ver_detalle.replace("javascript:", "").trim();
			const [popup] = await Promise.all([
				page.waitForEvent("popup"),
				page.evaluate(jsCode),
			]);

			await popup.waitForLoadState("domcontentloaded");
			await popup.waitForSelector("#grdReporte");

			const sancionesToAdd = await popup.$$eval(
				"#grdReporte tbody tr",
				(rows) => {
					return Array.from(rows)
						.filter((row) => row.querySelectorAll("td").length > 0)
						.map((row) => {
							const celdas = row.querySelectorAll("td");
							const fecha = celdas[0]?.innerText.trim() || "";
							const resolucionLink =
								celdas[1]?.querySelector("a");
							const resolucion_text =
								resolucionLink?.innerText.trim() || "";
							const resolucion_href =
								resolucionLink?.href || null;
							const sancionado =
								celdas[2]?.innerText.trim() || "";
							const detalle = celdas[3]?.innerText.trim() || "";
							const tipo = celdas[4]?.innerText.trim() || "";
							const monto = celdas[5]?.innerText.trim() || "";
							const reincidente =
								celdas[6]?.innerText.trim() || "";
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
				}
			);

			sancionesHits.push(...sancionesToAdd);
			await popup.close();
		}
	}
	await browser.close();
	await page.close();

	return sancionesHits.map((sancion, idx) => {
		return {
			id: idx,
			...sancion,
		};
	});
}

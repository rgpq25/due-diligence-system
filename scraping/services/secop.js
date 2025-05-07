import fetch from "node-fetch";

export async function fetchSECOPData({
	identificacionTributaria,
	razonSocial,
	nombreComercial,
}) {
	const baseUrl = "https://www.datos.gov.co/resource/4n4q-k399.json";
	const filters = [];

	if (identificacionTributaria?.trim()) {
		filters.push(
			`documento_contratista = '${identificacionTributaria.trim()}'`
		);
	}

	if (razonSocial?.trim()) {
		const razon = razonSocial.toUpperCase().replace(/'/g, "''");
		filters.push(`upper(nombre_contratista) LIKE '%${razon}%'`);
	}

	if (nombreComercial?.trim()) {
		const comercial = nombreComercial.toUpperCase().replace(/'/g, "''");
		filters.push(`upper(nombre_contratista) LIKE '%${comercial}%'`);
	}

	if (filters.length === 0) {
		console.warn(
			"[ERROR] - No se proporcionaron parámetros de búsqueda válidos."
		);
		return [];
	}

	const whereClause = filters.join(" OR ");

	const url = `${baseUrl}?$where=${encodeURIComponent(whereClause)}`;
	const res = await fetch(url);
	const data = await res.json();

	const mappedData = data.map((item, idx) => {
		return {
			id: idx,
			documentoContratista: item.documento_contratista,
			nombreContratista: item.nombre_contratista,
			valorSancion: item.valor_sancion,
			fechaDePublicacion: item.fecha_de_publicacion,
		};
	});

	return mappedData;
}

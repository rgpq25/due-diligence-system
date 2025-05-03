import express from "express";
import { fetchInterpolData } from "../services/interpol.js";
import { fetchSECOPData } from "../services/secop.js";
import { fetchSMVData } from "../services/smv.js";

const router = express.Router();

router.get("/watchlist-check", async (req, res) => {
	const {
		razonSocial = "",
		nombreComercial = "",
		identificacionTributaria = "",
		sources = "",
	} = req.query;

	if (!razonSocial && !nombreComercial && !identificacionTributaria) {
		return res.status(400).json({
			error: "At least one of razonSocial, nombreComercial, or identificacionTributaria is required.",
		});
	}

	const selectedSources = sources
		.split(",")
		.map((s) => s.trim().toLowerCase());

	const result = {
		hits: 0,
		smv: [],
		secop: [],
		interpol: [],
	};

	if (selectedSources.includes("smv")) {
		result.smv = await fetchSMVData({
			razonSocial: razonSocial ?? "",
			nombreComercial: nombreComercial ?? "",
		});
		console.log("[SMV] - ", result.smv.length);
	}

	if (selectedSources.includes("secop")) {
		result.secop = await fetchSECOPData({
			razonSocial: razonSocial ?? "",
			nombreComercial: nombreComercial ?? "",
			identificacionTributaria: identificacionTributaria ?? "",
		});
		console.log("[SECOP] - ", result.secop.length);
	}

	if (selectedSources.includes("interpol")) {
		result.interpol = await fetchInterpolData({
			razonSocial: razonSocial ?? "",
			nombreComercial: nombreComercial ?? "",
		});
		console.log("[INTERPOL] - ", result.interpol.length);
	}

	result.hits =
		result.interpol.length + result.secop.length + result.smv.length;

	res.json(result);
});

export default router;

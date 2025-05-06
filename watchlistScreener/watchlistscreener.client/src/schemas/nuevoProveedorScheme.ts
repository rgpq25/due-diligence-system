import { z } from "zod";

export const nuevoProveedorSchema = z.object({
	razonSocial: z
		.string({
			required_error: "La razón social es obligatoria",
		})
		.min(1, {
			message: "La razón social es obligatoria",
		}),
	nombreComercial: z
		.string({
			required_error: "El nombre comercial es obligatorio",
		})
		.min(1, {
			message: "El nombre comercial es obligatorio",
		}),
	identificacionTributaria: z
		.number({
			invalid_type_error:
				"La identificación tributaria debe ser un número",
			message: "La identificación tributaria es obligatoria",
		})
		.refine((val) => val.toString().length === 11, {
			message:
				"La identificación tributaria debe tener exactamente 11 dígitos",
		}),
	numeroTelefonico: z
		.string({
			required_error: "El número telefónico es obligatorio",
		})
		.min(1, {
			message: "El número telefónico es obligatorio",
		}),
	correoElectronico: z
		.string({
			required_error: "El correo electrónico es obligatorio",
		})
		.email({
			message: "El correo electrónico no es válido",
		}),
	sitioWeb: z
		.string({
			required_error: "El sitio web es obligatorio",
		})
		.url({
			message: "El sitio web no es válido",
		}),
	direccionFisica: z
		.string({
			required_error: "La dirección física es obligatoria",
		})
		.min(1, {
			message: "La dirección física es obligatoria",
		}),
	paisId: z.string().nonempty({
		message: "El país es obligatorio",
	}),
	facturacionAnual: z.number({
		invalid_type_error: "La identificación tributaria debe ser un número",
		message: "La identificación tributaria es obligatoria",
	}),
});

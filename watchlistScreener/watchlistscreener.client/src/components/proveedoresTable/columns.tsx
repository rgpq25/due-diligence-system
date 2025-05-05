"use client";

import { Proveedor } from "@/lib/types";
import { ColumnDef } from "@tanstack/react-table";

export const columns: ColumnDef<Proveedor>[] = [
	{
		accessorKey: "razonSocial",
		header: "Razón Social",
	},
	{
		accessorKey: "nombreComercial",
		header: "Nombre Comercial",
	},
	{
		accessorKey: "identificacionTributaria",
		header: "Identificación Tributaria",
	},
	{
		accessorKey: "numeroTelefonico",
		header: "Numero Telefonico",
	},
	{
		accessorKey: "correoElectronico",
		header: "Correo Electronico",
	},
	{
		accessorKey: "sitioWeb",
		header: "Sitio Web",
	},
	{
		accessorKey: "direccionFisica",
		header: "Dirección Fisica",
	},
	{
		accessorFn: (row) => row.pais?.nombre || row.paisId,
		header: "Pais",
	},
	{
		accessorKey: "facturacionAnual",
		header: "Facturacion Anual",
	},
];

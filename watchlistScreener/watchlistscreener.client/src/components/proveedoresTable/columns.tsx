"use client";

import { Proveedor } from "@/lib/types";
import { ColumnDef } from "@tanstack/react-table";
import { MoreHorizontal, ScanSearch, SquarePen, Trash2 } from "lucide-react";
import { Button } from "../ui/button";
import {
	DropdownMenu,
	DropdownMenuContent,
	DropdownMenuItem,
	DropdownMenuLabel,
	DropdownMenuSeparator,
	DropdownMenuTrigger,
} from "../ui/dropdown-menu";
import { DataTableColumnHeader } from "./data-table-column-header";

interface ColumnProps {
	onEdit: (proveedor: Proveedor) => void;
	onDelete: (proveedor: Proveedor) => void;
	onScreening: (proveedor: Proveedor) => void;
}

export function getColumns({
	onEdit,
	onDelete,
	onScreening,
}: ColumnProps): ColumnDef<Proveedor>[] {
	const columns: ColumnDef<Proveedor>[] = [
		{
			id: "#",
			header: () => (
				<p className="text-muted-foreground text-xs font-medium group-hover:text-black ml-2">
					#
				</p>
			),
			cell: ({ row }) => {
				return (
					<p className="ml-2 text-muted-foreground text-xs">
						{row.index + 1}
					</p>
				);
			},
		},
		{
			accessorKey: "razonSocial",
			header: ({ column }) => (
				<DataTableColumnHeader column={column} title="Razón Social" />
			),
			cell: ({ row }) => {
				return <p className="ml-2">{row.getValue("razonSocial")}</p>;
			},
		},
		{
			accessorKey: "nombreComercial",
			header: ({ column }) => (
				<DataTableColumnHeader
					column={column}
					title="Nombre Comercial"
				/>
			),
			cell: ({ row }) => {
				return (
					<p className="ml-2">{row.getValue("nombreComercial")}</p>
				);
			},
		},
		{
			accessorKey: "identificacionTributaria",
			header: ({ column }) => (
				<DataTableColumnHeader column={column} title="ID Tributaria" />
			),
			cell: ({ row }) => {
				return (
					<p className="ml-2">
						{row.getValue("identificacionTributaria")}
					</p>
				);
			},
		},
		{
			accessorKey: "numeroTelefonico",
			header: ({ column }) => (
				<DataTableColumnHeader column={column} title="Nro Telefonico" />
			),
			cell: ({ row }) => {
				return (
					<p className="ml-2">{row.getValue("numeroTelefonico")}</p>
				);
			},
		},
		{
			accessorKey: "correoElectronico",
			header: ({ column }) => (
				<DataTableColumnHeader column={column} title="Correo" />
			),
			cell: ({ row }) => {
				return (
					<p className="ml-2">{row.getValue("correoElectronico")}</p>
				);
			},
		},
		{
			accessorKey: "sitioWeb",
			header: ({ column }) => (
				<DataTableColumnHeader column={column} title="Sitio Web" />
			),
			cell: ({ row }) => {
				return <p className="ml-2">{row.getValue("sitioWeb")}</p>;
			},
		},
		{
			accessorKey: "direccionFisica",
			header: ({ column }) => (
				<DataTableColumnHeader column={column} title="Direc. Fisica" />
			),
			cell: ({ row }) => {
				return (
					<p className="ml-2">{row.getValue("direccionFisica")}</p>
				);
			},
		},
		{
			id: "pais",
			accessorFn: (row) => row.pais?.nombre || row.paisId,
			header: ({ column }) => (
				<DataTableColumnHeader column={column} title="País" />
			),
			cell: ({ row }) => {
				return <p className="ml-2">{row.getValue("pais")}</p>;
			},
		},
		{
			accessorKey: "facturacionAnual",
			header: ({ column }) => (
				<DataTableColumnHeader
					column={column}
					title="Facturacion Anual"
				/>
			),
			cell: ({ row }) => {
				return (
					<p className="ml-2">{row.getValue("facturacionAnual")}</p>
				);
			},
		},
		{
			id: "fechaUltimaEdicion",
			accessorFn: (row) => {
				const backendDate = new Date(
					row.fechaUltimaEdicion.endsWith("Z")
						? row.fechaUltimaEdicion
						: `${row.fechaUltimaEdicion}Z`
				);

				return backendDate.toLocaleString("es-PE", {
					timeZone: "America/Lima",
					year: "numeric",
					month: "long",
					day: "numeric",
					hour: "2-digit",
					minute: "2-digit",
					hour12: false,
				});
			},
			header: ({ column }) => (
				<DataTableColumnHeader column={column} title="Ultima Edición" />
			),
			cell: ({ row }) => {
				return (
					<p className="ml-2">{row.getValue("fechaUltimaEdicion")}</p>
				);
			},
		},
		{
			id: "actions",
			cell: ({ row }) => {
				const proveedor = row.original;

				return (
					<DropdownMenu>
						<DropdownMenuTrigger asChild>
							<Button
								variant="ghost"
								className="ml-auto h-8 w-8 p-0"
							>
								<span className="sr-only">Open menu</span>
								<MoreHorizontal className="h-4 w-4" />
							</Button>
						</DropdownMenuTrigger>
						<DropdownMenuContent align="end">
							<DropdownMenuLabel className="font-semibold">
								Acciones
							</DropdownMenuLabel>
							<DropdownMenuItem
								onClick={() => {
									onEdit(proveedor);
								}}
							>
								<SquarePen className="stroke-black" />
								Editar
							</DropdownMenuItem>
							<DropdownMenuItem
								className="text-red-500"
								onClick={() => {
									onDelete(proveedor);
								}}
							>
								<Trash2 className="stroke-red-500" />
								Eliminar
							</DropdownMenuItem>
							<DropdownMenuSeparator />
							<DropdownMenuItem
								onClick={() => {
									onScreening(proveedor);
								}}
							>
								<ScanSearch className="stroke-black" />
								Screening
							</DropdownMenuItem>
						</DropdownMenuContent>
					</DropdownMenu>
				);
			},
		},
	];

	return columns;
}

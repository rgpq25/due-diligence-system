import {
	InterpolHit,
	ScreeningResultTable,
	SecopHit,
	SMVHit,
} from "@/lib/types";
import { ColumnDef } from "@tanstack/react-table";

export const resultsColumns: ColumnDef<ScreeningResultTable>[] = [
	{
		accessorKey: "sourceName",
		header: () => (
			<p className="text-muted-foreground text-xs font-medium group-hover:text-black ml-2">
				Fuente
			</p>
		),
		cell: ({ row }) => {
			return <p className="ml-2 text-xs">{row.getValue("sourceName")}</p>;
		},
	},
	{
		accessorKey: "hits",
		header: () => (
			<p className="text-muted-foreground text-xs font-medium group-hover:text-black ml-2">
				Hits
			</p>
		),
		cell: ({ row }) => {
			return <p className="ml-2 text-xs">{row.getValue("hits")}</p>;
		},
	},
];

export const smvColumns: ColumnDef<SMVHit>[] = [
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
		accessorKey: "sancionado",
		header: () => (
			<p className="text-muted-foreground text-xs font-medium group-hover:text-black ml-2">
				Sancionado
			</p>
		),
		cell: ({ row }) => {
			return <p className="ml-2 text-xs">{row.getValue("sancionado")}</p>;
		},
	},
	{
		accessorKey: "tipo",
		header: () => (
			<p className="text-muted-foreground text-xs font-medium group-hover:text-black ml-2">
				Tipo de Sanción
			</p>
		),
		cell: ({ row }) => {
			return <p className="ml-2 text-xs">{row.getValue("tipo")}</p>;
		},
	},
	{
		accessorKey: "monto",
		header: () => (
			<p className="text-muted-foreground text-xs font-medium group-hover:text-black ml-2">
				Monto de Sanción
			</p>
		),
		cell: ({ row }) => {
			return <p className="ml-2 text-xs">{row.getValue("monto")}</p>;
		},
	},
];

export const secopColumns: ColumnDef<SecopHit>[] = [
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
		accessorKey: "documentoContratista",
		header: () => (
			<p className="text-muted-foreground text-xs font-medium group-hover:text-black ml-2">
				Documento Contratista
			</p>
		),
		cell: ({ row }) => {
			return (
				<p className="ml-2 text-xs">
					{row.getValue("documentoContratista")}
				</p>
			);
		},
	},
	{
		accessorKey: "nombreContratista",
		header: () => (
			<p className="text-muted-foreground text-xs font-medium group-hover:text-black ml-2">
				Nombre Contratista
			</p>
		),
		cell: ({ row }) => {
			return (
				<p className="ml-2 text-xs">
					{row.getValue("nombreContratista")}
				</p>
			);
		},
	},
	{
		accessorKey: "valorSancion",
		header: () => (
			<p className="text-muted-foreground text-xs font-medium group-hover:text-black ml-2">
				Valor de Sanción
			</p>
		),
		cell: ({ row }) => {
			return (
				<p className="ml-2 text-xs">{row.getValue("valorSancion")}</p>
			);
		},
	},
	{
		accessorKey: "fechaDePublicacion",
		header: () => (
			<p className="text-muted-foreground text-xs font-medium group-hover:text-black ml-2">
				Fecha de Publicación
			</p>
		),
		cell: ({ row }) => {
			const date = new Date(row.getValue("fechaDePublicacion"));
			const formattedDate = date.toLocaleDateString("es-PE", {
				year: "numeric",
				month: "long",
				day: "numeric",
			});

			return <p className="ml-2 text-xs">{formattedDate}</p>;
		},
	},
];

export const interpolColumns: ColumnDef<InterpolHit>[] = [
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
		accessorKey: "familyName",
		header: () => (
			<p className="text-muted-foreground text-xs font-medium group-hover:text-black ml-2">
				Family Names
			</p>
		),
		cell: ({ row }) => {
			return <p className="ml-2 text-xs">{row.getValue("familyName")}</p>;
		},
	},
	{
		accessorKey: "forename",
		header: () => (
			<p className="text-muted-foreground text-xs font-medium group-hover:text-black ml-2">
				Forename
			</p>
		),
		cell: ({ row }) => {
			return <p className="ml-2 text-xs">{row.getValue("forename")}</p>;
		},
	},
	{
		id: "nationalities",
		accessorFn: (row) => row.nationalities.join(", "),
		header: () => (
			<p className="text-muted-foreground text-xs font-medium group-hover:text-black ml-2">
				Nacionalidades
			</p>
		),
		cell: ({ row }) => {
			return (
				<p className="ml-2 text-xs">{row.getValue("nationalities")}</p>
			);
		},
	},
	{
		accessorKey: "dateOfBirth",
		header: () => (
			<p className="text-muted-foreground text-xs font-medium group-hover:text-black ml-2">
				Fecha de Nacimiento
			</p>
		),
		cell: ({ row }) => {
			return (
				<p className="ml-2 text-xs">{row.getValue("dateOfBirth")}</p>
			);
		},
	},
	{
		accessorKey: "link",
		header: () => (
			<p className="text-muted-foreground text-xs font-medium group-hover:text-black ml-2">
				Detalle
			</p>
		),
		cell: ({ row }) => {
			return <p className="ml-2 text-xs">{row.getValue("link")}</p>;
		},
	},
];

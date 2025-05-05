"use client";

import {
	ColumnDef,
	flexRender,
	getCoreRowModel,
	useReactTable,
} from "@tanstack/react-table";

import {
	Table,
	TableBody,
	TableCell,
	TableHead,
	TableHeader,
	TableRow,
} from "@/components/ui/table";
import { cn } from "@/lib/utils";

interface DataTableProps<TData, TValue> {
	className?: string;
	columns: ColumnDef<TData, TValue>[];
	data: TData[];
}

export function DataTable<TData, TValue>({
	className,
	columns,
	data,
}: DataTableProps<TData, TValue>) {
	const table = useReactTable({
		data,
		columns,
		getCoreRowModel: getCoreRowModel(),
	});

	function fetchScreening({
		razonSocial,
		nombreComercial,
		identificacionTributaria,
	}: {
		razonSocial: string;
		nombreComercial: string;
		identificacionTributaria: string;
	}) {
		console.log("Fetching screening for:", {
			razonSocial,
			nombreComercial,
			identificacionTributaria,
		});
        
		fetch(
			`http://localhost:3000/api/watchlist-check?razonSocial=${razonSocial}&nombreComercial=${nombreComercial}&identificacionTributaria=${identificacionTributaria}&sources=interpol,smv,secop`,
			{
				method: "GET",
				headers: {
					"Content-Type": "application/json",
				},
			}
		)
			.then((response) => response.json())
			.then((data) => console.log(data))
			.catch((error) => console.error(error));
	}

	return (
		<div className={cn("rounded-md border", className)}>
			<Table>
				<TableHeader>
					{table.getHeaderGroups().map((headerGroup) => (
						<TableRow key={headerGroup.id}>
							{headerGroup.headers.map((header) => {
								return (
									<TableHead key={header.id}>
										{header.isPlaceholder
											? null
											: flexRender(
													header.column.columnDef
														.header,
													header.getContext()
											  )}
									</TableHead>
								);
							})}
							<TableHead></TableHead>
						</TableRow>
					))}
				</TableHeader>
				<TableBody>
					{table.getRowModel().rows?.length ? (
						table.getRowModel().rows.map((row) => (
							<TableRow
								key={row.id}
								data-state={row.getIsSelected() && "selected"}
							>
								{row.getVisibleCells().map((cell) => (
									<TableCell key={cell.id}>
										{flexRender(
											cell.column.columnDef.cell,
											cell.getContext()
										)}
									</TableCell>
								))}
								<TableCell
									onClick={() =>
										fetchScreening({
											razonSocial:
												row.getValue("razonSocial"),
											nombreComercial:
												row.getValue("nombreComercial"),
											identificacionTributaria:
												row.getValue(
													"identificacionTributaria"
												),
										})
									}
								>
									Screen
								</TableCell>
							</TableRow>
						))
					) : (
						<TableRow>
							<TableCell
								colSpan={columns.length}
								className="h-24 text-center"
							>
								No results.
							</TableCell>
						</TableRow>
					)}
				</TableBody>
			</Table>
		</div>
	);
}

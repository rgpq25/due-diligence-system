import { useEffect, useState } from "react";
import { Proveedor } from "@/lib/types";
import { DataTable } from "@/components/proveedoresTable/data-table";
import { columns } from "@/components/proveedoresTable/columns";
import { Link } from "react-router-dom";
import { buttonVariants } from "@/components/ui/button";

export default function Proveedores() {
	const [proveedores, setProveedores] = useState<Proveedor[] | undefined>();

	async function getProveedores() {
		const response = await fetch("api/Proveedores", {
			method: "GET",
			headers: {
				"Content-Type": "application/json",
			},
		});
		if (response.ok) {
			const data = await response.json();
			setProveedores(data);
		} else {
			setProveedores([]); //TODO: HANDLE ERROR
		}
	}

	useEffect(() => {
		getProveedores();
	}, []);

	const contents =
		proveedores === undefined ? (
			<p>
				<em>
					Loading... Please refresh once the ASP.NET backend has
					started.
				</em>
			</p>
		) : (
			<DataTable className="mt-4" columns={columns} data={proveedores} />
		);

	return (
		<main className="p-8">
			<header className="flex flex-row justify-between items-center">
				<section className="flex flex-col">
					<p className="text-3xl font-bold">Proveedores</p>
					<p className="text-muted-foreground">
						Explora los proveedores disponibles en el sistema.
					</p>
				</section>
				<Link
					className={buttonVariants({ size: "lg" })}
					to={"/nuevo-proveedor"}
				>
					Crear proveedor
				</Link>
			</header>
			{contents}
		</main>
	);
}

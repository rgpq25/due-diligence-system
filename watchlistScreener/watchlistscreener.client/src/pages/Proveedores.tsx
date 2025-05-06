import NewProveedorModal from "@/components/new-proveedor-modal";
import { columns } from "@/components/proveedoresTable/columns";
import { DataTable } from "@/components/proveedoresTable/data-table";
import { Button } from "@/components/ui/button";
import { Proveedor } from "@/lib/types";
import { Loader2 } from "lucide-react";
import { useEffect, useState } from "react";

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
			<main className="flex-1 flex">
				<Loader2 className="animate-spin size-8 m-auto" />
			</main>
		) : (
			<DataTable className="" columns={columns} data={proveedores} />
		);

	return (
		<main className="p-8 flex flex-col min-h-dvh">
			<header className="flex flex-row justify-between items-center">
				<section className="flex flex-col">
					<p className="text-3xl font-bold">Proveedores</p>
					<p className="text-muted-foreground">
						Explora los proveedores disponibles en el sistema.
					</p>
				</section>
				{/* <Link
					className={buttonVariants({ size: "lg" })}
					to={"/nuevo-proveedor"}
				>
					Crear proveedor
				</Link> */}
				<NewProveedorModal>
					<Button>Crear proveedor</Button>
				</NewProveedorModal>
			</header>
			{contents}
		</main>
	);
}

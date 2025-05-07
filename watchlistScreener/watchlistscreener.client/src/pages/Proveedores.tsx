import DeleteProveedorModal from "@/components/delete-proveedor-modal";
import EditProveedorModal from "@/components/edit-proveedor-modal";
import NewProveedorModal from "@/components/new-proveedor-modal";
import { getColumns } from "@/components/proveedoresTable/columns";
import { DataTable } from "@/components/proveedoresTable/data-table";
import { Button } from "@/components/ui/button";
import { Proveedor } from "@/lib/types";
import { Loader2 } from "lucide-react";
import { useEffect, useState } from "react";
import { toast } from "sonner";

export default function Proveedores() {
	const [proveedores, setProveedores] = useState<Proveedor[] | undefined>();
	const [proveedorToEdit, setProveedorToEdit] = useState<Proveedor | null>(
		null
	);
	const [proveedorToDelete, setProveedorToDelete] =
		useState<Proveedor | null>(null);

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
			setProveedores([]);
			toast.error("Error al cargar los proveedores");
		}
	}

	function addProveedor(newProveedor: Proveedor) {
		setProveedores((prev) =>
			prev ? [...prev, newProveedor] : [newProveedor]
		);
	}

	function editProveedor(editedProveedor: Proveedor) {
		setProveedores((prev) => {
			if (prev === undefined) return;

			return prev.map((proveedor) =>
				proveedor.id === editedProveedor.id
					? editedProveedor
					: proveedor
			);
		});
	}

	function deleteProveedor(id: Proveedor["id"]) {
		setProveedores((prev) => {
			if (prev === undefined) return;

			return prev.filter((proveedor) => proveedor.id !== id);
		});
	}

	const columns = getColumns({
		onEdit: (proveedor) => {
			setProveedorToEdit(proveedor);
		},
		onDelete: (proveedor) => {
			setProveedorToDelete(proveedor);
		},
		onScreening: (proveedor) => {
			console.log("Screening for: ", proveedor);
		},
	});

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
				<NewProveedorModal addProveedor={addProveedor}>
					<Button>Crear proveedor</Button>
				</NewProveedorModal>
			</header>
			{contents}

			<EditProveedorModal
				selectedProveedor={proveedorToEdit}
				setSelectedProveedor={setProveedorToEdit}
				editProveedor={editProveedor}
			/>
			<DeleteProveedorModal
				selectedProveedor={proveedorToDelete}
				setSelectedProveedor={setProveedorToDelete}
				deleteProveedor={deleteProveedor}
			/>
		</main>
	);
}

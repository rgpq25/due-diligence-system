import {
	Dialog,
	DialogClose,
	DialogContent,
	DialogDescription,
	DialogFooter,
	DialogHeader,
	DialogTitle,
} from "@/components/ui/dialog";
import { Proveedor } from "@/lib/types";
import { useState } from "react";
import { toast } from "sonner";
import { Button } from "./ui/button";

function DeleteProveedorModal({
	selectedProveedor,
	setSelectedProveedor,
	deleteProveedor,
}: {
	selectedProveedor: Proveedor | null;
	setSelectedProveedor: (proveedor: Proveedor | null) => void;
	deleteProveedor: (id: Proveedor["id"]) => void;
}) {
	const [isSubmitting, setIsSubmitting] = useState(false);

	async function onSubmit() {
		if (!selectedProveedor) return;

		try {
			setIsSubmitting(true);
			const response = await fetch(
				`api/Proveedores/${selectedProveedor.id}`,
				{
					method: "DELETE",
					headers: {
						"Content-Type": "application/json",
					},
				}
			);

			if (!response.ok) {
				throw new Error("Error eliminando proveedor");
			}

			setSelectedProveedor(null);
			deleteProveedor(selectedProveedor.id);
		} catch (error) {
			console.error("Error eliminando proveedor:", error);
			toast.error("Error eliminando proveedor");
		} finally {
			setIsSubmitting(false);
		}
	}

	return (
		<Dialog
			open={selectedProveedor !== null}
			onOpenChange={(open) => {
				if (!open) {
					setSelectedProveedor(null);
				}
			}}
		>
			<DialogContent>
				<DialogHeader>
					<DialogTitle>Estas seguro?</DialogTitle>
					<DialogDescription>
						Esta acción no se puede deshacer. Esto borrará al
						proveedor seleccionado permanentemente.
					</DialogDescription>
				</DialogHeader>
				<DialogFooter>
					<DialogClose asChild>
						<Button variant="outline" disabled={isSubmitting}>
							Cancelar
						</Button>
					</DialogClose>
					<Button
						variant="destructive"
						onClick={() => {
							if (selectedProveedor) {
								onSubmit();
							}
						}}
						loading={isSubmitting}
					>
						Eliminar
					</Button>
				</DialogFooter>
			</DialogContent>
		</Dialog>
	);
}
export default DeleteProveedorModal;

import {
	Dialog,
	DialogContent,
	DialogHeader,
	DialogTitle,
} from "@/components/ui/dialog";
import { Pais, Proveedor } from "@/lib/types";
import { DialogDescription } from "@radix-ui/react-dialog";
import { Loader2 } from "lucide-react";
import { useEffect, useState } from "react";
import ProveedorForm from "./proveedor-form";
import { toast } from "sonner";

function EditProveedorModal({
	selectedProveedor,
	setSelectedProveedor,
	editProveedor,
}: {
	selectedProveedor: Proveedor | null;
	setSelectedProveedor: (proveedor: Proveedor | null) => void;
	editProveedor: (editedProveedor: Proveedor) => void;
}) {
	const [countries, setCountries] = useState<Pais[] | undefined>();

	useEffect(() => {
		async function fetchCountries() {
			try {
				const response = await fetch("api/Paises");
				const data: Pais[] = await response.json();
				setCountries(data);
			} catch (error) {
				console.error("Error fetching countries:", error);
				setCountries([]);
			}
		}
		fetchCountries();
	}, []);

	return (
		<Dialog
			open={selectedProveedor !== null}
			onOpenChange={(open) => {
				if (!open) {
					setSelectedProveedor(null);
				}
			}}
		>
			{countries === undefined ? (
				<DialogContent className="flex">
					<DialogTitle className="sr-only">
						Crear un proveedor
					</DialogTitle>
					<DialogDescription className="sr-only">
						Loading
					</DialogDescription>
					<Loader2 className="animate-spin size-8 m-auto" />
				</DialogContent>
			) : (
				<DialogContent
					className="w-[50rem] max-w-[50rem] min-w-[50rem]"
					aria-describedby="Atributos necesarios para crear un proveedor"
				>
					<DialogHeader>
						<DialogTitle>Editar un proveedor</DialogTitle>
						<DialogDescription className="sr-only">
							Crea un proveedor con los atributos de el formulario
						</DialogDescription>
					</DialogHeader>

					<ProveedorForm
						countries={countries}
						proveedor={
							selectedProveedor || {
								id: "",
								razonSocial: "",
								nombreComercial: "",
								identificacionTributaria: 0,
								numeroTelefonico: "",
								correoElectronico: "",
								sitioWeb: "",
								direccionFisica: "",
								paisId: "",
								facturacionAnual: 0,
								fechaUltimaEdicion: "",
							}
						}
						onSuccess={(editedProveedor) => {
							toast.success("Proveedor editado con éxito");
							setSelectedProveedor(null);
							editProveedor(editedProveedor);
						}}
						onError={() => {
							toast.error("Error editando proveedor");
						}}
					/>
				</DialogContent>
			)}
		</Dialog>
	);
}
export default EditProveedorModal;

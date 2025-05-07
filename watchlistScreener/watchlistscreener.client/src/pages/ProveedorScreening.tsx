import { DataTable } from "@/components/screeningResultTable/data-table";
import {
	interpolColumns,
	resultsColumns,
	secopColumns,
	smvColumns,
} from "@/components/screeningResultTable/columns";
import { Button } from "@/components/ui/button";
import { Switch } from "@/components/ui/switch";
import { useEffect, useState } from "react";
import {
	InterpolHit,
	Proveedor,
	ScreeningData,
	ScreeningResultTable,
	SecopHit,
	SMVHit,
} from "@/lib/types";
import { toast } from "sonner";
import { ColumnDef } from "@tanstack/react-table";
import { Separator } from "@/components/ui/separator";
import { Loader2 } from "lucide-react";
import { useParams } from "react-router-dom";

type SourceName = "smv" | "secop" | "interpol";

type SourceState<T> = {
	name: string;
	description: string;
	isChecked: boolean;
	data: T[] | null;
};

type SourcesState = Record<
	SourceName,
	SourceState<SMVHit | SecopHit | InterpolHit>
>;

const columnsMap: Record<
	SourceName,
	ColumnDef<SMVHit | SecopHit | InterpolHit>[]
> = {
	smv: smvColumns as ColumnDef<SMVHit | SecopHit | InterpolHit>[],
	secop: secopColumns as ColumnDef<SMVHit | SecopHit | InterpolHit>[],
	interpol: interpolColumns as ColumnDef<SMVHit | SecopHit | InterpolHit>[],
};

function ProveedorScreening() {
	const params = useParams();
	const proveedorId = params.proveedorId;

	const [proveedor, setProveedor] = useState<Proveedor | null>(null);

	const [isLoading, setIsLoading] = useState(false);
	const [sourcesState, setSourcesState] = useState<SourcesState>({
		smv: {
			name: "SMV",
			description: "Base de datos de personas naturales y jurídicas",
			isChecked: false,
			data: null,
		},
		secop: {
			name: "SECOP I",
			description: "Lista de entidades sancionadas",
			isChecked: false,
			data: null,
		},
		interpol: {
			name: "Interpol",
			description: "Lista roja de personas buscadas",
			isChecked: false,
			data: null,
		},
	});

	const [viewingSource, setViewingSource] = useState<SourceName | null>(null);
	const currentSourceData = sourcesState[viewingSource as SourceName];

	const resultData: ScreeningResultTable[] = Object.keys(sourcesState).map(
		(sourceKey) => {
			const currentSource = sourcesState[sourceKey as SourceName];
			return {
				sourceName: currentSource.name,
				hits: currentSource.data?.length.toString() ?? "0",
			};
		}
	);

	async function fetchScreening() {
		if (!proveedor) {
			toast.error("El proveedor no existe");
			return;
		}

		try {
			const sourcesToCheck = Object.entries(sourcesState).filter(
				([, value]) => value.isChecked
			);
			setIsLoading(true);
			const res = await fetch(
				`http://localhost:3000/api/watchlist-check?razonSocial=${proveedor.razonSocial}&nombreComercial=${proveedor.nombreComercial}&identificacionTributaria=${proveedor.identificacionTributaria}&sources=${sourcesToCheck}`,
				{ headers: { "Content-Type": "application/json" } }
			);

			if (!res.ok) {
				throw new Error("Error al realizar el cruce");
			}

			const data: ScreeningData = await res.json();
			console.log(data);

			setSourcesState((prev) => ({
				smv: { ...prev.smv, data: data.smv },
				secop: { ...prev.secop, data: data.secop },
				interpol: { ...prev.interpol, data: data.interpol },
			}));

			const firstChecked: SourceName | undefined = Object.entries(
				sourcesState
			).find(([, value]) => value.isChecked)?.[0] as SourceName;

			setViewingSource(firstChecked ?? null);
		} catch (err) {
			console.error(err);
			toast.error("Error al realizar el cruce");
		} finally {
			setIsLoading(false);
		}
	}

	useEffect(() => {
		async function getProveedor() {
			if (proveedorId) {
				console.log("Fetching with " + proveedorId);
				const res = await fetch(`/api/Proveedores/${proveedorId}`, {
					method: "GET",
					headers: {
						"Content-Type": "application/json",
					},
				});

				console.log(res);

				if (res.ok) {
					const data = await res.json();
					setProveedor(data);
				} else {
					window.location.href = "/";
				}
			}
		}
		getProveedor();
	}, [proveedorId]);

	if (!proveedor) {
		return (
			<main className="min-h-dvh flex">
				<Loader2 className="animate-spin size-8 m-auto" />
			</main>
		);
	}

	return (
		<main className="p-8 flex flex-col min-h-dvh">
			<header className="flex flex-row items-start justify-between gap-4">
				<section className="flex flex-row justify-between items-center">
					<section className="flex flex-col">
						<p className="text-3xl font-bold">
							Screening de Proveedor
						</p>
						<p className="text-muted-foreground">
							Realiza una busqueda a través de diferentes fuentes
							para verificar la integridad de un proveedor.
						</p>
					</section>
				</section>
				<section className="flex flex-col justify-end text-end text-muted-foreground shrink-0">
					<p>{`Razon Social: ${proveedor.razonSocial}`}</p>
					<p>{`Nombre Comercial: ${proveedor.nombreComercial}`}</p>
					<p>{`ID Tributaria: ${proveedor.identificacionTributaria}`}</p>
				</section>
			</header>
			<div className="mt-3 flex flex-row items-center gap-2 px-4">
				<section className="flex flex-col gap-1 w-1/2">
					<h3 className="font-medium text-lg">
						Selecciona las fuentes para el cruce
					</h3>
					{Object.keys(sourcesState).map((sourceKey, idx) => {
						const currentSource =
							sourcesState[sourceKey as SourceName];
						return (
							<section
								className="flex flex-row items-center gap-2"
								key={idx}
							>
								<Switch
									disabled={isLoading}
									checked={currentSource.isChecked}
									onCheckedChange={(checked) =>
										setSourcesState((prev) => ({
											...prev,
											[sourceKey as SourceName]: {
												...prev[
													sourceKey as SourceName
												],
												isChecked: checked,
											},
										}))
									}
								/>
								<p>{`${currentSource.name} - ${currentSource.description}`}</p>
							</section>
						);
					})}
				</section>
				<section className="w-1/2">
					<DataTable columns={resultsColumns} data={resultData} />
				</section>
			</div>
			<div className="mt-6 flex w-full items-center gap-4">
				<Separator orientation="horizontal" className="flex-1" />
				<Button
					className="w-40 mx-auto"
					disabled={
						!Object.entries(sourcesState).some(
							([, value]) => value.isChecked
						) || isLoading
					}
					size={"lg"}
					onClick={() => fetchScreening()}
				>
					Buscar
				</Button>
				<Separator orientation="horizontal" className="flex-1" />
			</div>

			{isLoading ? (
				<section className="flex flex-1">
					<Loader2 className="animate-spin size-8 m-auto" />
				</section>
			) : viewingSource && currentSourceData?.data ? (
				<>
					<div className="mt-6 flex justify-end items-center">
						{Object.keys(sourcesState).map((sourceKey, idx) => {
							const currentSource =
								sourcesState[sourceKey as SourceName];
							return (
								<Button
									key={idx}
									variant="outline"
									className="w-40 rounded-bl-none rounded-br-none border-b-0"
									onClick={() => {
										setViewingSource(
											sourceKey as SourceName
										);
									}}
									disabled={currentSource.data === null}
								>
									{currentSource.name}
								</Button>
							);
						})}
					</div>
					<DataTable
						columns={columnsMap[viewingSource as SourceName]}
						data={currentSourceData.data}
						className="mt-0 rounded-tr-none"
					/>
				</>
			) : (
				<section className="flex flex-1">
					<p className="m-auto text-muted-foreground">
						Empieza la busqueda para ver los cruces.
					</p>
				</section>
			)}
		</main>
	);
}
export default ProveedorScreening;

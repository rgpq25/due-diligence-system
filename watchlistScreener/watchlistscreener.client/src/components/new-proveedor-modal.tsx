import {
	Dialog,
	DialogClose,
	DialogContent,
	DialogFooter,
	DialogHeader,
	DialogTitle,
	DialogTrigger,
} from "@/components/ui/dialog";
import { Pais } from "@/lib/types";
import { cn } from "@/lib/utils";
import { nuevoProveedorSchema } from "@/schemas/nuevoProveedorScheme";
import { zodResolver } from "@hookform/resolvers/zod";
import { Check, ChevronsUpDown, Loader2 } from "lucide-react";
import { useEffect, useState } from "react";
import { useForm } from "react-hook-form";
import { z } from "zod";
import { Button } from "./ui/button";
import {
	Command,
	CommandEmpty,
	CommandGroup,
	CommandInput,
	CommandItem,
	CommandList,
} from "./ui/command";
import {
	Form,
	FormControl,
	FormField,
	FormItem,
	FormLabel,
	FormMessage,
} from "./ui/form";
import { Input } from "./ui/input";
import { Popover, PopoverContent, PopoverTrigger } from "./ui/popover";
import { toast } from "sonner";

function NewProveedorModal({ children }: { children: React.ReactNode }) {
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

	const form = useForm<z.infer<typeof nuevoProveedorSchema>>({
		resolver: zodResolver(nuevoProveedorSchema),
		defaultValues: {
			razonSocial: "",
			nombreComercial: "",
			identificacionTributaria: 0,
			numeroTelefonico: "",
			correoElectronico: "",
			sitioWeb: "",
			direccionFisica: "",
			paisId: "",
			facturacionAnual: 0,
		},
	});

	async function onSubmit(values: z.infer<typeof nuevoProveedorSchema>) {
		try {
			const response = await fetch("api/Proveedores", {
				method: "POST",
				headers: {
					"Content-Type": "application/json",
				},
				body: JSON.stringify(values),
			});

			window.location.href = "/";
			console.log(response);
		} catch (error) {
			console.error("Error creating provider:", error);
		}
		toast.success("Proveedor creado con éxito");
	}

	return (
		<Dialog>
			<DialogTrigger asChild>{children}</DialogTrigger>
			{countries === undefined ? (
				<DialogContent>
					<Loader2 className="animate-spin size-8" />
				</DialogContent>
			) : (
				<DialogContent className="w-[50rem] max-w-[50rem] min-w-[50rem]">
					<DialogHeader>
						<DialogTitle>Crear un proveedor</DialogTitle>
					</DialogHeader>

					<Form {...form}>
						<form
							onSubmit={form.handleSubmit(onSubmit)}
							className="flex flex-col space-y-3"
						>
							<FormField
								control={form.control}
								name="razonSocial"
								render={({ field }) => (
									<FormItem>
										<FormLabel>Razón Social</FormLabel>
										<FormControl>
											<Input
												placeholder="Introduce la razón social"
												{...field}
											/>
										</FormControl>
										<FormMessage />
									</FormItem>
								)}
							/>
							<FormField
								control={form.control}
								name="nombreComercial"
								render={({ field }) => (
									<FormItem>
										<FormLabel>Nombre comercial</FormLabel>
										<FormControl>
											<Input
												placeholder="Introduce el nombre comercial"
												{...field}
											/>
										</FormControl>
										<FormMessage />
									</FormItem>
								)}
							/>
							<section className="flex flex-row items-start gap-4">
								<FormField
									control={form.control}
									name="identificacionTributaria"
									render={({ field }) => (
										<FormItem className="w-1/2">
											<FormLabel>
												Identificación tributaria
											</FormLabel>
											<FormControl>
												<Input
													placeholder="Introduce la identificación triutaria"
													{...field}
													type="number"
													onChange={(e) =>
														field.onChange(
															e.target.value ===
																""
																? undefined
																: +e.target
																		.value
														)
													}
												/>
											</FormControl>
											<FormMessage />
										</FormItem>
									)}
								/>
								<FormField
									control={form.control}
									name="numeroTelefonico"
									render={({ field }) => (
										<FormItem className="w-1/2">
											<FormLabel>
												Numero telefonico
											</FormLabel>
											<FormControl>
												<Input
													placeholder="Introduce el numero telefonico"
													{...field}
												/>
											</FormControl>
											<FormMessage />
										</FormItem>
									)}
								/>
							</section>
							<FormField
								control={form.control}
								name="correoElectronico"
								render={({ field }) => (
									<FormItem>
										<FormLabel>
											Correo electronico
										</FormLabel>
										<FormControl>
											<Input
												placeholder="Introduce el correo electronico"
												{...field}
											/>
										</FormControl>
										<FormMessage />
									</FormItem>
								)}
							/>
							<FormField
								control={form.control}
								name="sitioWeb"
								render={({ field }) => (
									<FormItem>
										<FormLabel>Sitio Web</FormLabel>
										<FormControl>
											<Input
												placeholder="Introduce el sitio web"
												{...field}
											/>
										</FormControl>
										<FormMessage />
									</FormItem>
								)}
							/>
							<FormField
								control={form.control}
								name="direccionFisica"
								render={({ field }) => (
									<FormItem>
										<FormLabel>Dirección fisica</FormLabel>
										<FormControl>
											<Input
												placeholder="Introduce la dirección fisica"
												{...field}
											/>
										</FormControl>
										<FormMessage />
									</FormItem>
								)}
							/>

							<FormField
								control={form.control}
								name="paisId"
								render={({ field }) => {
									const selectedCountry = countries.find(
										(country) => country.id === field.value
									);

									return (
										<FormItem className="flex flex-col">
											<FormLabel>País</FormLabel>
											<Popover modal={true}>
												<PopoverTrigger asChild>
													<FormControl>
														<Button
															variant="outline"
															role="combobox"
															className={cn(
																"justify-between",
																!selectedCountry &&
																	"text-muted-foreground"
															)}
														>
															{selectedCountry
																? `${selectedCountry.codigo} - ${selectedCountry.nombre}`
																: "Selecciona un país"}
															<ChevronsUpDown className="ml-2 h-4 w-4 shrink-0 opacity-50" />
														</Button>
													</FormControl>
												</PopoverTrigger>
												<PopoverContent className="p-0 w-[var(--radix-popover-trigger-width)]">
													<Command>
														<CommandInput placeholder="Buscar país..." />
														<CommandList>
															<CommandEmpty>
																<p className="text-muted-foreground">
																	No hay
																	resultados.
																</p>
															</CommandEmpty>
															<CommandGroup>
																{countries.map(
																	(
																		country
																	) => (
																		<CommandItem
																			value={
																				country.id
																			}
																			key={
																				country.id
																			}
																			onSelect={() => {
																				form.setValue(
																					"paisId",
																					country.id
																				);
																			}}
																		>
																			{`${country.codigo} - ${country.nombre}`}
																			<Check
																				className={cn(
																					"ml-auto",
																					country.id ===
																						selectedCountry?.id
																						? "opacity-100"
																						: "opacity-0"
																				)}
																			/>
																		</CommandItem>
																	)
																)}
															</CommandGroup>
														</CommandList>
													</Command>
												</PopoverContent>
											</Popover>
											<FormMessage />
										</FormItem>
									);
								}}
							></FormField>

							<FormField
								control={form.control}
								name="facturacionAnual"
								render={({ field }) => (
									<FormItem>
										<FormLabel>Facturación Anual</FormLabel>
										<FormControl>
											<Input
												placeholder="Introduce la facturación anual"
												{...field}
												type="number"
												onChange={(e) =>
													field.onChange(
														e.target.value === ""
															? undefined
															: +e.target.value
													)
												}
											/>
										</FormControl>
										<FormMessage />
									</FormItem>
								)}
							/>
							<DialogFooter className="mt-1">
								<DialogClose asChild>
									<Button variant="outline">Cancelar</Button>
								</DialogClose>
								<Button type="submit">Crear proveedor</Button>
							</DialogFooter>
						</form>
					</Form>
				</DialogContent>
			)}
		</Dialog>
	);
}
export default NewProveedorModal;

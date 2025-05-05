import { Button } from "@/components/ui/button";
import {
	Command,
	CommandGroup,
	CommandInput,
	CommandItem,
	CommandList,
	CommandEmpty,
} from "@/components/ui/command";
import {
	Form,
	FormControl,
	FormField,
	FormItem,
	FormLabel,
	FormMessage,
} from "@/components/ui/form";
import { Input } from "@/components/ui/input";
import {
	Popover,
	PopoverContent,
	PopoverTrigger,
} from "@/components/ui/popover";
import { Pais } from "@/lib/types";
import { cn } from "@/lib/utils";
import { zodResolver } from "@hookform/resolvers/zod";
import { Check, ChevronsUpDown, Loader2 } from "lucide-react";
import { useEffect, useState } from "react";
import { useForm } from "react-hook-form";
import { z } from "zod";

const nuevoProveedorSchema = z.object({
	razonSocial: z
		.string({
			required_error: "La razón social es obligatoria",
		})
		.min(1, {
			message: "La razón social es obligatoria",
		}),
	nombreComercial: z
		.string({
			required_error: "El nombre comercial es obligatorio",
		})
		.min(1, {
			message: "El nombre comercial es obligatorio",
		}),
	identificacionTributaria: z
		.number({
			invalid_type_error:
				"La identificación tributaria debe ser un número",
			message: "La identificación tributaria es obligatoria",
		})
		.refine((val) => val.toString().length === 11, {
			message:
				"La identificación tributaria debe tener exactamente 11 dígitos",
		}),
	numeroTelefonico: z
		.string({
			required_error: "El número telefónico es obligatorio",
		})
		.min(1, {
			message: "El número telefónico es obligatorio",
		}),
	correoElectronico: z
		.string({
			required_error: "El correo electrónico es obligatorio",
		})
		.email({
			message: "El correo electrónico no es válido",
		}),
	sitioWeb: z
		.string({
			required_error: "El sitio web es obligatorio",
		})
		.url({
			message: "El sitio web no es válido",
		}),
	direccionFisica: z
		.string({
			required_error: "La dirección física es obligatoria",
		})
		.min(1, {
			message: "La dirección física es obligatoria",
		}),
	paisId: z.string().nonempty({
		message: "El país es obligatorio",
	}),
	facturacionAnual: z.number({
		invalid_type_error: "La identificación tributaria debe ser un número",
		message: "La identificación tributaria es obligatoria",
	}),
});

export default function NuevoProveedor() {
	const [countries, setCountries] = useState<Pais[] | undefined>();

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
		console.log(values);
	}

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

	if (countries === undefined) {
		return (
			<main className="w-dvw h-dvh flex justify-center items-center">
				<Loader2 className="animate-spin size-8" />
			</main>
		);
	}

	return (
		<main className="p-8">
			<header className="flex flex-row justify-between items-center mb-4">
				<section className="flex flex-col">
					<p className="text-3xl font-bold">Nuevo proveedor</p>
					<p className="text-muted-foreground">
						Añade un nuevo proveedor al sistema.
					</p>
				</section>
			</header>

			<Form {...form}>
				<form
					onSubmit={form.handleSubmit(onSubmit)}
					className="space-y-2"
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
					<FormField
						control={form.control}
						name="identificacionTributaria"
						render={({ field }) => (
							<FormItem>
								<FormLabel>Identificación tributaria</FormLabel>
								<FormControl>
									<Input
										placeholder="Introduce la identificación triutaria"
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
					<FormField
						control={form.control}
						name="numeroTelefonico"
						render={({ field }) => (
							<FormItem>
								<FormLabel>Numero telefonico</FormLabel>
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
					<FormField
						control={form.control}
						name="correoElectronico"
						render={({ field }) => (
							<FormItem>
								<FormLabel>Correo electronico</FormLabel>
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
									<Popover>
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
															No hay resultados.
														</p>
													</CommandEmpty>
													<CommandGroup>
														{countries.map(
															(country) => (
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
					<Button type="submit">Submit</Button>
				</form>
			</Form>
		</main>
	);
}

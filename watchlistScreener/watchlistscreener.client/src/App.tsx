import { useEffect, useState } from "react";
import "./index.css";
import { Button } from "./components/ui/button";
import { Proveedor } from "./lib/types";

function App() {
	const [proveedores, setProveedores] = useState<Proveedor[] | undefined>();

	async function getProveedores() {
		const response = await fetch("api/Proveedores");
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
					started. See{" "}
					<a href="https://aka.ms/jspsintegrationreact">
						https://aka.ms/jspsintegrationreact
					</a>{" "}
					for more details.
				</em>
			</p>
		) : (
			<table className="table table-striped" aria-labelledby="tableLabel">
				<thead>
					<tr>
						<th>#</th>
						<th>Razon Social</th>
						<th>Nombre Comercial</th>
						<th>Identificacion Tributaria</th>
						<th>Numero telefonico</th>
                        <th>Correo electronico</th>
					</tr>
				</thead>
				<tbody>
					{proveedores.map((proveedor, idx) => (
						<tr key={proveedor.razonSocial}>
							<td>{idx}</td>
							<td>{proveedor.nombreComercial}</td>
							<td>{proveedor.identifcacionTributaria}</td>
							<td>{proveedor.numeroTelefonico}</td>
							<td>{proveedor.correoElectronico}</td>
						</tr>
					))}
				</tbody>
			</table>
		);

	return (
		<div className="p-6">
			<p className="text-4xl font-bold">Proveedores</p>
			<p className="text-muted-foreground">
				This component demonstrates fetching data from the server.
			</p>
			{contents}
		</div>
	);
}

export default App;

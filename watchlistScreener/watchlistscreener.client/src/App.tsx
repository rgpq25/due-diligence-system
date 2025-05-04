import { BrowserRouter, Route, Routes } from "react-router-dom";
import Proveedores from "./pages/Proveedores";
import "./index.css";
import NuevoProveedor from "./pages/NuevoProveedor";

function App() {
	return (
		<BrowserRouter>
			<Routes>
				<Route path="/" element={<Proveedores />} />
                <Route path="/nuevo-proveedor" element={<NuevoProveedor />} />
			</Routes>
		</BrowserRouter>
	);
}

export default App;

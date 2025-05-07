import { BrowserRouter, Route, Routes } from "react-router-dom";
import { Toaster } from "sonner";
import "./index.css";
import Proveedores from "./pages/Proveedores";
import ProveedorScreening from "./pages/ProveedorScreening";

function App() {
	return (
		<BrowserRouter>
			<Routes>
				<Route path="/" element={<Proveedores />} />
				<Route path="/screening" element={<ProveedorScreening />} />
			</Routes>
			<Toaster richColors />
		</BrowserRouter>
	);
}

export default App;

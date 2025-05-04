import { Login } from "./components/auth/Login";
import { Counter } from "./components/Counter";
import { FetchData } from "./components/FetchData";
import { Home } from "./components/Home";

const AppRoutes = [
	{
		index: true,
		element: <Home />,
	},
	{
		path: "/counter",
		element: <Counter />,
	},
	{
		path: "/fetch-data",
		element: <FetchData />,
	},
	{
		path: "/auth/login",
		element: <Login />,
	},
];

export default AppRoutes;

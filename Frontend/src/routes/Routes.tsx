import { Route, Routes } from "react-router-dom";

// Views and Components
import Home from "./../views/home/Home";
import NotFound from "../views/error/NotFound";

function Router() {
  return (
    <Routes>
      <Route path="/" element={<Home />} />
      <Route path="*" element={<NotFound />} />
    </Routes>
  );
}

export default Router;

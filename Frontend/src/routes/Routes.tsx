import { Route, Routes } from "react-router-dom";

// Views and Components
import Home from "./../views/home/Home";
import Books from "../views/books/Books";
import Author from "./../views/authors/Authors";
import Publisher from "../views/publishers/Publisher";
import NotFound from "../views/error/NotFound";

function Router() {
  return (
    <Routes>
      <Route path="/" element={<Home />} />
      <Route path="/books" element={<Books />} />
      <Route path="/authors" element={<Author />} />
      <Route path="/publishers" element={<Publisher />} />
      <Route path="*" element={<NotFound />} />
    </Routes>
  );
}

export default Router;

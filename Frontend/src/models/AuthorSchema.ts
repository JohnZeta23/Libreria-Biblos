import { iBook } from "./BookSchema";

export interface iAuthor {
  map: any;
  nombre: string;
  apellido: string;
  libros?: iBook[];
}

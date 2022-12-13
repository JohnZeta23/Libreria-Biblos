import { iBook } from "./BookSchema";

export interface iPublisher {
  map: any;
  nombre: string;
  libros?: iBook[];
}

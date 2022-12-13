import {
  Button,
  Table,
  TableContainer,
  Tbody,
  Td,
  Th,
  Thead,
  Tr,
} from "@chakra-ui/react";
import React from "react";

import { iBook } from "../../models/BookSchema";

type Props = {};

function Books({}: Props) {
  const [books, setbooks] = React.useState<iBook>();
  let key: number = 0;

  React.useEffect(() => {
    fetch("https://localhost:44368/api/v1/libro/getAll")
      .then((response) => {
        if (response.ok) return response.json();
      })
      .then((data) => {
        setbooks(data);
      })
      .catch((err) => console.log(err));
  }, []);

  return (
    <TableContainer bg="white" shadow="md" m={10}>
      <Table size="md">
        <Thead>
          <Tr>
            <Th>Título</Th>
            <Th>Código</Th>
            <Th>Fecha de Publicación</Th>
            <Th>Precio</Th>
            <Th>Stock</Th>
            <Th>Autor</Th>
            <Th>Editorial</Th>
            <Th textAlign="center">Opciones</Th>
          </Tr>
        </Thead>
        <Tbody>
          {books &&
            books.map((book: iBook) => (
              <Tr key={key}>
                <Td>{book.nombre}</Td>
                <Td>{book.codigo}</Td>
                <Td>{new Date(book.publicacion).toLocaleDateString()}</Td>
                <Td>${book.precio}.00</Td>
                <Td>{book.stock}</Td>
                <Td>{book.autorId}</Td>
                <Td>{book.editorialId}</Td>
                <Td display="flex" justifyContent="center" gap={3}>
                  <Button colorScheme="gray">Editar</Button>
                  <Button colorScheme="red">Eliminar</Button>
                </Td>
              </Tr>
            ))}
        </Tbody>
      </Table>
    </TableContainer>
  );
}

export default Books;

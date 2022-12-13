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

import { iAuthor } from "../../models/AuthorSchema";

type Props = {};

function Authors({}: Props) {
  const [authors, setAuthors] = React.useState<iAuthor>();
  let key: number = 0;

  React.useEffect(() => {
    fetch("https://localhost:44368/api/v1/autor/getAll")
      .then((response) => {
        if (response.ok) return response.json();
      })
      .then((data) => {
        setAuthors(data);
      })
      .catch((err) => console.log(err));
  }, []);

  return (
    <TableContainer bg="white" shadow="md" m={10}>
      <Table size="md">
        <Thead>
          <Tr>
            <Th>Nombre</Th>
            <Th>Apellido</Th>
            <Th>Cantidad de libros</Th>
            <Th textAlign="center">Opciones</Th>
          </Tr>
        </Thead>
        <Tbody>
          {authors &&
            authors.map((author: iAuthor) => (
              <Tr key={key}>
                <Td>{author.nombre}</Td>
                <Td>{author.apellido}</Td>
                <Td>{author?.libros?.length}</Td>
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

export default Authors;

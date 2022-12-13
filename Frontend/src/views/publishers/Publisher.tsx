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

import { iPublisher } from "../../models/PublisherSchema";

type Props = {};

function Publisher({}: Props) {
  const [publishers, setPublishers] = React.useState<iPublisher>();
  let key: number = 0;

  React.useEffect(() => {
    fetch("https://localhost:44368/api/v1/editrial/getAll")
      .then((response) => {
        if (response.ok) return response.json();
      })
      .then((data) => {
        setPublishers(data);
      })
      .catch((err) => console.log(err));
  }, []);

  return (
    <TableContainer bg="white" shadow="md" m={10}>
      <Table size="md">
        <Thead>
          <Tr>
            <Th>Nombre</Th>
            <Th>Cantidad de libros</Th>
            <Th textAlign="center">Opciones</Th>
          </Tr>
        </Thead>
        <Tbody>
          {publishers &&
            publishers.map((publisher: iPublisher) => (
              <Tr key={key}>
                <Td>{publisher.nombre}</Td>
                <Td>{publisher?.libros?.length}</Td>
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

export default Publisher;

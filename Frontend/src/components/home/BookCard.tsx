import React from "react";
import {
  Card,
  SimpleGrid,
  Image,
  Stack,
  CardBody,
  Heading,
  Text,
  CardFooter,
  Button,
  Box,
} from "@chakra-ui/react";

import { iBook } from "../../models/BookSchema";

type Props = {
  books: iBook | undefined;
};

function BookCard({ books }: Props) {
  return (
    books &&
    books.map((book: iBook) => (
      <Card
        direction={{ base: "column", sm: "row" }}
        overflow="hidden"
        variant="outline"
        bg="white"
        shadow="dark-sm"
      >
        <Image
          objectFit="cover"
          maxW={{ base: "100%", sm: "200px" }}
          src="https://ashmagautam.files.wordpress.com/2013/11/mcj038257400001.jpg"
          alt="Caffe Latte"
        />

        <Stack>
          <CardBody>
            <Heading size="md">{book.nombre}</Heading>

            <Text color="blue.600" fontSize="2xl" mt={2}>
              ${book.precio}
            </Text>

            <Box display="flex" alignItems="center" gap={3} mt={2}>
              <Text color="gray" fontWeight="bold">
                En Stock:{" "}
              </Text>
              <Text fontWeight="semibold">{book.stock}</Text>
            </Box>

            <Button variant="solid" colorScheme="blue" my={5}>
              Comprar
            </Button>
          </CardBody>
        </Stack>
      </Card>
    ))
  );
}

export default BookCard;

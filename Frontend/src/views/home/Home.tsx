import React from "react";

// Chakra
import { SimpleGrid, Text } from "@chakra-ui/react";

// Components
import BookCard from "./../../components/home/BookCard";
import { iBook } from "./../../models/BookSchema";

type Props = {};

function Home({}: Props) {
  const [books, setBooks] = React.useState<iBook>();
  let key: number = 0;

  React.useEffect(() => {
    fetch("https://localhost:44368/api/v1/libro/getAll")
      .then((response) => {
        if (response.ok) return response.json();
      })
      .then((data) => {
        setBooks(data);
      })
      .catch((err) => console.log(err));
  }, []);

  return (
    <SimpleGrid
      spacing={3}
      templateColumns="repeat(auto-fill, minmax(600px, 1fr))"
      m={10}
    >
      <BookCard books={books} />
    </SimpleGrid>
  );
}

export default Home;

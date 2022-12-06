import React from "react";

// React
import { NavigateFunction, useNavigate } from "react-router-dom";
import { BsFillHouseDoorFill, BsFillFileCodeFill } from "react-icons/bs";

// Chakra
import {
  Box,
  Button,
  Flex,
  Heading,
  Spacer,
  useMediaQuery,
  Image,
} from "@chakra-ui/react";

// Components
import Menu from "./Menu";

const NavBar: React.FC = (): JSX.Element => {
  const navigateTo: NavigateFunction = useNavigate();

  return (
    <Flex
      w="100%"
      py={5}
      px={10}
      align="center"
      bgColor="yellow.200"
      opacity={0.8}
    >
      <Flex justify="center" align="center" gap={5}>
        <Image src="" w="40px" data-aos="zoom-out" data-aos-duration={2000} />
        <Heading size="md" data-aos="zoom-out" data-aos-duration={2000}>
          Biblos Library
        </Heading>
      </Flex>
      <Spacer />

      <Box>
        <Button
          className="smoothjump"
          colorScheme="white"
          variant="ghost"
          leftIcon={<BsFillHouseDoorFill />}
          ml={2}
          onClick={() => navigateTo("")}
        >
          Home
        </Button>
        <Button
          className="smoothjump"
          colorScheme="white"
          variant="ghost"
          leftIcon={<BsFillFileCodeFill />}
          ml={3}
          onClick={() => navigateTo("books")}
        >
          Libros
        </Button>
      </Box>
    </Flex>
  );
};

export default NavBar;

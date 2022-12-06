import React from "react";
import { useNavigate } from "react-router-dom";

// Chakra
import { Heading, Text } from "@chakra-ui/layout";
import {
  Flex,
  Button,
  Drawer,
  DrawerBody,
  DrawerCloseButton,
  DrawerContent,
  DrawerHeader,
  DrawerOverlay,
  IconButton,
  Skeleton,
  useDisclosure,
  Image,
} from "@chakra-ui/react";

// Icons
import {
  CalendarIcon,
  CopyIcon,
  ExternalLinkIcon,
  HamburgerIcon,
  InfoIcon,
} from "@chakra-ui/icons";

const Menu: React.FC = (): JSX.Element => {
  const navigateTo = useNavigate();
  const { isOpen, onOpen, onClose } = useDisclosure();

  return (
    <>
      <IconButton
        bg="transparent"
        size="lg"
        onClick={onOpen}
        icon={<HamburgerIcon />}
        aria-label=""
      />
      <Drawer isOpen={isOpen} placement="right" onClose={onClose}>
        <DrawerOverlay />
        <DrawerContent color="white" bg="#262626">
          <DrawerCloseButton />
          <DrawerHeader>Navigation</DrawerHeader>
          <DrawerBody display="flex" flexDirection="column" alignItems="start">
            <Button
              leftIcon={<CalendarIcon />}
              colorScheme="white"
              variant="ghost"
              onClick={() => {
                navigateTo("/");
                onClose();
              }}
            >
              Home
            </Button>
            <Button
              leftIcon={<CopyIcon />}
              colorScheme="white"
              variant="ghost"
              onClick={() => {
                navigateTo("projects");
                onClose();
              }}
            >
              Projects
            </Button>
            <Button
              leftIcon={<ExternalLinkIcon />}
              colorScheme="white"
              variant="ghost"
              onClick={() => {
                navigateTo("resume");
                onClose();
              }}
            >
              Resume
            </Button>
            <Skeleton
              startColor="teal.500"
              endColor="green.500"
              w="100%"
              h="8px"
              mt={5}
            />
            <Flex
              w="100%"
              direction="column"
              justify="center"
              align="center"
              mt={20}
            >
              <Text fontWeight="semibold">I hope you're loving my work!</Text>
              <Heading
                size="2xl"
                bgGradient="linear(to-l, #00a1ab, #91C483)"
                bgClip="text"
                textTransform="uppercase"
              >
                THANK U
              </Heading>
              <Image src="" w="100px" mt={10} />
            </Flex>
          </DrawerBody>
        </DrawerContent>
      </Drawer>
    </>
  );
};

export default Menu;

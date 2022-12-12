import "../assets/css/App.css";

// Dependencies of outlet
import Router from "../routes/Routes";

// Chakra UI
import { ChakraProvider, Box } from "@chakra-ui/react";
import NavBar from "./../components/common/NavBar";

function App() {
  return (
    <ChakraProvider>
      <Box bg={"#e5e5e5"} h="100vh" maxW="100vw">
        <NavBar />
        <Router />
      </Box>
    </ChakraProvider>
  );
}

export default App;

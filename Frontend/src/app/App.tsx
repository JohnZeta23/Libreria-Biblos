import "../assets/css/App.css";

// Dependencies of outlet
import Router from "../routes/Routes";

// Chakra UI
import { ChakraProvider } from "@chakra-ui/react";
import NavBar from "./../components/common/NavBar";

function App() {
  return (
    <ChakraProvider>
      <NavBar />
      <Router />
    </ChakraProvider>
  );
}

export default App;

import { StrictMode } from "react";
import { createRoot } from "react-dom/client";
import "./styles/default.scss";
import Layout from "./Layout";

import { BrowserRouter } from "react-router-dom";
import StoreProvider from "./stores/StoreProvider";

createRoot(document.getElementById("root")!).render(
  <StrictMode>
    <BrowserRouter>
      <StoreProvider>
        <Layout />
      </StoreProvider>
    </BrowserRouter>
  </StrictMode>
);

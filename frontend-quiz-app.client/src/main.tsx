import { StrictMode } from "react";
import { createRoot } from "react-dom/client";
import "./styles/default.scss";
import Layout from "./Layout";

createRoot(document.getElementById("root")!).render(
  <StrictMode>
    <Layout />
  </StrictMode>
);

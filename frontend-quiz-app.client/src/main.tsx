import { StrictMode } from "react";
import { createRoot } from "react-dom/client";
import "./styles/default.scss";
import Layout from "./Layout";

import axios from "axios";
import { serviceOptions } from "./api";
import { BrowserRouter } from "react-router-dom";

serviceOptions.axios = axios.create({
  baseURL: import.meta.env.BASE_URL,
  headers: {
    Accept: "application/json",
    "Content-Type": "application/json",
  },
});

createRoot(document.getElementById("root")!).render(
  <StrictMode>
    <BrowserRouter>
      <Layout />
    </BrowserRouter>
  </StrictMode>
);

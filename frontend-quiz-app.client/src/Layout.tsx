import axios from "axios";
import { serviceOptions } from "./api";
import Loading from "./global-components/Loading/Loading";
import Header from "./layout/Header/Header";
import Main from "./layout/Main/Main";
import { CheckAndReturnLoadingStore } from "./utilities/storeHelper";
import { observer } from "mobx-react";

function Layout() {
  const loadingStore = CheckAndReturnLoadingStore();

  serviceOptions.axios = axios.create({
    baseURL: process.env.BASE_URL,
    headers: {
      Accept: "application/json",
      "Content-Type": "application/json",
    },
  });

  serviceOptions.axios.interceptors.request.use(
    (config) => {
      loadingStore.setIsLoading(true);
      return config;
    },
    (error) => {
      return Promise.reject(error);
    }
  );

  serviceOptions.axios.interceptors.response.use(
    (config) => {
      setTimeout(() => {
        loadingStore.setIsLoading(false);
      }, 1000);
      return config;
    },
    (error) => {
      return Promise.reject(error);
    }
  );

  return (
    <>
      <Header />
      <Main />
      <footer>Challenged by Huy Phan</footer>
      <Loading isLoading={loadingStore.isLoading} />
    </>
  );
}

const LayoutObserver = observer(Layout);

export default LayoutObserver;

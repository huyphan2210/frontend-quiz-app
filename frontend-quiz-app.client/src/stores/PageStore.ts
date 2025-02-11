import { action, makeAutoObservable, observable } from "mobx";
import { createContext } from "react";
import { Pages } from "../utilities/global-var";

export default class PageStore {
  currentPage?: Pages;

  constructor() {
    makeAutoObservable(this, {
      currentPage: observable,
      setCurrentPage: action,
    });
  }

  setCurrentPage(page?: Pages) {
    this.currentPage = page;
  }
}

export const PageStoreContext = createContext<PageStore | null>(null);

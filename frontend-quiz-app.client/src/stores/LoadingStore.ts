import { action, makeAutoObservable, observable } from "mobx";
import { createContext } from "react";

export default class LoadingStore {
  isLoading: boolean = false;

  constructor() {
    makeAutoObservable(this, {
      isLoading: observable,
      setIsLoading: action,
    });
  }

  setIsLoading(isLoading: boolean) {
    this.isLoading = isLoading;
  }
}

export const LoadingStoreContext = createContext<LoadingStore | null>(null);

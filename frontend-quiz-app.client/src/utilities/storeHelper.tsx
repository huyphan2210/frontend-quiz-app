import { useContext } from "react";
import { QuizStoreContext } from "../stores/QuizStore";
import { LoadingStoreContext } from "../stores/LoadingStore";

export const CheckAndReturnQuizStore = () => {
  const quizStore = useContext(QuizStoreContext);
  if (!quizStore) {
    throw new Error("QuizStore doesn't have a context");
  }

  return quizStore;
};

export const CheckAndReturnLoadingStore = () => {
  const loadingStore = useContext(LoadingStoreContext);
  if (!loadingStore) {
    throw new Error("LoadingStore doesn't have a context");
  }

  return loadingStore;
};

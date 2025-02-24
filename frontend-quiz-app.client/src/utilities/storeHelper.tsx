import { useContext } from "react";
import { QuizStoreContext } from "../stores/QuizStore";

export const CheckAndReturnQuizStore = () => {
  const quizStore = useContext(QuizStoreContext);
  if (!quizStore) {
    throw new Error("QuizStore doesn't have a context");
  }

  return quizStore;
};

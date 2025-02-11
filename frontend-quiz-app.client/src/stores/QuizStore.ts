import { action, makeAutoObservable, observable } from "mobx";
import { createContext } from "react";
import { QuizCategoryResponse } from "../api";

export default class QuizStore {
  currentQuizCategory?: QuizCategoryResponse;

  constructor() {
    makeAutoObservable(this, {
      currentQuizCategory: observable,
      setQuizCategory: action,
    });
  }

  setQuizCategory(quizCategory?: QuizCategoryResponse) {
    this.currentQuizCategory = quizCategory;
  }
}

export const QuizStoreContext = createContext<QuizStore | null>(null);

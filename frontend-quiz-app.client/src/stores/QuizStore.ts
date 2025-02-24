import { action, makeAutoObservable, observable } from "mobx";
import { createContext } from "react";
import { EQuizCategory, QuizCategoryResponse, QuizResponse } from "../api";
import {
  getQuizzesByCategory,
  getQuizCategories as apiGetQuizCategories,
} from "../services/Quiz.service";

export default class QuizStore {
  currentQuizCategory?: QuizCategoryResponse;
  currentQuizzes?: QuizResponse[];
  quizCategories?: QuizCategoryResponse[];

  constructor() {
    makeAutoObservable(this, {
      currentQuizCategory: observable,
      getQuizCategories: action,
      setCurrentQuizCategory: action,
    });
  }

  getQuizCategories() {
    return apiGetQuizCategories().then((categories) => {
      this.quizCategories = categories;
    });
  }

  setCurrentQuizCategory(quizCategory?: QuizCategoryResponse) {
    this.currentQuizCategory = quizCategory;
    if (this.currentQuizCategory?.type)
      return this.getQuizzesByCategory(this.currentQuizCategory?.type);
  }

  getQuizzesByCategory(categoryType: EQuizCategory) {
    return getQuizzesByCategory(categoryType).then(
      (quizzes) => (this.currentQuizzes = quizzes)
    );
  }
}

export const QuizStoreContext = createContext<QuizStore | null>(null);

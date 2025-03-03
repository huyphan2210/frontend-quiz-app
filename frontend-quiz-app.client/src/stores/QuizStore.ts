import { action, makeAutoObservable, observable } from "mobx";
import { createContext } from "react";
import { EQuizCategory, QuizCategoryResponse, QuizResponse } from "../api";
import {
  getQuizzesByCategory,
  getQuizCategories as apiGetQuizCategories,
} from "../services/Quiz.service";
import { exportKeyBase64, generateKey } from "../utilities/quizUtilities";

const categoryBackgroundColorRecords: Record<number, string> = {
  [0]: "#fff1e9",
  [1]: "#e0fdef",
  [2]: "#ebf0ff",
  [3]: "#f6e7ff",
};

export default class QuizStore {
  currentEncryptKey?: CryptoKey;
  currentQuizCategory?: QuizCategoryResponse;
  currentQuizzes?: QuizResponse[];
  quizCategories?: QuizCategoryResponse[];

  constructor() {
    makeAutoObservable(this, {
      currentQuizCategory: observable,
      currentEncryptKey: observable,
      getQuizCategories: action,
      setCurrentQuizCategory: action,
    });
  }

  getQuizCategories() {
    return apiGetQuizCategories().then((categories) => {
      this.quizCategories = categories;
      this.enrichQuizCategories();
    });
  }

  setCurrentQuizCategory(quizCategory?: QuizCategoryResponse) {
    this.currentQuizCategory = quizCategory;
    if (this.currentQuizCategory?.type)
      return this.getQuizzesByCategory(this.currentQuizCategory?.type);
  }

  async getQuizzesByCategory(categoryType: EQuizCategory) {
    if (!this.currentEncryptKey) {
      this.currentEncryptKey = await generateKey();
    }
    const keyBase64 = await exportKeyBase64(this.currentEncryptKey);
    return getQuizzesByCategory(categoryType, keyBase64).then(
      (quizzes) => (this.currentQuizzes = quizzes)
    );
  }

  private enrichQuizCategories() {
    this.quizCategories?.forEach((category, i) => {
      if (category.imgBackgroundColor) return;
      category.imgBackgroundColor = categoryBackgroundColorRecords[i % 4];
    });
  }
}

export const QuizStoreContext = createContext<QuizStore | null>(null);

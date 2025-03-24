import { action, makeAutoObservable, observable } from "mobx";
import { createContext } from "react";
import { EQuizCategory, QuizCategoryResponse, QuizResponse } from "../api";
import {
  getQuizzesByCategory,
  getQuizCategories as apiGetQuizCategories,
} from "../services/Quiz.service";
import { exportKeyBase64, generateKey } from "../utilities/quizUtilities";

export default class QuizStore {
  currentEncryptKey?: CryptoKey;
  currentQuizCategory?: QuizCategoryResponse;
  currentQuizzes?: QuizResponse[];
  currentScore = 0;
  isQuizFinished = false;
  quizCategories?: QuizCategoryResponse[];

  constructor() {
    makeAutoObservable(this, {
      currentQuizzes: observable,
      currentQuizCategory: observable,
      currentEncryptKey: observable,
      currentScore: observable,
      isQuizFinished: observable,
      quizCategories: observable,
      getQuizCategories: action,
      setCurrentQuizCategory: action,
      setCurrentQuizzes: action,
      setCurrentScore: action,
      setIsQuizFinished: action,
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

  setCurrentScore(score: number) {
    this.currentScore = score;
  }

  setIsQuizFinished(isFinished: boolean) {
    this.isQuizFinished = isFinished;
  }

  setCurrentQuizzes(quizzes?: QuizResponse[]) {
    this.currentQuizzes = quizzes;
  }

  reset() {
    this.setIsQuizFinished(false);
    this.setCurrentQuizCategory();
    this.setCurrentQuizzes();
    this.setCurrentScore(0);
  }

  private async getQuizzesByCategory(categoryType: EQuizCategory) {
    if (!this.currentEncryptKey) {
      this.currentEncryptKey = await generateKey();
    }
    const keyBase64 = await exportKeyBase64(this.currentEncryptKey);
    return getQuizzesByCategory(categoryType, keyBase64).then((quizzes) => {
      this.setCurrentQuizzes(quizzes);
      return this.currentQuizzes;
    });
  }
}

export const QuizStoreContext = createContext<QuizStore | null>(null);

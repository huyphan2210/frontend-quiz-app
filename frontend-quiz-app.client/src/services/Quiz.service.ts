import { EQuizCategory, QuizService } from "../api";

const getQuizCategories = () => {
  return QuizService.getQuizCategories();
};

const getQuizzesByCategory = (categoryType: EQuizCategory) => {
  return QuizService.getQuizzesByCategory({ category: categoryType });
};

export { getQuizCategories, getQuizzesByCategory };

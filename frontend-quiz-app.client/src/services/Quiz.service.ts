import { EQuizCategory, QuizService } from "../api";

const getQuizCategories = () => {
  return QuizService.getQuizCategories();
};

const getQuizzesByCategory = (
  categoryType: EQuizCategory,
  encryptKeyBase64: string
) => {
  return QuizService.getQuizzesByCategory({
    category: categoryType,
    body: {
      encryptKeyBase64,
    },
  });
};

export { getQuizCategories, getQuizzesByCategory };

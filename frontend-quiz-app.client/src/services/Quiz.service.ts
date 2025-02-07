import { QuizService } from "../api";

export const getQuizCategories = async () => {
  return await QuizService.getQuizCategories();
};

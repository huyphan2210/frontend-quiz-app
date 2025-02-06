const quizRoute = "api/quiz";

export const getQuizCategories = async () => {
  const quizCategoriesResponse = await fetch(quizRoute + "/categories");
  const data = await quizCategoriesResponse.json();
  console.log(data);
};

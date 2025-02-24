import { FC, useLayoutEffect, useState } from "react";
import { useSearchParams } from "react-router-dom";
import "./QuizPage.scss";
import { EQuizCategory, QuizResponse } from "../../api";
import { CheckAndReturnQuizStore } from "../../utilities/storeHelper";

const categoryRecords: Record<string, EQuizCategory> = {
  [EQuizCategory.Html.toLowerCase()]: EQuizCategory.Html,
  [EQuizCategory.Css.toLowerCase()]: EQuizCategory.Css,
  [EQuizCategory.JavaScript.toLowerCase()]: EQuizCategory.JavaScript,
  [EQuizCategory.Accessibility.toLowerCase()]: EQuizCategory.Accessibility,
};

const QuizPage: FC = () => {
  const [searchParams] = useSearchParams();
  const categoryName = searchParams.get("category") || "";
  const quizStore = CheckAndReturnQuizStore();

  const [currentQuiz, setCurrentQuiz] = useState<QuizResponse>();

  const setCurrentQuizCategory = () => {
    quizStore
      .setCurrentQuizCategory(
        quizStore.quizCategories?.find(
          (category) => category.type == categoryRecords[categoryName]
        )
      )
      ?.then((quizzes) => setCurrentQuiz(quizzes[0]));
  };

  useLayoutEffect(() => {
    if (!quizStore.quizCategories || quizStore.quizCategories.length == 0) {
      quizStore.getQuizCategories().then(() => setCurrentQuizCategory());
      return;
    }

    setCurrentQuizCategory();
  }, []);

  return <></>;
};

const QuizPageObserver = QuizPage;

export default QuizPageObserver;

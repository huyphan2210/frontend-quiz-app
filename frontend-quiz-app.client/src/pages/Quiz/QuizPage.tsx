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

  return (
    <>
      <small className="quiz_small-text">
        <i>
          Question {currentQuiz?.order} of{" "}
          {quizStore.currentQuizzes?.length || 0}
        </i>
      </small>
      <h1 className="quiz_question">{currentQuiz?.question}</h1>
      <form className="quiz_form">
        <ul className="quiz_form_option-list">
          {currentQuiz?.options?.map((option, index) => (
            <li className="quiz_form_option-list_choice" key={index}>
              <input id={`option-${index}`} type="checkbox"></input>
              <label htmlFor={`option-${index}`}>{option}</label>
            </li>
          ))}
        </ul>
      </form>
    </>
  );
};

const QuizPageObserver = QuizPage;

export default QuizPageObserver;

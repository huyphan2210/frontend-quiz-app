import {
  FC,
  FormEventHandler,
  MouseEventHandler,
  useEffect,
  useLayoutEffect,
  useState,
} from "react";
import { useSearchParams } from "react-router-dom";
import "./QuizPage.scss";
import { EQuizCategory, QuizResponse } from "../../api";
import { CheckAndReturnQuizStore } from "../../utilities/storeHelper";
import { decryptData } from "../../utilities/quizUtilities";

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
  const [choice, setChoice] = useState<string>("");

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

  const resetStyle = () => {
    const options = document.querySelectorAll(
      ".quiz_form_option-list_item_choice"
    ) as NodeListOf<HTMLButtonElement>;
    options.forEach((option) => {
      option.disabled = false;
      option.classList.remove("right-answer");
      option.classList.remove("wrong-answer");
      option.classList.remove("active");
    });

    const submitButton = document.querySelector(
      ".quiz_form_submit-button"
    ) as HTMLButtonElement;
    const nextButton = document.querySelector(
      ".quiz_form_next-button"
    ) as HTMLButtonElement;
    submitButton.style.display = "unset";
    nextButton.style.display = "";
  };

  useEffect(resetStyle, [currentQuiz]);

  const clickOptionHandler = (
    e: React.MouseEvent<HTMLButtonElement, MouseEvent>,
    choice: string
  ) => {
    const options = document.querySelectorAll(
      ".quiz_form_option-list_item_choice"
    ) as NodeListOf<HTMLButtonElement>;
    options.forEach((option) => option.classList.remove("active"));

    const clickedOption = e.currentTarget as HTMLButtonElement;
    clickedOption.classList.add("active");
    setChoice(choice);

    const submitButton = document.querySelector(
      ".quiz_form_submit-button"
    ) as HTMLButtonElement;
    submitButton.disabled = false;
  };

  const formSubmitHandler: FormEventHandler<HTMLFormElement> = async (e) => {
    e.preventDefault();
    const options = document.querySelectorAll(
      ".quiz_form_option-list_item_choice"
    ) as NodeListOf<HTMLButtonElement>;
    options.forEach((option) => (option.disabled = true));

    const candidateChosenButton = document.querySelector(
      ".quiz_form_option-list_item_choice.active"
    ) as HTMLButtonElement;

    if (currentQuiz?.encodedAnswer && quizStore.currentEncryptKey) {
      decryptData(currentQuiz.encodedAnswer, quizStore.currentEncryptKey).then(
        (answer) => {
          if (answer === choice) {
            candidateChosenButton.classList.add("right-answer");
          } else {
            candidateChosenButton.classList.add("wrong-answer");
          }
        }
      );
    }
    const submitButton = document.querySelector(
      ".quiz_form_submit-button"
    ) as HTMLButtonElement;
    const nextButton = document.querySelector(
      ".quiz_form_next-button"
    ) as HTMLButtonElement;
    submitButton.style.display = "none";
    nextButton.style.display = "unset";
  };

  const nextQuestionHandler = () => {
    const nextQuizOrder = currentQuiz?.order || 1;
    if (quizStore.currentQuizzes && quizStore.currentQuizzes[nextQuizOrder]) {
      setCurrentQuiz(quizStore.currentQuizzes[nextQuizOrder]);
    }
  };

  return (
    <>
      <hgroup className="quiz_text">
        <small className="quiz_text_small-text">
          <i>
            Question {currentQuiz?.order} of{" "}
            {quizStore.currentQuizzes?.length || 0}
          </i>
        </small>
        <h1 className="quiz_text_question">{currentQuiz?.question}</h1>
        <span className="quiz_text_time"></span>
      </hgroup>
      <form className="quiz_form" onSubmit={formSubmitHandler}>
        <ul className="quiz_form_option-list">
          {currentQuiz?.options?.map((option, index) => (
            <li className="quiz_form_option-list_item" key={index}>
              <button
                type="button"
                className="quiz_form_option-list_item_choice"
                onClick={(e) => clickOptionHandler(e, option)}
              >
                <span>{String.fromCharCode(index + 65)}</span>
                <span>{option}</span>
              </button>
            </li>
          ))}
        </ul>
        <button disabled className="quiz_form_submit-button" type="submit">
          Submit Answer
        </button>
        <button
          onClick={() => nextQuestionHandler()}
          className="quiz_form_next-button"
          type="button"
        >
          Next Question
        </button>
      </form>
    </>
  );
};

const QuizPageObserver = QuizPage;

export default QuizPageObserver;

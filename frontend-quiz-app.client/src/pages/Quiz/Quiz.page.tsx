import {
  FC,
  FormEventHandler,
  useEffect,
  useLayoutEffect,
  useState,
} from "react";
import { useNavigate, useSearchParams } from "react-router-dom";
import "./Quiz.page.scss";
import { EQuizCategory, QuizResponse } from "../../api";
import { CheckAndReturnQuizStore } from "../../utilities/storeHelper";
import { decryptData } from "../../utilities/quizUtilities";

import iconCorrect from "../../assets/svgs/Main/icon-correct.svg";
import iconIncorrect from "../../assets/svgs/Main/icon-incorrect.svg";
import { Pages } from "../../utilities/global-var";
import { observer } from "mobx-react";

const categoryRecords: Record<string, EQuizCategory> = {
  [EQuizCategory.Html.toLowerCase()]: EQuizCategory.Html,
  [EQuizCategory.Css.toLowerCase()]: EQuizCategory.Css,
  [EQuizCategory.JavaScript.toLowerCase()]: EQuizCategory.JavaScript,
  [EQuizCategory.Accessibility.toLowerCase()]: EQuizCategory.Accessibility,
};

const QuizPage: FC = () => {
  const [searchParams] = useSearchParams();
  const navigate = useNavigate();
  const categoryName = searchParams.get("category") || "";

  const quizStore = CheckAndReturnQuizStore();

  const SECONDS_LIMIT = 30;

  const [secondsPassed, setSecondPassed] = useState(0);
  const [currentQuiz, setCurrentQuiz] = useState<QuizResponse>();
  const [choice, setChoice] = useState<string>("");

  const setCurrentQuizCategory = () => {
    quizStore
      .setCurrentQuizCategory(
        quizStore.quizCategories?.find(
          (category) => category.type == categoryRecords[categoryName]
        )
      )
      ?.then((quizzes) => setCurrentQuiz(quizzes![0]));
  };

  useLayoutEffect(() => {
    if (!categoryName) {
      navigate(Pages.Welcome);
      return;
    }

    if (!quizStore.quizCategories || quizStore.quizCategories.length == 0) {
      quizStore.getQuizCategories().then(() => {
        setCurrentQuizCategory();
      });
      return;
    }

    setCurrentQuizCategory();
  }, []);

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
    if (secondsPassed < SECONDS_LIMIT) {
      setSecondPassed(SECONDS_LIMIT);
      return;
    }
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
          options.forEach((option) => {
            const optionText = (
              option.querySelector("span:nth-child(2)") as HTMLSpanElement
            ).innerText;
            if (optionText === answer) {
              option.classList.add("right-answer");
            }
          });

          if (answer === choice) {
            candidateChosenButton?.classList.add("right-option");
            quizStore.setCurrentScore(quizStore.currentScore + 1);
          } else {
            candidateChosenButton?.classList.add("wrong-option");
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
    const seeResultButton = document.querySelector(
      ".quiz_form_see-result"
    ) as HTMLAnchorElement;
    submitButton.style.display = "none";
    if (currentQuiz?.order === quizStore.currentQuizzes?.length) {
      seeResultButton.style.display = "block";
    } else {
      nextButton.style.display = "unset";
    }
  };

  const nextQuestionHandler = () => {
    const nextQuizOrder = currentQuiz?.order || 1;
    if (quizStore.currentQuizzes && quizStore.currentQuizzes[nextQuizOrder]) {
      setCurrentQuiz(quizStore.currentQuizzes[nextQuizOrder]);
    }
  };

  const resetStates = () => {
    const options = document.querySelectorAll(
      ".quiz_form_option-list_item_choice"
    ) as NodeListOf<HTMLButtonElement>;
    options.forEach((option) => {
      option.disabled = false;
      option.classList.remove("right-answer");
      option.classList.remove("right-option");
      option.classList.remove("wrong-option");
      option.classList.remove("active");
    });

    const submitButton = document.querySelector(
      ".quiz_form_submit-button"
    ) as HTMLButtonElement;
    const nextButton = document.querySelector(
      ".quiz_form_next-button"
    ) as HTMLButtonElement;
    const seeResultButton = document.querySelector(
      ".quiz_form_see-result"
    ) as HTMLAnchorElement;
    submitButton.style.display = "";
    nextButton.style.display = "";
    seeResultButton.style.display = "";
    setSecondPassed(0);
  };

  useEffect(resetStates, [currentQuiz]);

  useEffect(() => {
    const index = setTimeout(() => {
      setSecondPassed((prev) => prev + 1);
    }, 1000);

    if (secondsPassed >= SECONDS_LIMIT) {
      clearTimeout(index);
      const form = document.querySelector(".quiz_form") as HTMLFormElement;
      form.requestSubmit();
    }
  }, [secondsPassed]);

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
        <progress
          className="quiz_text_time-bar"
          value={secondsPassed}
          max={SECONDS_LIMIT}
        ></progress>
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
                <img
                  className="quiz_form_option-list_item_choice_icon--correct"
                  src={iconCorrect}
                  loading="lazy"
                  alt="Correct Icon"
                />
                <img
                  className="quiz_form_option-list_item_choice_icon--incorrect"
                  src={iconIncorrect}
                  loading="lazy"
                  alt="Incorrect Icon"
                />
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
        <a
          onClick={(e) => {
            e.preventDefault();
            quizStore.setIsQuizFinished(true);
            navigate(Pages.Result);
          }}
          href={Pages.Result}
          className="quiz_form_see-result"
        >
          See Result
        </a>
      </form>
    </>
  );
};

const QuizPageObserver = observer(QuizPage);

export default QuizPageObserver;

import { FC, MouseEvent, useEffect } from "react";
import { CheckAndReturnQuizStore } from "../../utilities/storeHelper";
import "./Result.page.scss";
import { observer } from "mobx-react";
import { Pages } from "../../utilities/global-var";
import { useNavigate } from "react-router-dom";

const ResultPage: FC = () => {
  const navigate = useNavigate();
  const quizStore = CheckAndReturnQuizStore();
  const playAgainHandler = (e: MouseEvent<HTMLAnchorElement>) => {
    e.preventDefault();
    quizStore.reset();
    navigate(Pages.Welcome);
  };

  useEffect(() => {
    if (!quizStore.isQuizFinished) {
      navigate(Pages.Welcome);
    }
  }, []);
  return (
    quizStore.isQuizFinished && (
      <>
        <h1 className="result_heading">
          Quiz completed <span>You scored...</span>
        </h1>
        {quizStore.currentQuizCategory && (
          <div className="result_container">
            <article className="result_container_details">
              <figure className="result_container_details_quiz-category">
                <img
                  style={{
                    backgroundColor:
                      quizStore.currentQuizCategory.imgBackgroundColor,
                  }}
                  src={quizStore.currentQuizCategory.imgUrl}
                  loading="lazy"
                  alt={quizStore.currentQuizCategory.name}
                ></img>
                <figcaption>{quizStore.currentQuizCategory.name}</figcaption>
              </figure>
              <p className="result_container_details_score">
                <span>{quizStore.currentScore}</span>
                out of {quizStore.currentQuizzes?.length}
              </p>
            </article>
            <a
              className="result_container_welcome-navigator"
              href={Pages.Welcome}
              onClick={playAgainHandler}
            >
              Play Again
            </a>
          </div>
        )}
      </>
    )
  );
};

const ResultPageObserver = observer(ResultPage);

export default ResultPageObserver;

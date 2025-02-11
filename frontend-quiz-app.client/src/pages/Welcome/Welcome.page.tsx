import { FC, useLayoutEffect, useState } from "react";
import "./Welcome.page.scss";
import { getQuizCategories } from "../../services/Quiz.service";
import { QuizCategoryResponse } from "../../api";

const WelcomePage: FC = () => {
  const [quizCategories, setQuizCategories] = useState<QuizCategoryResponse[]>(
    []
  );

  useLayoutEffect(() => {
    getQuizCategories().then((quizCategories) =>
      setQuizCategories(quizCategories)
    );
  }, []);
  return (
    <>
      <h1>
        Welcome to the <span>Frontend Quiz!</span>
      </h1>
      <small>
        <i>Pick a subject to get started</i>
      </small>
      <ul>
        {quizCategories.map((category, i) => (
          <li key={i}>
            <button type="button" className={`category_${i}`}>
              <img src={category.imgUrl} loading="lazy" alt={category.name} />
            </button>
          </li>
        ))}
      </ul>
    </>
  );
};

export default WelcomePage;

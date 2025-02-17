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
      <hgroup className="welcome">
        <h1 className="welcome_heading">
          Welcome to the <span>Frontend Quiz!</span>
        </h1>
        <small className="welcome_description">
          <i>Pick a subject to get started</i>
        </small>
      </hgroup>
      <ul className="category_list">
        {quizCategories.map((category, i) => (
          <li key={i}>
            <button type="button" className='category'>
              <img src={category.imgUrl} loading="lazy" alt={category.name} />
              <span>{category.name}</span>
            </button>
          </li>
        ))}
      </ul>
    </>
  );
};

export default WelcomePage;

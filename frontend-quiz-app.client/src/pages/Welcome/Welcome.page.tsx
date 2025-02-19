import { FC, MouseEventHandler, useLayoutEffect, useState } from "react";
import "./Welcome.page.scss";
import { getQuizCategories } from "../../services/Quiz.service";
import { QuizCategoryResponse } from "../../api";
import { useNavigate } from "react-router-dom";
import { Pages } from "../../utilities/global-var";

const WelcomePage: FC = () => {
  const navigation = useNavigate();
  const [quizCategories, setQuizCategories] = useState<QuizCategoryResponse[]>(
    []
  );

  const handleNavigation: MouseEventHandler<HTMLAnchorElement> = (e) => {
    e.preventDefault();
    navigation(e.currentTarget.pathname + e.currentTarget.search);
  };

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
            <a
              onClick={handleNavigation}
              href={`${Pages.Quiz}?category=${category.name?.toLowerCase()}`}
              className="category"
            >
              <img src={category.imgUrl} loading="lazy" alt={category.name} />
              <span>{category.name}</span>
            </a>
          </li>
        ))}
      </ul>
    </>
  );
};

export default WelcomePage;

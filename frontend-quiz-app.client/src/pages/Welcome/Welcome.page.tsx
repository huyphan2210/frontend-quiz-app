import { FC, MouseEvent, useLayoutEffect } from "react";
import "./Welcome.page.scss";
import { useNavigate } from "react-router-dom";
import { Pages } from "../../utilities/global-var";
import { observer } from "mobx-react";
import { CheckAndReturnQuizStore } from "../../utilities/storeHelper";
import { QuizCategoryResponse } from "../../api";

const WelcomePage: FC = () => {
  const quizStore = CheckAndReturnQuizStore();
  const navigation = useNavigate();

  const handleNavigation = (
    e: MouseEvent<HTMLAnchorElement>,
    category: QuizCategoryResponse
  ) => {
    e.preventDefault();
    quizStore.setCurrentQuizCategory(category);
    navigation(e.currentTarget.pathname + e.currentTarget.search);
  };

  useLayoutEffect(() => {
    quizStore.setCurrentQuizCategory();
    quizStore.getQuizCategories();
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
        {quizStore.quizCategories &&
          quizStore.quizCategories.map((category, i) => (
            <li key={i}>
              <a
                onClick={(e) => handleNavigation(e, category)}
                href={`${Pages.Quiz}?category=${category.name?.toLowerCase()}`}
                className="category"
              >
                <img
                  style={{ backgroundColor: category.imgBackgroundColor }}
                  src={category.imgUrl}
                  loading="lazy"
                  alt={category.name}
                />
                <span>{category.name}</span>
              </a>
            </li>
          ))}
      </ul>
    </>
  );
};

const WelcomePageObserver = observer(WelcomePage);

export default WelcomePageObserver;

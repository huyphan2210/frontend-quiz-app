import { FC, MouseEventHandler, useLayoutEffect } from "react";
import "./Welcome.page.scss";
import { useNavigate } from "react-router-dom";
import { Pages } from "../../utilities/global-var";
import { observer } from "mobx-react";
import { CheckAndReturnQuizStore } from "../../utilities/storeHelper";

const WelcomePage: FC = () => {
  const quizStore = CheckAndReturnQuizStore();
  const navigation = useNavigate();

  const handleNavigation: MouseEventHandler<HTMLAnchorElement> = (e) => {
    e.preventDefault();
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
                onClick={handleNavigation}
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

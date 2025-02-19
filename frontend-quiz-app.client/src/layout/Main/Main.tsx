import { FC } from "react";
import "./Main.scss";
import { Route, Routes } from "react-router-dom";
import WelcomePage from "../../pages/Welcome/Welcome.page";
import { Pages } from "../../utilities/global-var";
import QuizPage from "../../pages/Quiz/QuizPage";

const Main: FC = () => {
  return (
    <main>
      <Routes>
        <Route path={Pages.Welcome} element={<WelcomePage />} />
        <Route path={Pages.Quiz} element={<QuizPage />} />
      </Routes>
    </main>
  );
};

export default Main;

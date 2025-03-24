import { FC } from "react";
import "./Main.scss";
import { Route, Routes } from "react-router-dom";
import { Pages } from "../../utilities/global-var";

import WelcomePage from "../../pages/Welcome/Welcome.page";
import QuizPage from "../../pages/Quiz/Quiz.page";
import ResultPage from "../../pages/Result/Result.page";

const Main: FC = () => {
  return (
    <main>
      <Routes>
        <Route path={Pages.Welcome} element={<WelcomePage />} />
        <Route path={Pages.Quiz} element={<QuizPage />} />
        <Route path={Pages.Result} element={<ResultPage />} />
      </Routes>
    </main>
  );
};

export default Main;

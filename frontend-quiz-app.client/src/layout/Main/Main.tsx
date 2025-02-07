import { FC } from "react";
import "./Main.scss";
import { Route, Routes } from "react-router-dom";
import WelcomePage from "../../pages/Welcome/Welcome.page";
import { Pages } from "../../utilities/global-var";

const Main: FC = () => {
  return (
    <main>
      <Routes>
        <Route path={Pages.Welcome} element={<WelcomePage />} />
      </Routes>
    </main>
  );
};

export default Main;

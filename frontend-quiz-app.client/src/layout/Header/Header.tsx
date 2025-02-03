import { FC, useState } from "react";
import "./Header.scss";

import sunLight from "../../assets/svgs/Header/icon-sun-light.svg";
import sunDark from "../../assets/svgs/Header/icon-sun-dark.svg";
import moonLight from "../../assets/svgs/Header/icon-moon-light.svg";
import moonDark from "../../assets/svgs/Header/icon-moon-dark.svg";

const Header: FC = () => {
  enum Mode {
    Light = "light",
    Dark = "dark",
  }
  const ModeSettings: Record<Mode, () => void> = {
    [Mode.Light]: () => {
      document.documentElement.style.setProperty(
        "--body-bg-color",
        "var(--light-grey)"
      );
      document.documentElement.style.setProperty(
        "--text-color",
        "var(--dark-navy)"
      );
      document.documentElement.style.setProperty(
        "--heading-lable-color",
        "var(--grey-navy)"
      );
    },
    [Mode.Dark]: () => {
      document.documentElement.style.setProperty(
        "--body-bg-color",
        "var(--dark-navy)"
      );
      document.documentElement.style.setProperty(
        "--text-color",
        "var(--pure-white)"
      );
      document.documentElement.style.setProperty(
        "--heading-lable-color",
        "var(--light-bluish)"
      );
    },
  };

  const [mode, setMode] = useState(
    (localStorage.getItem("mode") || Mode.Light) as Mode
  );

  return (
    <header className="header">
      <div className="header_mode-toggle"></div>
    </header>
  );
};

export default Header;

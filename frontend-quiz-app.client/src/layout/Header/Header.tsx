import { FC, MouseEventHandler, useEffect, useRef, useState } from "react";
import "./Header.scss";

import sunLight from "../../assets/svgs/Header/icon-sun-light.svg";
import sunDark from "../../assets/svgs/Header/icon-sun-dark.svg";
import moonLight from "../../assets/svgs/Header/icon-moon-light.svg";
import moonDark from "../../assets/svgs/Header/icon-moon-dark.svg";
import { getQuizCategories } from "../../services/Quiz.service";
import { observer } from "mobx-react";
import { CheckAndReturnQuizStore } from "../../utilities/storeHelper";

const modeString = "mode";
enum Mode {
  Light = "light",
  Dark = "dark",
}
const ModeSettings: Record<Mode, () => void> = {
  [Mode.Light]: () => {
    document.documentElement.classList.remove("dark-mode");
  },
  [Mode.Dark]: () => {
    document.documentElement.classList.add("dark-mode");
  },
};

const Header: FC = () => {
  const quizStore = CheckAndReturnQuizStore();
  const currentMode = (localStorage.getItem(modeString) || Mode.Light) as Mode;
  ModeSettings[currentMode]();

  const toggleRef = useRef<HTMLInputElement | null>(null);
  const toggleLabelRef = useRef<HTMLLabelElement | null>(null);
  const [toggleSrcImg, setToggleSrcImg] = useState(
    currentMode === Mode.Light
      ? {
          sun: sunDark,
          moon: moonDark,
        }
      : {
          sun: sunLight,
          moon: moonLight,
        }
  );

  const handleCurrentMode = () => {
    if (currentMode === Mode.Dark && toggleRef.current) {
      toggleRef.current.checked = true;
      toggleLabelRef.current?.classList.add("dark");
    }
  };

  const handleToggle: MouseEventHandler<HTMLInputElement> = (e) => {
    const toggle = e.currentTarget;
    toggleLabelRef.current?.classList.toggle("dark");
    if (toggle.checked) {
      localStorage.setItem(modeString, Mode.Dark);
      ModeSettings[Mode.Dark]();
      setToggleSrcImg({
        sun: sunLight,
        moon: moonLight,
      });
    } else {
      localStorage.setItem(modeString, Mode.Light);
      ModeSettings[Mode.Light]();
      setToggleSrcImg({
        sun: sunDark,
        moon: moonDark,
      });
    }
  };

  useEffect(() => {
    handleCurrentMode();
    getQuizCategories();
  }, []);

  return (
    <header className="header">
      {quizStore.currentQuizCategory && (
        <figure className="header_quiz-category">
          <img
            src={quizStore.currentQuizCategory.imgUrl}
            loading="lazy"
            alt={quizStore.currentQuizCategory.name}
          ></img>
          <figcaption>{quizStore.currentQuizCategory.name}</figcaption>
        </figure>
      )}
      <div className="header_mode-toggle">
        <img src={toggleSrcImg.sun} alt="Sun Icon" loading="lazy" />
        <input
          id="mode-toggle"
          placeholder="Checkbox for Mode"
          ref={toggleRef}
          onClick={handleToggle}
          className="header_mode-toggle_input"
          type="checkbox"
        />
        <label
          ref={toggleLabelRef}
          className="header_mode-toggle_label"
          htmlFor="mode-toggle"
        />
        <img src={toggleSrcImg.moon} alt="Moon Icon" loading="lazy" />
      </div>
    </header>
  );
};

const HeaderObserver = observer(Header);

export default HeaderObserver;

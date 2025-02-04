import { FC, MouseEventHandler, useEffect, useRef, useState } from "react";
import "./Header.scss";

import sunLight from "../../assets/svgs/Header/icon-sun-light.svg";
import sunDark from "../../assets/svgs/Header/icon-sun-dark.svg";
import moonLight from "../../assets/svgs/Header/icon-moon-light.svg";
import moonDark from "../../assets/svgs/Header/icon-moon-dark.svg";

const modeString = "mode";
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

const Header: FC = () => {
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

  useEffect(handleCurrentMode, []);

  return (
    <header className="header">
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

export default Header;

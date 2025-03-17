import { FC, useEffect, useRef, useState } from "react";
import "./Loading.scss";

interface ILoading {
  isLoading?: boolean;
}

const Loading: FC<ILoading> = ({ isLoading }) => {
  const SECONDS_LIMIT = 30;
  const [secondsPassed, setSecondPassed] = useState(0);
  const modal = useRef<HTMLDialogElement>(null);

  useEffect(() => {
    if (!isLoading) {
      setSecondPassed(SECONDS_LIMIT);
      modal.current?.classList.add("close");
      setTimeout(() => {
        modal.current?.close();
        setSecondPassed(0);
        modal.current?.classList.remove("close");
      }, 1500);
      return;
    }
    modal.current?.showModal();
    const intervalIndex = setInterval(() => {
      setSecondPassed((prev) => prev + 1);
    }, 1000);

    let secondIntervalIndex = 0;

    setTimeout(() => {
      clearInterval(intervalIndex);
      secondIntervalIndex = setInterval(() => {
        setSecondPassed((prev) => prev + 0.1);
      }, 1000);
      setTimeout(() => {
        clearInterval(secondIntervalIndex);
      }, 40000);
    }, 25000);

    return () => {
      clearInterval(intervalIndex);
      clearInterval(secondIntervalIndex);
    };
  }, [isLoading]);

  return (
    <dialog ref={modal} className="loading">
      <progress
        className="loading_time-bar"
        value={secondsPassed}
        max={SECONDS_LIMIT}
      ></progress>
    </dialog>
  );
};

export default Loading;

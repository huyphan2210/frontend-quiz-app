import { FC } from "react";
import { useSearchParams } from "react-router-dom";
import "./QuizPage.scss";

const QuizPage: FC = () => {
  const [searchParams] = useSearchParams();
  const categoryName = searchParams.get("category")
  return <>{categoryName}</>;
};

export default QuizPage;

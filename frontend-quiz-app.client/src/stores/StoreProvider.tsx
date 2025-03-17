import { FC, ReactNode } from "react";
import QuizStore, { QuizStoreContext } from "./QuizStore";
import LoadingStore, { LoadingStoreContext } from "./LoadingStore";

interface StoreProviderProps {
  children: ReactNode;
}

const StoreProvider: FC<StoreProviderProps> = ({ children }) => {
  const loadingInstance = new LoadingStore();
  const quizStoreInstance = new QuizStore();
  return (
    <LoadingStoreContext.Provider value={loadingInstance}>
      <QuizStoreContext.Provider value={quizStoreInstance}>
        {children}
      </QuizStoreContext.Provider>
    </LoadingStoreContext.Provider>
  );
};

export default StoreProvider;

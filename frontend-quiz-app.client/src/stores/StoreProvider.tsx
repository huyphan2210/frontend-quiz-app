import { FC, ReactNode } from "react";
import QuizStore, { QuizStoreContext } from "./QuizStore";
import PageStore, { PageStoreContext } from "./PageStore";

interface StoreProviderProps {
  children: ReactNode;
}

const StoreProvider: FC<StoreProviderProps> = ({ children }) => {
  const pageInstance = new PageStore();
  const quizStoreInstance = new QuizStore();
  return (
    <PageStoreContext.Provider value={pageInstance}>
      <QuizStoreContext.Provider value={quizStoreInstance}>
        {children}
      </QuizStoreContext.Provider>
    </PageStoreContext.Provider>
  );
};

export default StoreProvider;

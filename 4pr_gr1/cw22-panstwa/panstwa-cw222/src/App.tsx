import { useEffect } from "react";
import Countries from "./data/Countries.json";

import "./App.css";
import MyList from "./components/MyList";

function App() {

  return (
    <div className="container">
      <h1>Przegląd państw</h1>
      <MyList countries={Countries} />
    </div>
  );
}

export default App;

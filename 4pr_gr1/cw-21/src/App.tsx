import "./App.css";
import LeftComp from "./components/LeftComp";
import Nav from "./components/Nav";
import RightComp from "./components/RightComp";

function App() {
  return (
    <div className="container">
      <Nav/>
      <div className="d-flex" style={{gap:50}}>
        <LeftComp  />
        <RightComp  />
      </div>
    </div>
  );
}

export default App;

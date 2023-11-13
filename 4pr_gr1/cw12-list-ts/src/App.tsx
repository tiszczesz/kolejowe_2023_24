import "bootstrap/dist/css/bootstrap.min.css";
import { Users } from "./users";
import "./App.css";
import Message from "./components/Message";

function App() {
  return (
    <div className="container">
      {Users.length > 0 ? (
        <div>
          <h1>Lista użytkowników ilość: {Users.length}</h1>
          {Users.map((elm, k) => (
            <Message key={k} user={elm} />
          ))}
        </div>
      ) : (
        <h3>Brak danych</h3>
      )}
    </div>
  );
}

export default App;

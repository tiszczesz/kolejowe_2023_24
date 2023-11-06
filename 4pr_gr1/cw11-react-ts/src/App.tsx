
import 'bootstrap/dist/css/bootstrap.min.css';
import './App.css';
import Card from './components/Card';
import { user1 } from './data/User';

function App() {
  return (
    <div className="container">
      <h1>Hello from React with typescript and bootstrap</h1>
      <Card user={user1} />
    </div>
  );
}

export default App;

import './App.css';
import Message from './components/Message';
import { MyComponent1 } from './components/MyComponent1';

function App() {
  console.log("Renderowanie App");
  return (
    <>
        <h1>Hello from React</h1>
        <MyComponent1 mycolor="red" />
        <Message firstname="fff" lastname="Lolo" />
    </>
 
  );
}

export default App;

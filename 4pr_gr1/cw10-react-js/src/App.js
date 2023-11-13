import './App.css';
import Message from './components/Message';
import { MyComponent1 } from './components/MyComponent1';

function App() {
  console.log("Renderowanie App");
  return (
    <>
        <h1>Hello from React 13.11.2023</h1>
        <MyComponent1 mycolor="green" />
        <Message firstname="Adam" lastname="Nowak" />
    </>
 
  );
}

export default App;


import { Route, Routes } from 'react-router-dom';
import './App.css';
import Nav from './components/Nav';
import Home from './components/Home';
import Exercise1 from './components/Exercise1';

function App() {
  return (
    <div className='container d-flex mt-4'>     
        <Nav /> 
      <main className='m-3'>
        <Routes>
          <Route path='/' element={<Home />}/>
          <Route path='/cw1' element={<Exercise1 />}/>
        </Routes>
      </main>

    </div>
  );
}

export default App;

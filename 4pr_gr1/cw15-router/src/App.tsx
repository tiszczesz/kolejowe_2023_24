import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap/dist/js/bootstrap.bundle';
import './App.css';
import Navbar from './components/Navbar';
import { Route, Routes } from 'react-router-dom';
import Page1 from './components/Page1';
import Page2 from './components/Page2';
import Home from './components/Home';

function App() {
  return (
    <div className="d-flex">
      <div style={{width:"300px"}} className='m-2'>
        <Navbar  />
      </div>
      
      <div className='m-2'>
        <Routes>
          <Route path='/' element={<Home />} />
          <Route path='/page1' element={<Page1/>}/>
          <Route path='/page2' element={<Page2/>}/>

        </Routes>
      </div>
    </div>
  );
}

export default App;

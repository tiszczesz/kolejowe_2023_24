import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap/dist/js/bootstrap.bundle';
import './App.css';
import Navbar from './components/Navbar';
import { Route, Routes } from 'react-router-dom';
import Page1 from './components/Page1';
import Page2 from './components/Page2';
import Home from './components/Home';
import Holiday from './components/Holiday';

function App() {
  return (
    <div className="d-flex container">
      <div style={{width:"300px"}} className='m-2'>
        <Navbar  />
      </div>
      
      <div className='m-2 mt-5 w-100'>
        <Routes>
          <Route path='/' element={<Home />} />
          <Route path='/page1' element={<Page1/>}/>
          <Route path='/page2' element={<Page2/>}/>
          <Route path='/holiday' element={<Holiday/>}/>

        </Routes>
      </div>
    </div>
  );
}

export default App;

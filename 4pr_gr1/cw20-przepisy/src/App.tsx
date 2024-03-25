import { MouseEvent } from 'react';
import { useState } from 'react';
import './App.css';
import { Recipe, Recipes } from './Services/Data';
import RecipleComp from './components/RecipleComp';


function App() {
 
  const [recipes,setRecipes] = useState<Recipe[]>(Recipes);


  function handleClick(item:string): void {
    console.log(item);
    
  }

  return (
    <div className="container">
      <h2>Świąteczne przepisy</h2>
      <div className='d-flex flex-wrap justify-content-around"'>
         {
        recipes.map((item,index)=>(
          <RecipleComp onSelect={handleClick} key={index} recipe={item} />
        ))
      }
      </div>
     
    </div>
  );
}

export default App;

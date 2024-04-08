import { MouseEvent } from "react";
import { useState } from "react";
import "./App.css";
import { Recipe, Recipes } from "./Services/Data";
import RecipleComp from "./components/RecipleComp";


function App() {
  const [recipes, setRecipes] = useState<Recipe[]>(Recipes);
  const [selectedRecipe, SetSelectedRecipe] = useState<Recipe|undefined>(undefined);
  console.log(selectedRecipe);
  
  function handleClick(item: Recipe): void {
    //console.log(item);
    SetSelectedRecipe({...item});
  }

  return (
    <>   
    
        {selectedRecipe && (
          <div className="details">
            Wybrano: {selectedRecipe.name}<br />
            ilość składników: {selectedRecipe.ingredient.length}<br />
            Szacowana cena: {selectedRecipe.price} zł<br />
          </div>
        )}
      
    <div className="container">
      
        <h2>Świąteczne przepisy</h2>

        <div className='d-flex flex-wrap justify-content-around"'>
          {recipes.map((item, index) => (
            <RecipleComp onSelect={handleClick} key={index} recipe={item} />
          ))}
        </div>
    
     
    </div>
    </>
 
  );
}

export default App;

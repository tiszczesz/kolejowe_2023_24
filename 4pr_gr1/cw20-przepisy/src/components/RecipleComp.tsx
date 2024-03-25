import React from 'react'
import { Recipe } from '../Services/Data'

type Props = {
    recipe:Recipe,
   onSelect:(elem:string)=>void
}

const RecipleComp = (props: Props) => {
  return (
    <div className='card' style={{width:"20rem",margin:20,padding:10}}>
        <img  className="card-img-top" style={{height:200}} src={props.recipe.img} alt="obrazek" />
        <h2 className='card-title'>{props.recipe.name}</h2>
        <div className='card-body'>
        <p>{props.recipe.description}</p>
        
        <ul className='list-group' style={{fontSize:"0.8em"}}>
            {props.recipe.ingredient.map((item,index)=>(
                <li className='list-group-item' key={index}>{item}</li>
            ))}
        </ul>
        <p className='text-end'>Szacowana cena: {props.recipe.price} zł</p>
        </div>
        <input type="button" className='btn btn-outline-info' value="Szczegóły" onClick={()=>props.onSelect(props.recipe.name)} />
    </div>
  )
}

export default RecipleComp
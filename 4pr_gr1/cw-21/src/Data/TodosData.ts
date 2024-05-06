import { title } from 'process';
import { v4 as uuidv4 } from 'uuid';
export  type Todo = {
    id:string;
    title:string;
    content:string;
    date:Date
}

export const Todos:Todo[] = [
    {id:uuidv4(),title:"Zadanie 1",content:"Treść zadania nr 1",date:new Date('2012-09-12')},
    {id:uuidv4(),title:"Zadanie 2",content:"Treść zadania nr 2",date:new Date('2024-02-22')},
    {id:uuidv4(),title:"Zadanie 3",content:"Treść zadania nr 3",date:new Date()},
    {id:uuidv4(),title:"Zadanie 4",content:"Treść zadania nr 4",date:new Date('2023-07-12')},
    {id:uuidv4(),title:"Zadanie 5",content:"Treść zadania nr 5",date:new Date()}
]
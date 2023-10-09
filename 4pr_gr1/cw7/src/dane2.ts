export  const Users:User[] = [
    {firstname:"Adam",lastname:"Nowak",age:34,show:()=>{return "ggggg"}},
    {firstname:"Roman",lastname:"Nowak",age:34,show:()=>{return "ggggg"}},
    {firstname:"Anna",lastname:"Nowak",age:34,show:()=>{return "ggggg"}},
    {firstname:"Adam",lastname:"Nowak",age:34,show:()=>{return "ggggg"}},
]
export interface User{
    firstname:string;
    lastname:string;
    age:number;
    show:()=>string
}
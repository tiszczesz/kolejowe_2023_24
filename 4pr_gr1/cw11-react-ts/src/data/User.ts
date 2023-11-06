export interface IUser{
    firstname:string;
    lastname:string;
    date:Date;    
}
export const user1:IUser = {
    firstname:"Alan",
    lastname:"Nowik",
    date:new Date("2004-12-05")
}
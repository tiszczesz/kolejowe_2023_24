export interface Todo{
    userId: number,
    id: number,
    title: string,
    completed: boolean
}
export interface User{    
        id: number,
        name: string,
        username: string,
        email: string,
       
        phone: string,
        website: string,   
}
export async function getTodos():Promise<Todo[]> {
    const response = await fetch("https://jsonplaceholder.typicode.com/todos");
    return response.json();    
}
export async function getUsers():Promise<User[]> {
    const response = await fetch("https://jsonplaceholder.typicode.com/users");
    return response.json();    
}
export interface Todo{
    userId: number,
    id: number,
    title: string,
    completed: boolean
}
export async function getTodos():Promise<Todo[]> {
    const response = await fetch("https://jsonplaceholder.typicode.com/todos");
    return response.json();    
}
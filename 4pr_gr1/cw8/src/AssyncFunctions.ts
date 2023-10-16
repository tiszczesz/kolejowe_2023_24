const delay3 = (t:number,info:string)=>{
    return new Promise<void>((res)=>{
        setTimeout(()=>{
            console.log(info); 
            res();           
        },t)
    })
}
async function Runner(){
    await delay3(3000,"Zadanie 1");
    await delay3(2000,"Zadanie 2");
    await delay3(300,"Zadanie 3");
}
// (async function (){
//     await delay3(3000,"Zadanie 1");
//     await delay3(2000,"Zadanie 2");
//     await delay3(300,"Zadanie 3");
// })()
Runner();
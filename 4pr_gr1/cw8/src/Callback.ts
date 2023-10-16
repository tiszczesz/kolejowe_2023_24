function Delay(callback:()=>void,time:number):void {
    setTimeout(()=>{
        callback();
    },time)
}

// Delay(()=>console.log("Zadanie 1"),3000);
// Delay(()=>console.log("Zadanie 2"),2000);
// Delay(()=>console.log("Zadanie 3"),4000);

const zadania = () => {
    console.log("Poczatek pracy");
    Delay(() => {
        console.log("Zadanie 1");
        Delay(() => {
            console.log("Zadanie 2");
            Delay(()=>{
                console.log("zadanie 3")
            },300)
            
        },4000)
        
    },1000)
}
zadania();
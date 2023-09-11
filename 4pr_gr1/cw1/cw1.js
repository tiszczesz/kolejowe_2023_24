alert("ggggg");
console.log("fdffdff");
 console.log(window);
 //console.log(a);
 //console.log(parseInt(0.0000005));
 
 let a = 12;
 var b = 67; 
 const t = true;
 function g1(){
    console.log(this);
}
const g2 = function (){
    console.log(this);
}
const g3 = ()=>{
    console.log(this);
}
g1();
g2();
g3();
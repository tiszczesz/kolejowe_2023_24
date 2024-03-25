"use strict";
const readline = require('readline').createInterface({
    input: process.stdin,
    output: process.stdout
});
// readline.question('Jak masz na imie: ', (firstname:string) =>{
//   console.log('Witaj: '+firstname);
// } )
readline.setPrompt('Podaj liczbe: ');
readline.prompt();
readline.on('line', (liczba) => {
    console.log(`${liczba}^2 = ${Math.pow(liczba, 2)}`);
    readline.close();
});

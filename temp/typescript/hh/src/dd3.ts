import * as readline from 'readline';

const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});

rl.question('Podaj pierwszą liczbę: ', (a) => {
  rl.question('Podaj drugą liczbę: ', (b) => {
    const sum = Number(a) + Number(b);
    console.log(`Suma ${a} i ${b} wynosi ${sum}.`);
    rl.close();
  });
});

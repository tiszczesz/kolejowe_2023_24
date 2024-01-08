import * as readline from 'readline';
const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});
rl.question('Podaj swoje imię: ', (name) => {
    console.log(`Witaj ${name}!`);
    rl.close();
});

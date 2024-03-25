import readline from 'readline';

const r1 = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});
const q1 = () => {
    return new Promise<string>((resolve, reject) => {
        r1.question("Podaj a: ", (a: string) => {
            console.log('Podałeś: a= ' + a);
            resolve(a);
        });
    });
}
const q2 = () => {
    return new Promise<string>((resolve, reject) => {
        r1.question("Podaj b: ", (b: string) => {
            console.log('Podałeś: b= ' + b);
            resolve(b);
        });
    });
}

const main = async () => {
    const aa = parseFloat(await q1());
    const bb = parseFloat(await q2());
    if (isNaN(aa) || isNaN(bb))  console.log("Błędne dane!!!!")
    else console.log(`${aa} + ${bb} = ${aa + bb}`);
    r1.close();
};

main();
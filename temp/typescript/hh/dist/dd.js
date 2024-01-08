import * as readline from 'readline';
import * as fs from 'fs';
async function processLineByLine() {
    const fileStream = fs.createReadStream('file.txt');
    const rl = readline.createInterface({
        input: fileStream,
        crlfDelay: Infinity
    });
    for await (const line of rl) {
        console.log(`Line from file: ${line}`);
    }
}
processLineByLine();

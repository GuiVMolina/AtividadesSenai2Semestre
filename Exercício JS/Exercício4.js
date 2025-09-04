/*
    Verificar se um número é positivo, negativo ou zero:
    - Peça ao usuário para inserir um número.
    - Use um `if-else` para verificar se o número é positivo, negativo ou zero.
*/
const prompt = require("prompt-sync")();
let num = parseInt(prompt("Insira um número: "));
if (num > 0) console.log("Ele é positivo");
else if (num < 0) console.log("Ele é negativo");
else console.log("Ele é zero");
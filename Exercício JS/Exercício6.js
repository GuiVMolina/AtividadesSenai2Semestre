/*
    Verificar se um número é par ou ímpar:
    - Peça ao usuário para inserir um número.
    - Use o operador `%` para verificar se o número é divisível por 2.
*/
const prompt = require("prompt-sync")();
let num = parseInt(prompt("Escolha um número: "));
num % 2 == 0 ? console.log("Par\nDivisível por 2") : console.log("Ímpar\nNão divisível por 2");
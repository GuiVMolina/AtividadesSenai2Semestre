/*
    Maior entre três números:
    - O usuário insere três números.
    - Use `if-else` para determinar e exibir o maior.
*/
const prompt = require("prompt-sync")();
let numX = parseInt(prompt("Qual o valor de X? "));
let numY = parseInt(prompt("Qual o valor de Y? "));
let numZ = parseInt(prompt("Qual o valor de Z? "));

if (numX >= numY && numX >= numZ){
    console.log("O valor de X é o maior (" + numX +")");
} else if (numY >= numX && numY >= numZ){
    console.log("O valor de Y é o maior (" + numY +")");
} else if (numZ >= numX && numZ >= numY){
    console.log("O valor de Z é o maior (" + numZ +")");
} else {
    console.log("Todos são iguais");
}
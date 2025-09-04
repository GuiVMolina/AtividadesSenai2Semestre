/*
    Conversão de notas para conceitos:
    - O usuário insere uma nota (0-100).
    - Converta para conceitos:
    - `A` (90-100), `B` (80-89), `C` (70-79), `D` (60-69), `F` (<60).
*/
const prompt = require("prompt-sync")();
let nota = parseInt(prompt("Qual foi sua nota? "));
if (nota >= 90){
    console.log("nota A");
} else if (nota >= 80){
    console.log("nota B");
} else if (nota >= 70){
    console.log("nota C");
} else if (nota >= 60){
    console.log("nota D");
} else {
    console.log("nota F");
}
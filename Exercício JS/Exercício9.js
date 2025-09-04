/*
    Desconto em compras:
    - Se o valor da compra for maior que R$ 100, aplique 10% de desconto.
    - Caso contrário, exiba o valor normal.
*/
const prompt = require("prompt-sync")();
let valor = parseInt(prompt("Quanto custou a roupa? "));

if (valor > 100) {
    valor *= 0.9;
    console.log("Ganhou desconto de 10%")
}

console.log("O preço fica então: " + valor)
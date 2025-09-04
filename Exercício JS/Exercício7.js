/*
    Calculadora simples:
    - Peça dois números e uma operação (`+`, `-`, `*`, `/`).
    - Use um `if-else` para calcular o resultado e exibi-lo.
*/
const prompt = require("prompt-sync")();
let numX = parseInt(prompt("Qual o valor de X? "));
let numY = parseInt(prompt("Qual o valor de Y? "));
let operacao = parseInt(prompt("1 = Soma\n" +
                               "2 = Subtração\n" +
                               "3 = Multiplacação\n" +
                               "4 = Divisão\n" +
                               "Selecione a operacao: "));
switch (operacao){
    case 1:
        console.log("Soma = " + numX + numY);
        break;
    case 2:
        console.log("Subtração = " + numX - numY);
        break;
    case 3:
        console.log("Multiplação = " + numX * numY);
        break;
    case 4:
        console.log("Divisão = " + numX / numY);
        break;
    default:
        console.log("Operação desconhecida")
        break;
}
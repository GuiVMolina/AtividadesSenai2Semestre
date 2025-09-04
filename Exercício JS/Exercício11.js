/*
    Classificação de triângulos:
    - O usuário insere três lados.
    - Verifique se forma um triângulo e classifique como equilátero, isósceles ou escaleno.
*/
const prompt = require("prompt-sync")();
let ladoX = parseInt(prompt("Valor do lado X: "));
let ladoY = parseInt(prompt("Valor do lado Y: "));
let ladoZ = parseInt(prompt("Valor do lado Z: "));

if (ladoX == ladoY && ladoX == ladoZ){
    console.log("Triângulo Equilátero");
} else if ((ladoX == ladoY && ladoX != ladoZ) || (ladoX != ladoY && ladoX == ladoY)){
    console.log("Triângulo Isósceles");
} else {
    console.log("Triângulo Escaleno");
}
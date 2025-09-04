/*
    Cálculo de IMC:
    - Peça peso e altura.
    - Calcule o IMC e classifique como abaixo do peso, normal, sobrepeso ou obesidade.
*/
const prompt = require("prompt-sync")();
let altura = parseInt(prompt("Qual sua altura? "));
let peso = parseInt(prompt("Qual seu peso? "));
const IMC = peso / (altura * altura); 

if (IMC < 18.5){
    console.log("Abaixo do peso");
} else if (IMC >= 18.5 && IMC < 25){
    console.log("Normal");
} else if (IMC >= 25 && IMC < 30){
    console.log("Sobrepeso");
} else {
    console.log("Obesidade")
}
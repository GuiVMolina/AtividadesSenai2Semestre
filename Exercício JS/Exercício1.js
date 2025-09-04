/*
    Verificar maioridade:
    - Peça ao usuário uma idade.
    - Use um `if-else` para verificar se ele é maior ou menor de idade.
*/
const prompt = require("prompt-sync")();
let idade = parseInt(prompt("Quantos anos você tem? "));
idade >= 18 ? console.log("Você é maior de idade") : console.log("Você é menor de idade");
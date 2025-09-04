/*
    Classificação de idade:
    - Peça ao usuário para inserir sua idade.
    - Exiba se ele é "Criança" (0-12), "Adolescente" (13-17) ou "Adulto" (18+).
*/
const prompt = require("prompt-sync")();
let idade = parseInt(prompt("Quantos anos você tem? "));
if (idade >= 0 && idade < 13) console.log("Criança");
else if (idade >= 13 && idade < 17) console.log("Adolescente");
else console.log("Adulto");
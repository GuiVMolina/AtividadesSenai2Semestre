/*
    Validação de ano bissexto:
    - Peça um ano e verifique se é bissexto.
    - Um ano é bissexto se for divisível por 4, mas não por 100, exceto se for divisível por 400.
*/
const prompt = require("prompt-sync")();
let ano = parseInt(prompt("Escolha um ano: "));

let bissexto = (ano % 400 === 0) || (ano % 4 === 0 && ano % 100 !== 0);

console.log(bissexto ? "É bissexto" : "Não é bissexto");

/*
    Aprovação em uma prova:
    - O usuário insere a nota de um aluno (0 a 100).
    - Se a nota for maior ou igual a 60, exibir "Aprovado", senão "Reprovado".
*/
const prompt = require("prompt-sync")();
let nota = parseInt(prompt("Qual foi sua nota? "));
if (nota >= 60) console.log("Aprovado");
else console.log("Reprovado");
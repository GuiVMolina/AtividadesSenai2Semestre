/*
    Sistema de login simples:
    - O usuário insere um nome de usuário e senha.
    - Se `usuario == "admin"` e `senha == "1234"`, exibir "Login bem-sucedido", caso contrário "Acesso negado".
*/
const prompt = require("prompt-sync")();
let user = parseInt(prompt("Usuário: "));
let password = parseInt(prompt("Senha: "));

if (user == "admin" && senha == "1234") {
    console.log("Login bem-sucedido");
} else {
    console.log("Acesso negado");
}
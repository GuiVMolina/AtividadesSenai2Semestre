// * Declaração de variáveis
let mensagemLet = "Olá, Mundo!";     // Recomendada, fica no escopo da função
var mensagemVar = "Olá, Mundo!";     // Não recomendada, vai para fora do escopo da função
const mensagemConst = "Olá, Mundo!"; // Recomendada para valores que não mudam

console.log(mensagemLet);
console.log(mensagemVar);
console.log(mensagemConst);

// * Operações matemáticas
let valorA = 10;
let valorB = 5;

console.log("Soma:", valorA + valorB);              // valorA + valorB
console.log("Subtração:", valorA - valorB);         // valorA - valorB
console.log("Multiplicação:", valorA * valorB);     // valorA * valorB
console.log("Divisão:", valorA / valorB);           // valorA / valorB
console.log("Exponenciação:", valorA ** valorB);    // valorA elevado ao valorB
console.log("Resto da divisão:", valorA % valorB);  // Resto da divisão do valorA pelo valorB

console.log("Incremento:", ++valorA); // valorA = valorA + 1
valorA = 10;
console.log("Decremento:", --valorA); // valorA = valorA - 1
valorA = 10;

// * Concatenação de textos
let textoA = "10";
let textoB = "5";
//valorA = 10

console.log("Concatenação:", textoA + textoB);
console.log("Soma com texto:", valorA + textoA);
console.log("Concatenação com número:", textoA + valorA);
console.log(1 - "banana"); // NaN

// * Comparações
let variavel = 1;
let texto = "1";

console.log(variavel == 1);   // true
console.log(variavel === 1);  // true
console.log(texto == 1);      // true
console.log(texto === 1);     // false
console.log(1 == true);       // true
console.log(1 === true);      // false
console.log("1" == true);     // true
console.log("1" === true);    // false
console.log("" == false);     // true
console.log("" === false);    // false

// * Exemplificação
let nome = "Guilherme";
let idade = 19;

console.log("Olá, meu nome é " + nome + ", tenho " + idade + " anos");
console.log(`Olá, meu nome é ${nome}, tenho ${idade} anos`);

// * typeof
let mensagem = `Olá, meu nome é ${nome}, tenho ${idade} anos`;
let profissao;
let endereco = null;

console.log(typeof mensagem);   // string
console.log(typeof idade);      // number
console.log(typeof profissao);  // undefined
console.log(typeof endereco);   // object

// * Estruturas Condicionais
let temperatura = 12;

if (temperatura > 25) {
    console.log("Está calor");
} else {
    console.log("Está frio");
}

let nota = parseInt(prompt("Digite a nota: "));
if (nota > 6) {
    console.log("Aprovado");
} else if (nota >= 5) {
    console.log("Está de recuperação");
} else {
    console.log("Reprovado");
}

// * Operador Ternário
let saldo = 90;
let podeComprar = saldo >= 100 ? "Compra aprovada" : "Saldo insuficiente";
console.log(podeComprar);


// * CONDICIONAL ALINHADA
// Multiplas verificações
let hora = 8;
let diaDaSemana = "terça";

if(hora >= 8 && hora < 12){
    console.log("Bom dia");
} else {
    if(hora >= 12 && hora < 18){
        if(diaDaSemana == "segunda"){
            console.log("Boa tarde, ótima semana!");
        } else {
            console.log("Boa tarde");
        }
    }
    else {
        console.log("Boa noite!");
    }
}

// * SWITCH / CASE
let dia = 2;
switch(dia) {
    case 1:
        console.log("Domingo");
        break;
    case 2:
        console.log("Segunda");
        break;
    case 3:
        console.log("Terça");
        break;
    case 4:
        console.log("Quarta");
        break;
    case 5:
        console.log("Quinta");
        break;
    case 6:
        console.log("Sexta");
        break;
    case 7:
        console.log("Sábado");
        break;
    default:
        console.log("Dia inválido");
        break;
}
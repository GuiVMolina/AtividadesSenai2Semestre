// * let - recomendada, fica no escopo da função
// ! console.log(mensagemLet); Daria erro
let mensagemLet = "Olá, Mundo!";
console.log(mensagemLet);

// * var - não recomendada, vai para fora do escopo da função
console.log(mensagemVar);
var mensagemVar = "Olá, Mundo!";
console.log(mensagemVar);

// * const - recomendada para valores que não mudam
// ! console.log(mensagemConst); Daria erro
const mensagemConst = "Olá, Mundo!";
console.log(mensagemConst);

// * Operações matemáticas (+, -, *, / e %)
let valorA = 10;
let valorB = 5;

let resultadoSoma = valorA + valorB;
console.log("Resultado da soma:", resultadoSoma);

let resultadoSubtracao = valorA - valorB;
console.log("Resultado da subtração:", resultadoSubtracao);

let resultadoMultiplicacao = valorA * valorB;
console.log("Resultado da multiplicação:", resultadoMultiplicacao);

let resultadoDivisao = valorA / valorB;
console.log("Resultado da divisão:", resultadoDivisao);

let resultadoExponenciacao = valorA ** valorB;
console.log("Resultado da exponenciação:", resultadoExponenciacao);

let resultadoResto = valorA % valorB;
console.log("Resultado do resto da divisão:", resultadoResto);

let resultadoIncremento = ++valorA; // valorA = valorA + 1
console.log("Resultado do incremento:", resultadoIncremento);
valorA = 10;

let resultadoDecremento = --valorA; // valorA = valorA - 1;
console.log("Resultado do decremento:", resultadoDecremento)
valorA = 10;

// * Concatenação de textos
let textoA = "10";
let textoB = "5";
let resultadoTexto = textoA + textoB;
console.log("Resultado da concatenação:", resultadoTexto);
console.log(1 - "banana"); // = NaN

// * Soma com texto
resultadoTexto = valorA + textoA; // 10 + "10" = "1010"
console.log("Resultado da soma com texto:", resultadoTexto);
resultadoTexto = textoA + valorA; // "10" + 10 = "1010"
console.log("Resultado da concatenação com número:", resultadoTexto);

// * Comparação (==, ===, !=, ===, >, >=, < e <=)
let variavel = 1;
let texto = "1";
console.log(variavel == 1);  // * true
console.log(variavel === 1); // * true

console.log(texto == 1);     // * true
console.log(texto === 1);    // ! false

console.log(1 == true);      // * true
console.log(1 === true);     // ! false

console.log("1" == true);    // * true
console.log("1" === true);   // ! false

console.log("" == false);    // * true
console.log("" === false);   // ! false
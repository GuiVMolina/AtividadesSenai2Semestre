// map, filter, find, reduce
const numeros = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
let nomes = ["Ana", "Bruno", "Carlos", "Eva", "Fernanda"];

/* --- FILTER --- */
const maioresQueDois = numeros.filter((numero) => numero > 2);
console.log(maioresQueDois);

let nomesLongos = nomes.filter((nome) => nome.length > 5);
console.log(nomesLongos);

let numerosPares = numeros.filter((numero) => numero % 2 == 0);
console.log(numerosPares);

let pessoas = [
  { nome: "Lucas", idade: 17 },
  { nome: "Mariana", idade: 22 },
  { nome: "Ana", idade: 15 },
  { nome: "Juliana", idade: 30 },
];
let adultos = numeros.filter((pessoa) => pessoa.idade >= 18);
console.log(adultos);

/* --- FIND --- */
const produtos = [
  { id: 1, nome: "Teclado", preco: 100 },
  { id: 2, nome: "Mouse", preco: 50 },
  { id: 3, nome: "Monitor", preco: 700 },
];
const produtoCaro = produtos.find((produto) => produto.preco > 600);
console.log(produtoCaro);

let encontrado = numeros.find((numero) => numero > 10);
console.log(encontrado);

let nomeEncontrado = nomes.find((nome) => nome.startsWith("c"));
console.log(nomeEncontrado);

const numerosDobrados = numeros.map((numero) => numero * 2);
console.log(numerosDobrados);

let pessoaNome = pessoas.map((pessoa) => pessoa.nome);
console.log(pessoaNome);

let mensagem = pessoas.map(
  (pessoa) => `${pessoa.nome} tem ${pessoa.idade} anos.`
);

const nomesMaisculo = nomes.map((nome) => "Colaborador: " + nome.toUpperCase());

const soma = numeros.reduce((acumulador, numero) => acumulador + numero, 0);
console.log(soma);

const numerosAleatorios = [10, 5, 8, 20, 3];
const maiorNumero = numerosAleatorios.reduce((max, numero) => {
  if (numero > max) {
    return numero;
  } else {
    return max;
  }
}, numeros[0]);

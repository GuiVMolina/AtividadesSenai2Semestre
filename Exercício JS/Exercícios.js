// Função para exibir exercício na tela
function ex1() {
  let idade = document.getElementById("valorEx1").value;
  if (idade >= 18){
    document.getElementById("saidaEx1").innerHTML =
    "Você tem " + idade + " anos, logo você é maior de idade";
  } else if (idade < 0) {
    document.getElementById("saidaEx1").innerHTML =
    "Valor inválido!";
  } else {
    document.getElementById("saidaEx1").innerHTML =
    "Você tem " + idade + " anos, logo você é menor de idade";
  }
}

function ex2() {
  let num = document.getElementById("valorEx2").value;
  if (num > 0){
    document.getElementById("saidaEx2").innerHTML =
    "O número " + num + " é positivo!";
  } else {
    document.getElementById("saidaEx2").innerHTML =
    "O número " + idade + " é negativo";
  }
}

function ex3() {
  let nota = document.getElementById("valorEx3").value;
  if (nota >= 60) {
    document.getElementById("saidaEx3").innerHTML =
    "O aluno tirou " + nota + ", então está aprovado!";
  } else if (nota < 0) {
    document.getElementById("saidaEx3").innerHTML =
    "Valor inválido!";
  } else {
    document.getElementById("saidaEx3").innerHTML =
    "O aluno tirou " + nota + ", então está reprovado!";
  }
}

function ex4() {
  let num = document.getElementById("valorEx4").value;
  if (num > 0){
    document.getElementById("saidaEx4").innerHTML =
    "O número " + num + " é positivo!";
  } else if (num < 0) {
    document.getElementById("saidaEx4").innerHTML =
    "O número " + num + " é negativo!";
  } else {
    document.getElementById("saidaEx4").innerHTML =
    "O número " + num + " é zero!";
  }
}

function ex5() {
  let idade = document.getElementById("valorEx5").value;
  if (idade >= 0 && idade < 13){
    document.getElementById("saidaEx5").innerHTML =
    "Você tem " + idade + " anos, logo você é criança";
  } else if (idade >= 13 && idade < 18){
    document.getElementById("saidaEx5").innerHTML =
    "Você tem " + idade + " anos, logo você é adolescente";
  } else if (idade >= 18){
    document.getElementById("saidaEx5").innerHTML =
    "Você tem " + idade + " anos, logo você é adulto";
  } else {
    document.getElementById("saidaEx5").innerHTML =
    "Valor inválido!";
  }
}

function ex6() {
  let num = 

}

function ex7() {

}

function ex8() {

}

function ex9() {

}

function ex10() {

}

function ex11() {

}

function ex12() {

}

function ex13() {

}

function ex14() {

}
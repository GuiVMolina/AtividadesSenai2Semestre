// Função para exibir exercício na tela
function ex1() {
  let idade = Number(document.getElementById("valorEx1").value);
  if (idade >= 18) {
    document.getElementById("saidaEx1").innerHTML =
      "Você tem " + idade + " anos, logo você é maior de idade";
  } else if (idade > 0 && idade < 18) {
    document.getElementById("saidaEx1").innerHTML =
      "Você tem " + idade + " anos, logo você é menor de idade";
  } else {
    document.getElementById("saidaEx1").innerHTML = "Valor inválido!";
  }
}

function ex2() {
  let num = Number(document.getElementById("valorEx2").value);
  if (num > 0) {
    document.getElementById("saidaEx2").innerHTML =
      "O número " + num + " é positivo!";
  } else {
    document.getElementById("saidaEx2").innerHTML =
      "O número " + num + " é negativo";
  }
}

function ex3() {
  let nota = Number(document.getElementById("valorEx3").value);
  if (nota >= 60 && nota <= 100) {
    document.getElementById("saidaEx3").innerHTML =
      "O aluno tirou " + nota + ", então está aprovado!";
  } else if (nota >= 0 && nota < 60) {
    document.getElementById("saidaEx3").innerHTML =
      "O aluno tirou " + nota + ", então está reprovado!";
  } else {
    document.getElementById("saidaEx3").innerHTML = "Valor inválido!";
  }
}

function ex4() {
  let num = Number(document.getElementById("valorEx4").value);
  if (num > 0) {
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
  let idade = Number(document.getElementById("valorEx5").value);
  if (idade >= 0 && idade < 13) {
    document.getElementById("saidaEx5").innerHTML =
      "Você tem " + idade + " anos, logo você é criança";
  } else if (idade >= 13 && idade < 18) {
    document.getElementById("saidaEx5").innerHTML =
      "Você tem " + idade + " anos, logo você é adolescente";
  } else if (idade >= 18) {
    document.getElementById("saidaEx5").innerHTML =
      "Você tem " + idade + " anos, logo você é adulto";
  } else {
    document.getElementById("saidaEx5").innerHTML = "Valor inválido!";
  }
}

function ex6() {
  let num = Number(document.getElementById("valorEx6").value);
  if (num % 2 == 0) {
    document.getElementById("saidaEx6").innerHTML =
      "O valor " + num + " é Par, divisível por 2";
  } else {
    document.getElementById("saidaEx6").innerHTML =
      "O valor " + num + " é Ímpar, não divisível por 2";
  }
}

function ex7soma() {
  let numX = Number(document.getElementById("valorEx7-1").value);
  let numY = Number(document.getElementById("valorEx7-2").value);
  let resultado = numX + numY;
  document.getElementById("saidaEx7").innerHTML =
    numX + " + " + numY + " = " + resultado;
}

function ex7sub() {
  let numX = Number(document.getElementById("valorEx7-1").value);
  let numY = Number(document.getElementById("valorEx7-2").value);
  let resultado = numX - numY;
  document.getElementById("saidaEx7").innerHTML =
    numX + " - " + numY + " = " + resultado;
}

function ex7mult() {
  let numX = Number(document.getElementById("valorEx7-1").value);
  let numY = Number(document.getElementById("valorEx7-2").value);
  let resultado = numX * numY;
  document.getElementById("saidaEx7").innerHTML =
    numX + " * " + numY + " = " + resultado;
}

function ex7div() {
  let numX = Number(document.getElementById("valorEx7-1").value);
  let numY = Number(document.getElementById("valorEx7-2").value);
  let resultado = numX / numY;
  document.getElementById("saidaEx7").innerHTML =
    numX + " / " + numY + " = " + resultado;
}

function ex8() {
  let valorA = Number(document.getElementById("valorEx8-1").value);
  let valorB = Number(document.getElementById("valorEx8-2").value);
  let valorC = Number(document.getElementById("valorEx8-3").value);

  if (valorA === valorB && valorB === valorC) {
    document.getElementById("saidaEx8").innerHTML =
      "Todos os valores são iguais (" + valorA + ")";
  } else if (valorA >= valorB && valorA >= valorC) {
    document.getElementById("saidaEx8").innerHTML =
      "O valor de A é o maior (" + valorA + ")";
  } else if (valorB >= valorA && valorB >= valorC) {
    document.getElementById("saidaEx8").innerHTML =
      "O valor de B é o maior (" + valorB + ")";
  } else {
    document.getElementById("saidaEx8").innerHTML =
      "O valor de C é o maior (" + valorC + ")";
  }
}

function ex9() {
  let valor = Number(document.getElementById("valorEx9").value);
  if (valor > 100) {
    document.getElementById("saidaEx9").innerHTML =
      "Desconto de 10% (R$" +
      valor * 0.1 +
      "), o produto sai por R$" +
      valor * 0.9;
  } else if (valor > 0) {
    document.getElementById("saidaEx9").innerHTML =
      "Sem desconto, o produto sai por R$" + valor;
  } else {
    document.getElementById("saidaEx9").innerHTML = "Valor inválido!";
  }
}

function ex10() {
  let user = document.getElementById("valorEx10-1").value;
  let senha = document.getElementById("valorEx10-2").value;
  if (user == "admin" && senha == "1234") {
    document.getElementById("saidaEx10").innerHTML = "Login feito com sucesso!";
  } else {
    document.getElementById("saidaEx10").innerHTML =
      "Usuário ou senha errados! Tente novamente!";
  }
}

function ex11() {
  let ladoA = Number(document.getElementById("valorEx11-1").value);
  let ladoB = Number(document.getElementById("valorEx11-2").value);
  let ladoC = Number(document.getElementById("valorEx11-3").value);
  if (ladoA <= 0 || ladoB <= 0 || ladoC <= 0) {
    document.getElementById("saidaEx11").innerHTML = "Valor inválido";
  } else if (ladoA == ladoB && ladoA == ladoC) {
    document.getElementById("saidaEx11").innerHTML = "Triângulo Equilátero";
  } else if (
    (ladoA == ladoB && ladoA != ladoC) ||
    (ladoA != ladoB && ladoA == ladoC) ||
    (ladoB != ladoA && ladoB == ladoC)
  ) {
    document.getElementById("saidaEx11").innerHTML = "Triângulo Isósceles";
  } else {
    document.getElementById("saidaEx11").innerHTML = "Triângulo Escaleno";
  }
}

function ex12() {
  let nota = Number(document.getElementById("valorEx12").value);
  if (nota >= 90 && nota <= 100) {
    document.getElementById("saidaEx12").innerHTML =
      "Você tirou " + nota + ", ficou com A na média";
  } else if (nota >= 80 && nota < 90) {
    document.getElementById("saidaEx12").innerHTML =
      "Você tirou " + nota + ", ficou com B na média";
  } else if (nota >= 70 && nota < 80) {
    document.getElementById("saidaEx12").innerHTML =
      "Você tirou " + nota + ", ficou com C na média";
  } else if (nota >= 60 && nota < 70) {
    document.getElementById("saidaEx12").innerHTML =
      "Você tirou " + nota + ", ficou com D na média";
  } else if (nota >= 0 && nota < 60) {
    document.getElementById("saidaEx12").innerHTML =
      "Você tirou " + nota + ", ficou com F na média";
  } else {
    document.getElementById("saidaEx12").innerHTML = "Valor inválido!";
  }
}

function ex13() {
  let altura = Number(document.getElementById("valorEx13-1").value);
  let peso = Number(document.getElementById("valorEx13-2").value);
  const IMC = peso / (altura * altura);
  if (altura <= 0 || peso <= 0) {
    document.getElementById("saidaEx13").innerHTML = "Valor inválido";
  } else if (IMC < 18.5) {
    document.getElementById("saidaEx13").innerHTML =
      "IMC: " + IMC + " - Abaixo do peso";
  } else if (IMC >= 18.5 && IMC < 25.0) {
    document.getElementById("saidaEx13").innerHTML =
      "IMC: " + IMC + " - Normal";
  } else if (IMC >= 25.0 && IMC < 30.0) {
    document.getElementById("saidaEx13").innerHTML =
      "IMC: " + IMC + " - Sobrepeso";
  } else {
    document.getElementById("saidaEx13").innerHTML =
      "IMC: " + IMC + " - Obesidade";
  }
}

function ex14() {
  let ano = Number(document.getElementById("valorEx14").value);
  let bissexto = ano % 400 === 0 || (ano % 4 === 0 && ano % 100 !== 0);
  if (ano >= 0) {
    document.getElementById("saidaEx14").innerHTML = bissexto
      ? "É bissexto"
      : "Não é bissexto";
  } else {
    document.getElementById("saidaEx14").innerHTML = "Valor inválido!";
  }
}

function testeDeRepeticaoFOR() {
  let num = Number(document.getElementById("valorTesteFOR").value);
  let saida = "";

  if (num > 0) {
    for (let i = 1; i <= num; i++) {
      saida += i + " ";
    }
  } else {
    for (let i = 0; i >= num; i--) {
      saida += i + " ";
    }
  }
  document.getElementById("saidaTesteFOR").innerHTML = saida;
}

function testeDeRepeticaoWHILE() {
  let num = Number(document.getElementById("valorTesteWHILE").value);
  let saida = "";

  if (num > 0) {
    let i = 1;
    while (i <= num) {
      saida += i + " ";
      i++;
    }
  } else {
    let i = 0;
    while (i >= num) {
      saida += i + " ";
      i--;
    }
  }
  document.getElementById("saidaTesteWHILE").innerHTML = saida;
}

function testeDeRepeticaoDOWHILE() {
  let num = Number(document.getElementById("valorTesteDOWHILE").value);
  let saida = "";

  if (num > 0) {
    let i = 1;
    do {
      saida += i + " ";
      i++;
    } while (i <= num);
  } else {
    let i = 0;
    do {
      saida += i + " ";
      i--;
    } while (i >= num);
  }
  document.getElementById("saidaTesteDOWHILE").innerHTML = saida;
}

function testeDeRepeticaoFOREACH() {
  let entrada = document.getElementById("valorTesteFOREACH").value;

  // transforma a string em array, removendo espaços e convertendo para número
  let texto = entrada.split(",").map((n) => n.trim());

  let saida = "";

  texto.forEach((num, index) => {
    saida += `Posição ${index}: ${num} <br>`;
  });
  document.getElementById("saidaTesteFOREACH").innerHTML = saida;
}

function ex16() {
  let num = document.getElementById("valorEx16").value;
  let saida = "";
  for (let i = 1; i <= 10; i++) {
    saida += i + " * " + num + " = " + num * i + "<br>";
  }
  document.getElementById("saidaEx16").innerHTML = saida;
}

function ex17() {
  let num = Number(document.getElementById("valorEx17").value);
  let total = 0;
  let saida = "";
  for (let i = 1; i <= num; i++) {
    i == num ? (saida += i) : (saida += i + " + ");
    total += i;
  }
  document.getElementById("saidaEx17").innerHTML = saida + " = " + total;
}

function ex18() {
  let num = Number(document.getElementById("valorEx18").value);
  let saida = "";

  if (num > 0) {
    for (let i = 1; i <= num; i++) {
      i % 2 == 0 ? saida += i + " ": saida += "";
    }
  } else {
    for (let i = 0; i >= num; i--) {
      i % 2 == 0 ? saida += i + " ": saida += "";
    }
  }
  document.getElementById("saidaEx18").innerHTML = saida;
}

function ex19() {
  let num = Number(document.getElementById("valorEx19").value);
  let random = Math.floor(Math.random() * 101);
  let saida = ""
  while (num != random) {
    num > random ? saida = "Menor..." : saida = "Maior...";
    document.getElementById("saidaEx19").innerHTML = saida + " Tente novamente!";
  }
  document.getElementById("saidaEx19").innerHTML = "Acertou! (" + random + ")";
}

function ex20() {
  let num = Number(document.getElementById("valorEx20").value);
  let saida = "";
  
  while (num > 0) {
    num % 10 == 0 ? saida += num + "<br>" : saida += num + " - ";
    num--;
  }
  document.getElementById("saidaEx20").innerHTML = saida + " 0";
}

function ex21() {
  let num = document.getElementById("valorEx21").value;
  let vetor = Array.from(num);
  let soma = 0;
  let saida = "";

  for (let i = 0; i < vetor.length; i++) {
    let digito = parseInt(vetor[i]);
    soma += digito;
    saida += vetor[i];
    if (i < vetor.length - 1) {
      saida += " + ";
    }
  }
  document.getElementById("saidaEx21").innerHTML = saida + " = " + soma;
}


function ex22() {
  let num = Number(document.getElementById("valorEx22").value);
  let total = 1;
  let saida = "";
  for (let i = 1; i <= num; i++) {
    i == num ? (saida += i) : (saida += i + " * ");
    total *= i;
  }
  document.getElementById("saidaEx22").innerHTML = saida + " = " + total;
}

function ex23() {
  let texto = document.getElementById("valorEx23").value
  let invert = Array.from(texto);
  let saida = "";
  for (let i = invert.length - 1; i >= 0; i--){
    saida += invert[i];
  }
  document.getElementById("saidaEx23").innerHTML = texto + " = " + saida;
}

function ex24() {

}
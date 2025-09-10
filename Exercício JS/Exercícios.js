// Função para exibir exercício na tela

// Ex1 - Verificar maioridade
function ex1() {
  let idade = Number(document.getElementById("valorEx1").value);
  if (idade > 0) {
    document.getElementById("saidaEx1").innerHTML =
      idade >= 18
        ? `Você tem ${idade} anos, logo você é maior de idade`
        : (document.getElementById(
            "saidaEx1"
          ).innerHTML = `Você tem ${idade} anos, logo você é menor de idade`);
  } else {
    document.getElementById("saidaEx1").innerHTML = `Valor inválido!`;
  }
}

// Ex2 - Positivo ou Negativo
function ex2() {
  let num = Number(document.getElementById("valorEx2").value);
  document.getElementById("saidaEx2").innerHTML =
    num > 0 ? `O número ${num} é positivo!` : `O número ${num} é negativo!`;
}

// Ex3 - Aprovação em prova
function ex3() {
  let nota = Number(document.getElementById("valorEx3").value);
  if (nota >= 0 && nota <= 100) {
    document.getElementById("saidaEx3").innerHTML =
      nota >= 60
        ? `O aluno tirou ${nota}, então está aprovado!`
        : (document.getElementById(
            "saidaEx3"
          ).innerHTML = `O aluno tirou ${nota}, então está reprovado!`);
  } else {
    document.getElementById("saidaEx3").innerHTML = `Valor inválido!`;
  }
}

// Ex4 - Positivo, Negativo ou Zero
function ex4() {
  let num = Number(document.getElementById("valorEx4").value);
  if (num !== 0) {
    document.getElementById("saidaEx4").innerHTML =
      num > 0
        ? `O número ${num} é positivo!`
        : (document.getElementById(
            "saidaEx4"
          ).innerHTML = `O número ${num} é negativo!`);
  } else {
    document.getElementById("saidaEx4").innerHTML = `O número ${num} é zero!`;
  }
}

// Ex5 - Classificação de idade
function ex5() {
  let idade = Number(document.getElementById("valorEx5").value);
  if (idade > 0 && idade < 13) {
    document.getElementById("saidaEx5").innerHTML =
      idade === 1
        ? `Como você tem ${idade} ano, você é uma criança`
        : `Como você tem ${idade} anos, você é uma criança`;
  } else if (idade >= 13 && idade < 18) {
    document.getElementById(
      "saidaEx5"
    ).innerHTML = `Como você tem ${idade} anos, você é um adolescente`;
  } else if (idade >= 18) {
    document.getElementById(
      "saidaEx5"
    ).innerHTML = `Como você tem ${idade} anos, você é um adulto`;
  } else {
    document.getElementById("saidaEx5").innerHTML = `Valor inválido!`;
  }
}

// Ex6 - Par ou Ímpar
function ex6() {
  let num = Number(document.getElementById("valorEx6").value);
  document.getElementById("saidaEx6").innerHTML =
    num % 2 === 0
      ? `O valor ${num} é Par, divisível por 2`
      : `O valor ${num} é Ímpar, não divisível por 2`;
}

// Ex7 - Calculadora
function ex7soma() {
  let numX = Number(document.getElementById("valorEx7-1").value);
  let numY = Number(document.getElementById("valorEx7-2").value);
  document.getElementById(
    "saidaEx7"
  ).innerHTML = `${numX} + ${numY} = ${numX + numY}`;
}
function ex7sub() {
  let numX = Number(document.getElementById("valorEx7-1").value);
  let numY = Number(document.getElementById("valorEx7-2").value);
  document.getElementById(
    "saidaEx7"
  ).innerHTML = `${numX} - ${numY} = ${numX - numY}`;
}
function ex7mult() {
  let numX = Number(document.getElementById("valorEx7-1").value);
  let numY = Number(document.getElementById("valorEx7-2").value);
  document.getElementById(
    "saidaEx7"
  ).innerHTML = `${numX} * ${numY} = ${numX * numY}`;
}
function ex7div() {
  let numX = Number(document.getElementById("valorEx7-1").value);
  let numY = Number(document.getElementById("valorEx7-2").value);
  document.getElementById(
    "saidaEx7"
  ).innerHTML = `${numX} / ${numY} = ${numX / numY}`;
}

// Ex8 - Maior Número
function ex8() {
  let valorA = Number(document.getElementById("valorEx8-1").value);
  let valorB = Number(document.getElementById("valorEx8-2").value);
  let valorC = Number(document.getElementById("valorEx8-3").value);
  if (valorA === valorB && valorB === valorC) {
    document.getElementById(
      "saidaEx8"
    ).innerHTML = `Todos os valores são iguais (${valorA})`;
  } else if (valorA > valorB && valorA > valorC) {
    document.getElementById(
      "saidaEx8"
    ).innerHTML = `O valor de A é o maior ( ${valorA})`;
  } else if (valorB > valorA && valorB > valorC) {
    document.getElementById(
      "saidaEx8"
    ).innerHTML = `O valor de B é o maior (${valorB})`;
  } else if (valorA === valorB && valorA > valorC) {
    document.getElementById(
      "saidaEx8"
    ).innerHTML = `O valor de A e B são os maiores (${valorA})`;
  } else if (valorA === valorC && valorA > valorB) {
    document.getElementById(
      "saidaEx8"
    ).innerHTML = `O valor de A e C são os maiores (${valorA})`;
  } else if (valorB === valorC && valorB > valorA) {
    document.getElementById(
      "saidaEx8"
    ).innerHTML = `O valor de B e C são os maiores (${valorB})`;
  } else {
    document.getElementById(
      "saidaEx8"
    ).innerHTML = `O valor de C é o maior (${valorC})`;
  }
}

// Ex9 - Desconto
function ex9() {
  let valor = Number(document.getElementById("valorEx9").value);
  if (valor > 0) {
    document.getElementById("saidaEx9").innerHTML =
      valor > 100
        ? `Desconto de 10% (R$${valor * 0.1}), o produto sai por R$${
            valor * 0.9
          }`
        : (document.getElementById(
            "saidaEx9"
          ).innerHTML = `Sem desconto, o produto sai por R$${valor}`);
  } else {
    document.getElementById("saidaEx9").innerHTML = `Valor inválido!`;
  }
}

// Ex10 - Login
function ex10() {
  let user = document.getElementById("valorEx10-1").value;
  let senha = document.getElementById("valorEx10-2").value;
  document.getElementById("saidaEx10").innerHTML =
    user == "admin" && senha == "1234"
      ? `Login feito com sucesso!`
      : `Usuário ou senha errados! Tente novamente!`;
}

// Ex11 - Tipo de triângulo
function ex11() {
  let ladoA = Number(document.getElementById("valorEx11-1").value);
  let ladoB = Number(document.getElementById("valorEx11-2").value);
  let ladoC = Number(document.getElementById("valorEx11-3").value);
  if (ladoA <= 0 || ladoB <= 0 || ladoC <= 0) {
    document.getElementById("saidaEx11").innerHTML = `Valor inválido`;
  } else if (ladoA == ladoB && ladoA == ladoC) {
    document.getElementById("saidaEx11").innerHTML = `Triângulo Equilátero`;
  } else if (
    (ladoA == ladoB && ladoA != ladoC) ||
    (ladoA != ladoB && ladoA == ladoC) ||
    (ladoB != ladoA && ladoB == ladoC)
  ) {
    document.getElementById("saidaEx11").innerHTML = `Triângulo Isósceles`;
  } else {
    document.getElementById("saidaEx11").innerHTML = `Triângulo Escaleno`;
  }
}

// Ex12 - Nota
function ex12() {
  let nota = Number(document.getElementById("valorEx12").value);
  if (nota >= 90 && nota <= 100) {
    document.getElementById(
      "saidaEx12"
    ).innerHTML = `Você tirou ${nota}, ficou com A na média`;
  } else if (nota >= 80 && nota < 90) {
    document.getElementById(
      "saidaEx12"
    ).innerHTML = `Você tirou ${nota}, ficou com B na média`;
  } else if (nota >= 70 && nota < 80) {
    document.getElementById(
      "saidaEx12"
    ).innerHTML = `Você tirou ${nota}, ficou com C na média`;
  } else if (nota >= 60 && nota < 70) {
    document.getElementById(
      "saidaEx12"
    ).innerHTML = `Você tirou ${nota}, ficou com D na média`;
  } else if (nota >= 0 && nota < 60) {
    document.getElementById(
      "saidaEx12"
    ).innerHTML = `Você tirou ${nota}, ficou com F na média`;
  } else {
    document.getElementById("saidaEx12").innerHTML = `Valor inválido!`;
  }
}

// Ex13 - IMC
function ex13() {
  let altura = Number(document.getElementById("valorEx13-1").value);
  let peso = Number(document.getElementById("valorEx13-2").value);
  const IMC = peso / (altura * altura);
  if (altura <= 0 || peso <= 0) {
    document.getElementById("saidaEx13").innerHTML = `Valor inválido`;
  } else if (IMC < 18.5) {
    document.getElementById(
      "saidaEx13"
    ).innerHTML = `IMC: ${IMC} - Abaixo do peso`;
  } else if (IMC >= 18.5 && IMC < 25.0) {
    document.getElementById("saidaEx13").innerHTML = `IMC: ${IMC} - Normal`;
  } else if (IMC >= 25.0 && IMC < 30.0) {
    document.getElementById("saidaEx13").innerHTML = `IMC: ${IMC} - Sobrepeso`;
  } else {
    document.getElementById("saidaEx13").innerHTML = `IMC: ${IMC} - Obesidade`;
  }
}

// Ex14 - Ano Bissexto
function ex14() {
  let ano = Number(document.getElementById("valorEx14").value);
  let bissexto = ano % 400 === 0 || (ano % 4 === 0 && ano % 100 !== 0);
  if (ano >= 0) {
    document.getElementById("saidaEx14").innerHTML = bissexto
      ? `É bissexto`
      : `Não é bissexto`;
  } else {
    document.getElementById("saidaEx14").innerHTML = `Valor inválido!`;
  }
}

// Repetição com FOR (Ex15)
function testeFOR() {
  let num = Number(document.getElementById("valorFOR").value);
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
  document.getElementById("saidaFOR").innerHTML = saida;
}

// Repetição com WHILE
function testeWHILE() {
  let num = Number(document.getElementById("valorWHILE").value);
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
  document.getElementById("saidaWHILE").innerHTML = saida;
}

// Repetição com DO WHILE
function testeDOWHILE() {
  let num = Number(document.getElementById("valorDOWHILE").value);
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
  document.getElementById("saidaDOWHILE").innerHTML = saida;
}

// Repetição com FOR EACH
function testeFOREACH() {
  let entrada = document.getElementById("valorFOREACH").value;
  let vetor = Array.from(entrada.split(" "));
  let saida = "";
  vetor.forEach((num, index) => {
    saida += `Posição ${index}: ${num} <br>`;
  });
  document.getElementById("saidaFOREACH").innerHTML = saida;
}

// Ex16 - Tabuada de 10
function ex16() {
  let num = document.getElementById("valorEx16").value;
  let saida = "";
  for (let i = 1; i <= 10; i++) {
    saida += i + " * " + num + " = " + num * i + "<br>";
  }
  document.getElementById("saidaEx16").innerHTML = saida;
}

// Ex17 - Soma de números naturais
function ex17() {
  let num = Number(document.getElementById("valorEx17").value);
  let total = 0;
  let saida = "";
  for (let i = 1; i <= num; i++) {
    i == num ? (saida += i) : (saida += i + " + ");
    total += i;
  }
  document.getElementById("saidaEx17").innerHTML = `${saida} = ${total}`;
}

// Ex18 - Números pares
function ex18() {
  let num = Number(document.getElementById("valorEx18").value);
  let saida = "";
  if (num > 0) {
    for (let i = 1; i <= num; i++) {
      i % 2 === 0 ? (saida += i + " ") : (saida += "");
    }
  } else {
    for (let i = 0; i >= num; i--) {
      i % 2 === 0 ? (saida += i + " ") : (saida += "");
    }
  }
  document.getElementById("saidaEx18").innerHTML = saida;
}

// Ex19 - Adivinha
let random = Math.floor(Math.random() * 101);
function ex19() {
  let num = Number(document.getElementById("valorEx19").value);
  if (num === random) {
    document.getElementById("saidaEx19").innerHTML = `🎉 Acertou! (${random})`;
  } else if (num > random && num <= 100) {
    document.getElementById(
      "saidaEx19"
    ).innerHTML = `Menor... tente novamente! (${random})`;
  } else if (num < random && num >= 0) {
    document.getElementById(
      "saidaEx19"
    ).innerHTML = `Maior... tente novamente! (${random})`;
  } else {
    document.getElementById("saidaEx19").innerHTML = `Valor inválido!`;
  }
}

// Ex20 - Contagem Regressiva
function ex20() {
  let num = Number(document.getElementById("valorEx20").value);
  let saida = "";
  if (num > 0) {
    while (num > 0) {
      num % 10 === 0 ? (saida += num + "<br>") : (saida += num + " - ");
      num--;
    }
    document.getElementById("saidaEx20").innerHTML = `${saida} 0`;
  }
}

// Ex21 - Soma dos dígitos
function ex21() {
  let num = Number(document.getElementById("valorEx21").value);
  let soma = 0;
  let saida = "";
  if (num >= 0) {
    if (num == 0) {
      document.getElementById("saidaEx21").innerHTML = `0 = ${soma}`;
    } else {
      let temp = num;
      while (temp > 0) {
        let digito = temp % 10;
        soma += digito;
        saida = saida === "" ? `${digito}` : `${digito} + ${saida}`;
        temp = Math.floor(temp / 10);
      }
      document.getElementById("saidaEx21").innerHTML = `${saida} = ${soma}`;
    }
  } else {
    document.getElementById("saidaEx21").innerHTML = `Valor inválido!`;
  }
}

// Ex22 - Fatorial
function ex22() {
  let num = Number(document.getElementById("valorEx22").value);
  let total = 1;
  let saida = "";
  for (let i = 1; i <= num; i++) {
    i == num ? (saida += i) : (saida += i + " * ");
    total *= i;
  }
  if (num > 0) {
    document.getElementById(
      "saidaEx22"
    ).innerHTML = `${num}! = ${saida} = ${total}`;
  } else if (num === 0) {
    document.getElementById("saidaEx22").innerHTML = `${num}! = ${total}`;
  } else {
    document.getElementById("saidaEx22").innerHTML = `Valor inválido!`;
  }
}

// Ex23 - Inversão
function ex23() {
  let num = document.getElementById("valorEx23").value;
  let flag_neg = false;
  if(num < 0) {
    num *= -1;
    flag_neg = true;
  }
  let num_invertido = 0;
  let num_original = num;
  if (num >= 0) {
    while (num > 0) {
      let unidade = num % 10;
      num_invertido = unidade + num_invertido * 10;
      num = (num - unidade) / 10;
    }
  }
  document.getElementById("saidaEx23").innerHTML = flag_neg ? `${num_original * -1} = ${num_invertido * -1}` : `${num_original} = ${num_invertido}`;
}

// Ex24 - Números perfeitos
function ex24() {
  let num = Number(document.getElementById("valorEx24").value);
  let saida = "";
  let soma = 0;
  if (num <= 1) {
    document.getElementById("saidaEx24").innerHTML = `Valor inválido!`;
  } else {
    for (let i = 1; i <= num / 2; i++) {
      if (num % i == 0) {
        soma += i;
        saida += saida === "" ? `${i}` : `, ${i}`;
      }
    }
    document.getElementById("saidaEx24").innerHTML =
      soma === num
        ? `${num} é um número perfeito (${saida}, ${num})`
        : `${num} não é um número perfeito`;
  }
}

// Teste do Filter
function testeFilterMaiorQue() {
  let entrada = Array.from(
    document.getElementById("valorFilter").value.split(" ")
  );
  let info = document.getElementById("valorFilterInfo").value;
  let saida = entrada.filter((maiorQue) => maiorQue > info);
  document.getElementById("saidaFilter").innerHTML = saida;
}
function testeFilterMaisQue() {
  let entrada = Array.from(
    document.getElementById("valorFilter").value.split(" ")
  );
  let info = document.getElementById("valorFilterInfo").value;
  let saida = entrada.filter((maisQue) => maisQue.length > info);
  document.getElementById("saidaFilter").innerHTML = saida;
}
function testeFilterComecaCom() {
  let entrada = Array.from(
    document.getElementById("valorFilter").value.split(" ")
  );
  let info = document.getElementById("valorFilterInfo").value;
  let saida = entrada.filter((comecaCom) => comecaCom.startsWith(info));
  document.getElementById("saidaFilter").innerHTML = saida;
}

// Teste do Find
function testeFindComecaCom() {
  let entrada = Array.from(
    document.getElementById("valorFind").value.split(" ")
  );
  let info = document.getElementById("valorFindInfo").value;
  let saida = entrada.find((comecaCom) => comecaCom.startsWith(info));
  document.getElementById("saidaFind").innerHTML = saida;
}
function testeFindImpar() {
  let entrada = Array.from(
    document.getElementById("valorFind").value.split(" ")
  );
  let saida = entrada.find((comecaCom) => comecaCom % 2 === 1);
  document.getElementById("saidaFind").innerHTML = saida;
}
function testeFindNota() {
  let entrada = Array.from(
    document.getElementById("valorFind").value.split(" ")
  );
  let info = document.getElementById("valorFindInfo").value;
  let saida = entrada.find((comecaCom) => comecaCom >= info);
  document.getElementById("saidaFind").innerHTML = saida;
}

// Teste do Map 1
function testeMapNome() {
  let nomes = document.getElementById("valorMapNome").value.split(" ");
  let saida = nomes.map((nome) => `Nome: ${nome}`);
  document.getElementById("saidaMap1").innerHTML = saida.join("<br>");
}
function testeMapIdade() {
  let idades = document.getElementById("valorMapIdade").value.split(" ");
  let saida = idades.map((idade) => `Idade: ${idade}`);
  document.getElementById("saidaMap1").innerHTML = saida.join("<br>");
}
function testeMapAll() {
  let nomes = document.getElementById("valorMapNome").value.split(" ");
  let idades = document.getElementById("valorMapIdade").value.split(" ");
  let pessoas = nomes.map((nome, index) => ({
    nome: nome,
    idade: idades[index],
  }));
  let saida = pessoas.map(
    (pessoa) => `${pessoa.nome} tem ${pessoa.idade} anos`
  );
  document.getElementById("saidaMap1").innerHTML = saida.join("<br>");
}

// Teste do Map 2
function testeMapFahrenheit() {
  let celsius = document.getElementById("valorMap").value.split(" ");
  let saida = celsius.map((fahrenheit) => `Fº: ${fahrenheit * 1.8 + 32}`);
  document.getElementById("saidaMap2").innerHTML = saida;
}
function testeMapProduto() {
  let produto = document.getElementById("valorMap").value.split(" ");
  let saida = produto.map((produto) => `Produto: ${produto.toUpperCase()}`);
  document.getElementById("saidaMap2").innerHTML = saida;
}
function testeMapPotencia() {
  let valor = document.getElementById("valorMap").value.split(" ");
  let saida = valor.map((num) => `${num}² = ${num * num}`);
  document.getElementById("saidaMap2").innerHTML = saida;
}

// Teste do Reduce
function testeReduce() {
  let palavras = document.getElementById("valorReduce").value.split(" ");
  const contagem = palavras.reduce((acumulador, palavra) => {
    acumulador[palavra] = (acumulador[palavra] || 0) + 1;
    return acumulador;
  }, {});
  let saida = Object.entries(contagem).map(
    ([valor, qtd]) => `${valor}: ${qtd}`
  );
  document.getElementById("saidaReduce").innerHTML = saida.join("<br>");
}
function testeReduceTotal() {
  let valores = document
    .getElementById("valorReduce")
    .value.split(" ")
    .map(Number);
  const total = valores.reduce((acumulador, valor) => acumulador + valor, 0);
  document.getElementById("saidaReduce").innerHTML = `Total: ${total}`;
}
function testeReduceFrase() {
  let palavras = document.getElementById("valorReduce").value.split(" ");
  const frase = palavras.reduce((acc, palavra) => acc + " " + palavra);
  document.getElementById("saidaReduce").innerHTML = frase;
}
function testeReduceMedia() {
  let valores = document
    .getElementById("valorReduce")
    .value.split(" ")
    .map(Number);
  const total =
    valores.reduce((acumulador, valor) => acumulador + valor, 0) /
    valores.length;
  document.getElementById("saidaReduce").innerHTML = `Média: ${total}`;
}

// Desafio 1
function desafioMaiorQue() {
  let entrada = document.getElementById("valorDesafio1Info").value.split(",");
  let saida = entrada.find((maiorQue) => maiorQue > 200);
  document.getElementById("saidaDesafio1").innerHTML = saida;
}
function desafioTitulos() {
  let nomes = document.getElementById("valorDesafio1").value.split(",");
  let saida = nomes.map((nome) => `Título: ${nome}`);
  document.getElementById("saidaDesafio1").innerHTML = saida.join("<br>");
}
function desafioTotal() {
  let valores = document
    .getElementById("valorDesafio1Info")
    .value.split(",")
    .map(Number);
  const total = valores.reduce((acumulador, valor) => acumulador + valor, 0);
  document.getElementById("saidaDesafio1").innerHTML = `Total: ${total}`;
}

// Desafio 2
function desafioLista() {
  let produto = document.getElementById("valorDesafio2").value.split(",");
  let valores = document.getElementById("valorDesafio2Info").value.split(",");
  let produtos = produto.map((produtoInfo, index) => ({
    produto: produtoInfo,
    valor: valores[index],
  }));
  let saida = produtos.map(
    (produtoInfo) => `Produto: ${produtoInfo.produto} - R$ ${produtoInfo.valor}`
  );
  document.getElementById("saidaDesafio2").innerHTML = saida.join("<br>");
}
function desafioValorCompra() {
  let valores = document
    .getElementById("valorDesafio2Info")
    .value.split(",")
    .map(Number);
  const total = valores.reduce((acumulador, valor) => acumulador + valor, 0);
  document.getElementById("saidaDesafio2").innerHTML = `Total: ${total}`;
}
function desafioProduto() {
  let produto = document.getElementById("valorDesafio2").value.split(",");
  let encontrar = document.getElementById("valorDesafio2Info").value.split(",");
  let saida = produto.find((encontrarProduto) => encontrarProduto == encontrar);
  document.getElementById("saidaDesafio2").innerHTML =
    saida == encontrar ? `Encontrado: ${saida}` : `Não encontrado`;
}
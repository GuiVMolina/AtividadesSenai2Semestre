// Variável para armazenar o título
const elForm = document.getElementById("form-tarefa");

// Variável para armazenar o título da tarefa (input)
const elTitulo = document.querySelector("#titulo");

// Variável para armazenar o filtro de status
const elFiltroStatus = document.querySelector("#filtro-status");

// Variável para armazenar o filtro de busca
const elFiltroBusca = document.querySelector("#filtro-busca");

// Variável para armazenar a lista
const elLista = document.querySelector("#lista-tarefas");

// Variável para armazenar o texto que aparece quando a lista está vazia
const elVazio = document.querySelector("#vazio");

// Lista de tarefas iniciais
let tarefas = [
  { id: 1, titulo: "Estudar DOM", status: "pendente" },
  { id: 2, titulo: "Criar To-Do List", status: "andamento" },
  { id: 3, titulo: "Praticar JavaScript", status: "concluida" },
];

// Adiciona um "ouvinte" para o evento de submit do formulário
elForm.addEventListener("submit", function (e) {
  // Letra "e" na função: é uma referencia ao objeto de evento
  // que o navegador cria sempre que algo acontece

  // Impede o comportamento padrão do formulário (recarregar a página)
  e.preventDefault();

  // Pega o valor (value) digitado no input (elTitulo), removendo espaços
  const titulo = elTitulo.value.trim();

  // Se o título estiver vazio, encerra a função aqui
  if (!titulo) return;

  // Cria um objeto representando uma nova tarefa
  // - id: recebe o número do timestamp atual
  // - titulo: recebe o texto digitado pelo usuário
  // - status: começa sempre como "pendente"
  const nova = { id: Date.now(), titulo: titulo, status: "pendente" };

  // Adiciona a nova tarefa dentro do array de tarefas
  tarefas.push(nova);

  // Limpa o campo de texto do input
  elTitulo.value = "";

  // Chama a função render() para atualizar a lista de tarefas exibida na tela
  render();
});

// Renderizar lista
function render() {
  // Termo digitado na busca - deixar em minúsculo
  const termo = elFiltroBusca.value.toLowerCase();

  // Valor selecionado no filtro de status
  const filtro = elFiltroStatus.value;

  // Aplica filtros de status e de busca
  const filtradas = tarefas.filter(function (t) {
    // Se filtro for "todas", aceita qualquer status
    // Senão - compara com t.status
    const okStatus = filtro === "todas" ? true : t.status === filtro;

    // Se houver um termo, verifica se o título contém esse termo
    // Se o usuário digital algo, só aceita a tarefa se for igual
    // ao que o usuário digitou
    // Se o usuário não digitar nada, retorna a lista completa (true)
    const okBusca = termo ? t.titulo.toLowerCase().includes(termo) : true;

    return okStatus && okBusca;
  });
  // Limpar a lista antes de redesenhar
  elLista.innerHTML = "";

  // Cria os elementos da lista para cada tarefa filtrada
  filtradas.forEach(function (t) {
    // <li class="tarefa {status}" data-id={id}></li>
    const li = document.createElement("li");
    // Class = "tarefa concluida"
    li.className = "tarefa " + t.status;
    li.dataset.id = t.id;

    const h3 = document.createElement("h3");
    // <h3> Aula JavasScript </h3>
    h3.textContent = t.titulo;

    // Caixa de ações (checkxob, select, botão remover)
    const acoes = document.createElement("div");
    acoes.className = "acao";

    // checkbox: Marcar e concluir pendente
    const check = document.createElement("input");
    check.type = "checkbox";
    check.checked = t.status === "concluida"; // Cuidado com acento

    // Ao mudar o check, redesenha na tela
    check.addEventListener("change", function () {
      t.status = check.checked ? "concluida" : "pendente";
      render();
    });

    // select de status: pendente / concluida / andamento
    const select = document.createElement("select");
    const listaSelect = ["pendente", "andamento", "concluida"];

    listaSelect.forEach(function (status) {
      const option = document.createElement('option');
      option.value = status;

      // Capitaliza (deixa em maiúsculo) a primeira letra de cada palavra
      option.textContent = status.charAt(0).toUpperCase() + status.slice(1);

      if(t.status === status) option.selected = true;
      select.appendChild(option);
    });

    // Ao mudar o select, atualiza e redesenha na tela
    select.addEventListener('change', function() {
      t.status = select.value;
      render();
    })

    // Botão remover
    const botao = document.createElement('button');
    botao.textContent = "X";
    botao.className = "remover";

    // Recebe o evento de click e filtra uma nova lista
    botao.addEventListener('click', function() {
      tarefas = tarefas.filter(apagar => apagar.id !== t.id);
      render();
    });

    // Adicionando os filhos da 'div acoes'
    acoes.appendChild(check);
    acoes.appendChild(select);
    acoes.appendChild(botao);

    // Adicionando os filhos do 'li'
    li.appendChild(h3);
    li.appendChild(acoes);

    // Adicionando os filhos do 'ul' (#id: lista-tarefas - variável elLista)
    elLista.appendChild(li);
  });

  // Texto aparece somente se o Array de filtradas existir algo
  // Caso contrário, exibe 'display: none' (some da tela)
  elVazio.style.display = filtradas.length ? "none" : "block";
}

// Filtra quando o usuário mudar a opção de filtro por status
elFiltroStatus.addEventListener('change', render);

// Filtra quando o usuário digitar algo no campo de busca
elFiltroBusca.addEventListener('input', render);

// Primeira renderização / atualização de informações
render();
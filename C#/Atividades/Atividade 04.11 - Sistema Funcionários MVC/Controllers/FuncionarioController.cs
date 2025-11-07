using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Atividade_04._11___Sistema_Funcionários_MVC.Data;
using Atividade_04._11___Sistema_Funcionários_MVC.Models;

namespace Atividade_04._11___Sistema_Funcionários_MVC.Controllers
{
    public class FuncionarioController : Controller
    {
        private readonly AppDbContext _context;

        public FuncionarioController(AppDbContext contextConstrutor)
        {
            _context = contextConstrutor;
        }

        // LISTAR
        // async / await = Executa a função de listar dentro do banco de forma assíncrona
        // (Permite o sistema rodar sem travar enquanto espera o banco responder)
        public async Task<IActionResult> Index()
        {
            // ToListAsync() = Converte os dados da tabela em uma lista
            var funcionarios = await _context.TabelaFuncionario.ToListAsync();
            return View(funcionarios);
        }
      

        // Formulário de criação - Retorna a lista de formulário vazio
        // GET - Listar (Próximo do SELECT do SQL)
        [HttpGet]
        public IActionResult Criar() => View();

        // Cadastrar as informações do formulário no banco de dados
        [HttpPost]
        public async Task<IActionResult> Criar(string nomeConstrutor, double salarioBaseConstrutor, string cargoConstrutor)
        {
            Funcionario? novoFuncionario = null;

            if (cargoConstrutor == "Gerente")
            {
                novoFuncionario = new Gerente(nomeConstrutor, salarioBaseConstrutor);
            }
            else if (cargoConstrutor == "Vendedor")
            {
                novoFuncionario = new Vendedor(nomeConstrutor, salarioBaseConstrutor);
            }
            else
            {
                return BadRequest("Cargo inválido.");
            }

            _context.TabelaFuncionario.Add(novoFuncionario);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        // Excluir
        public async Task<IActionResult> Deletar(int id)
        {
            // Variável que vai armazenar o registro de funcionário encontrado pelo ID
            // FindAsync(id) = Busca o registro pelo ID
            var funcionario = await _context.TabelaFuncionario.FindAsync(id);

            // Se não encontrar o funcionário, retorna erro 404 (NotFound)
            // Remove() = Remove o registro da tabela
            if (funcionario == null) return NotFound();
            _context.TabelaFuncionario.Remove(funcionario);

            // Salva as alterações no banco de dados
            await _context.SaveChangesAsync();

            // Retorna para a Action: Index (Lista de funcionários)
            return RedirectToAction("Index");
        }
    }
}
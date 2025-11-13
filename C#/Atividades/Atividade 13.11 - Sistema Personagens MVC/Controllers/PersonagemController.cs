using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Atividade_13._11___Sistema_Personagens_MVC.Data;
using Atividade_13._11___Sistema_Personagens_MVC.Models;

namespace Atividade_13._11___Sistema_Personagens_MVC.Controllers
{
    public class PersonagemController : Controller
    {
        private readonly AppDbContext _context;

        public PersonagemController(AppDbContext contextConstrutor)
        {
            _context = contextConstrutor;
        }
        public async Task<IActionResult> Index()
        {
            var lista = await _context.TabelaPersonagem.ToListAsync();
            return View(lista);
        }
        [HttpGet]
        public IActionResult Criar() => View();

        [HttpPost]
        public async Task<IActionResult> Criar(string nomeConstrutor, int nivelConstrutor, string classeConstrutor)
        {
            Personagem? novoPersonagem = null;

            if (classeConstrutor == "Guerreiro")
            {
                novoPersonagem = new Guerreiro(nomeConstrutor, nivelConstrutor);
            }
            else if (classeConstrutor == "Mago")
            {
                novoPersonagem = new Mago(nomeConstrutor, nivelConstrutor);
            }
            else
            {
                return BadRequest("Personagem inválido.");
            }

            _context.TabelaPersonagem.Add(novoPersonagem);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        // Excluir
        public async Task<IActionResult> Deletar(int id)
        {
            var Personagem = await _context.TabelaPersonagem.FindAsync(id);
            if (Personagem == null) return NotFound();
            _context.TabelaPersonagem.Remove(Personagem);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
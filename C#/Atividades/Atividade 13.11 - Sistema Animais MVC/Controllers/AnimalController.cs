using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Atividade_13._11___Sistema_Animais_MVC.Data;
using Atividade_13._11___Sistema_Animais_MVC.Models;

namespace Atividade_13._11___Sistema_Animais_MVC.Controllers
{
    public class AnimalController : Controller
    {
        private readonly AppDbContext _context;

        public AnimalController(AppDbContext contextConstrutor)
        {
            _context = contextConstrutor;
        }
        public async Task<IActionResult> Index()
        {
            var lista = await _context.TabelaAnimal.ToListAsync();
            return View(lista);
        }
        [HttpGet]
        public IActionResult Criar() => View();

        [HttpPost]
        public async Task<IActionResult> Criar(string nomeConstrutor, string classeConstrutor)
        {
            Animal? novoAnimal = null;

            if (classeConstrutor == "Leao")
            {
                novoAnimal = new Leao(nomeConstrutor);
            }
            else if (classeConstrutor == "Elefante")
            {
                novoAnimal = new Elefante(nomeConstrutor);
            }
            else
            {
                return BadRequest("Animal inválido.");
            }

            _context.TabelaAnimal.Add(novoAnimal);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        // Excluir
        public async Task<IActionResult> Deletar(int id)
        {
            var Animal = await _context.TabelaAnimal.FindAsync(id);
            if (Animal == null) return NotFound();
            _context.TabelaAnimal.Remove(Animal);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
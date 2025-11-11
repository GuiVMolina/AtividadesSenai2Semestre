using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Atividade_10._11___Sistema_Veiculos_MVC.Data;
using Atividade_10._11___Sistema_Veiculos_MVC.Models;

namespace Atividade_10._11___Sistema_Veiculos_MVC.Controllers
{
    public class VeiculoController : Controller
    {
        private readonly AppDbContext _context;

        public VeiculoController(AppDbContext contextConstrutor)
        {
            _context = contextConstrutor;
        }
        public async Task<IActionResult> Index()
        {
            var veiculos = await _context.TabelaVeiculo.ToListAsync();
            return View(veiculos);
        }

        [HttpGet]
        public IActionResult Criar() => View();

        [HttpPost]
        public async Task<IActionResult> Criar(string modeloConstrutor, string nomeConstrutor, int anoConstrutor, double precoConstrutor)
        {
            Veiculo? novoVeiculo = null;

            if (modeloConstrutor == "Carro")
            {
                novoVeiculo = new Carro(modeloConstrutor, nomeConstrutor, anoConstrutor, precoConstrutor);
            }
            else if (modeloConstrutor == "Moto")
            {
                novoVeiculo = new Moto(modeloConstrutor, nomeConstrutor, anoConstrutor, precoConstrutor);
            }
            else
            {
                return BadRequest("Modelo inválido.");
            }

            _context.TabelaVeiculo.Add(novoVeiculo);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Deletar(int id)
        {
            var veiculo = await _context.TabelaVeiculo.FindAsync(id);
            if (veiculo == null) return NotFound();
            _context.TabelaVeiculo.Remove(veiculo);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
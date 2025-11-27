using AurumLab.Data;
using AurumLab.Models;
using Microsoft.AspNetCore.Mvc;
using Sistema_Login.Services;

namespace AurumLab
{
    public class CadastroController : Controller
    {
        private readonly AppDbContext _context;

        public CadastroController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(string nome, string email, string senha, string confirmar)
        {
            if (string.IsNullOrWhiteSpace(nome) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(senha) ||
                string.IsNullOrWhiteSpace(confirmar))
            {
                ViewBag.Erro = "Preencha todos os campos.";
                return View("Index");
            }

            if (senha != confirmar)
            {
                ViewBag.Erro = "As senhas não conferem.";
                return View("Index");
            }

            // Verifica se o email já está cadastrado
            // Any() é parecido com o FirstOrDefault()
            //* Diferença:
            // FirstOrDefault() traz o objeto por completo - ex: nome, foto
            // Any() serve só para validar se existe ou não
            if (_context.Usuarios.Any(usuario => usuario.Email == email))
            {
                // Auxiliar usuario percorre os usuarios, procurando pelo email
                // até encontrar o email igual ao digitado no input
                ViewBag.Erro = "Email já cadastrado.";
                return View("Index");
            }

            byte[] hash = HashService.GerarHashBytes(senha);

            Usuario usuario = new Usuario
            {
                NomeCompleto = nome,
                Email = email,
                Senha = hash,
                Foto = null,
                RegraId = 1 // Aluno padrão
            };

            // Salvar no banco
            // Add é igual ao INSERT
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();

            // Redireciona para o login
            return RedirectToAction("Index", "Login");
        }
    }
}
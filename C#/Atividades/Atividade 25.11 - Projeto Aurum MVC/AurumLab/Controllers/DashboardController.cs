using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AurumLab.Data;
using AurumLab.Models;
using Microsoft.AspNetCore.Mvc;

namespace AurumLab.Controllers
{
    public class DashboardController : Controller
    {
        private readonly AppDbContext _context;

        public DashboardController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Dashboard()
        {
            // Valida se existe login realizado
            if (HttpContext.Session.GetInt32("UsuarioId") == null)
            {
                return RedirectToAction("Index", "Login");
            }

            var usuarioId = HttpContext.Session.GetInt32("UsuarioId");

            var usuario = _context.Usuarios.FirstOrDefault(usuario => usuario.IdUsuario == usuarioId);

            // TIPOS DISPOSITIVO - JOIN + AGRUPAMENTO
            // Consultar a tabela Dispositivos através da ViewModel

            // SELECT * FROM Dispositivos
            var dispositivosPorTipo = _context.Dispositivos
            .Join(
                _context.TipoDispositivos,                    // JOIN TiposDispositivos
                dispositivo => dispositivo.IdTipoDispositivo, // ON dispositivo.IdTipoDispositivo
                tipoDispositivo => tipoDispositivo.IdTipoDispositivo, // = tipoDispositivo.IdTipoDispositivo
                (dispositivo, tipoDispositivo) => new { dispositivo, tipoDispositivo.Nome } // SELECT

                // SELECT * FROM Dispositivos D
                // JOIN TiposDispositivo TD
                // ON D.IdTipoDispositivo = TD.IdTipoDispositivo

                // Para cada par encontrado - um dispositivo e
                // seu tipoDispositivo correspondente monta um objeto:
                // dispositivo = nome completo
                // nome = o nome do tipo do dispositivo
                // {
                //    dispositivo = {objeto Dispositivo inteiro},
                //    nome = "Sensor"
                // }
            )
            // Agrupa dispositivos pelo nome do tipo
            .GroupBy(
                dt => dt.Nome // Agrupa pelo Nome do TipoDispositivo
            )
            // Cria a lista de item agrupado para retornar somente
            // o nome e a quantidade
            .Select(
                grupo => new ItemAgrupado
                {
                    Nome = grupo.Key, // Nome do TipoDispositivo
                    Quantidade = grupo.Count()   // Quantidade de dispositivos daquele tipo
                }
            )
            // Executa a consulta no banco e transforma em lista
            .ToList();

            // Lista de locais
            var locais = _context.LocalDispositivos
                .OrderBy(local => local.Nome)
                .ToList();

            // VIEW MODEL
            // Cira a ViewModel com todas as informações que
            // a página precisa
            DashboardViewModel viewModel = new DashboardViewModel
            {
                // usuario?.NomeUsuario -> Se usuario não for null,
                // então pegue NomeUsuario (Nome que está no banco),
                // senão coloque "Usuário" como padrão
                NomeUsuario = usuario?.NomeUsuario ?? "Usuário",
                FotoUsuario = "/assets/img/img-perfil.png",

                TotalDispositivos = _context.Dispositivos.Count(),
                TotalAtivos = _context.Dispositivos.Count(d => d.SituacaoOperacional == "Operando"),
                TotalEmManutencao = _context.Dispositivos.Count(d => d.SituacaoOperacional == "Em manutenção"),
                TotalInoperantes = _context.Dispositivos.Count(d => d.SituacaoOperacional == "Inoperante"),

                DispositivosPorTipo = dispositivosPorTipo,
                Locais = locais
            };

            return View(viewModel);
        }
    }
}
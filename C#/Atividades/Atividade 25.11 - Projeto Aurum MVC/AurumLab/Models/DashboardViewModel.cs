using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AurumLab.Models;

namespace AurumLab.Models
{
    public class DashboardViewModel
    {
        public int TotalDispositivos { get; set; }

        public int TotalAtivos { get; set; }

        public int TotalEmManutencao { get; set; }

        public int TotalInoperantes { get; set; }

        // Usuário
        public string NomeUsuario { get; set; }

        public string FotoUsuario { get; set; }

        // Lista de Agrupamentos
        public List<ItemAgrupado> DispositivosPorTipo { get; set; }

        public List<LocalDispositivo> Locais { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_17._11___Sistema_Funcionários_DBFirst.Models
{
    public class Gerente : Funcionario
    {
        public Gerente() { }

        public Gerente(string nome, decimal salario) :
        base(nome, salario) { }
        
        public override decimal CalcularSalario() => SalarioBase * 1.5m;
    }
}
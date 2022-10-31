using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_Resolucao
{
    class CalcularImpostoArgentina : ICalcularImpostoPais
    {
        public decimal TotalRenda { get; set; }
        public decimal TotalDeducao { get; set; }

        public decimal Calcular()
        {
            decimal valorBase = TotalRenda - TotalDeducao;
            return valorBase * 40 / 100;
        }
    }
}

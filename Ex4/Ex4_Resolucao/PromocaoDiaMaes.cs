using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_Resolucao
{
    class PromocaoDiaMaes : IPromocao
    {
        public decimal TotalDesconto()
        {
            return 0.20M;
        }
    }
}

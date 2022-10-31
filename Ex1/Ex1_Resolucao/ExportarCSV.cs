using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Resolucao
{
    class ExportarCSV : ExportarDados<string, Cliente>
    {
        public string Exportar(List<Cliente> dados)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in dados)
            {
                sb.AppendFormat($"{item.Nome},{item.Pais},{item.Email}");
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}

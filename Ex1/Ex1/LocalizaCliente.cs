using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class LocalizaCliente
    {
        public static Cliente ProcuraPorPais(string pais)
        {
            var resultado = Cliente.GetClientes().Find(n => n.Pais == pais);
            return resultado;
        }
        public static Cliente ProcuraPorNome(string nome)
        {
            var resultado = Cliente.GetClientes().Find(n => n.Nome == nome);
            return resultado;
        }
        public static string ExportarCSV(List<Cliente> dados)
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

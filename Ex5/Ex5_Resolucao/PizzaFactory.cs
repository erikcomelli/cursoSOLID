using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_Resolucao
{
    public class PizzaFactory
    {
        public Pizza CriarPizza(string tipo)
        {
            Pizza pizza = null;
            if (tipo.Equals("mussarela"))
            {
                pizza = new PizzaMussarela("mussarela");
            }
            else if (tipo.Equals("calabresa"))
            {
                pizza = new PizzaCalabresa("calabresa");
            }
            return pizza;
        }
    }
}

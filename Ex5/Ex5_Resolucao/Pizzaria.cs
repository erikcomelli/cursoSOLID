using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_Resolucao
{
    class Pizzaria
    {
        private Pizza _pizza;
        PizzaFactory _factory;

        public Pizzaria(PizzaFactory factory)
        {
            _factory = factory;
        }

        public void CriarPizza(string tipo)
        {
            _pizza = _factory.CriarPizza(tipo);
            _pizza.AssarPizza();
            _pizza.DeliveryPizza();
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_Resolucao
{
    public class PizzaMussarela : Pizza
    {
        public PizzaMussarela(string nome) : base(nome) { }
        public override int AssarPizza()
        {
            var tempo = 25;
            Console.WriteLine($"Assando pizza de {Nome} por {tempo} minutos");
            return tempo;
        }
    }
}

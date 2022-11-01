namespace Ex5_Resolucao
{
    public abstract class Pizza
    {
        public string Nome { get; set; }

        public Pizza(string nome)
        {
            Nome = nome;
        }

        public abstract int AssarPizza();
        public void DeliveryPizza()
        {
            Console.WriteLine($"Entregar pizza de {Nome}");
        }
    }
}

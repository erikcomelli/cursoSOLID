namespace Ex3_Resolucao
{
    class CalcularImpostoBrasil : ICalcularImpostoPais
    {
        public decimal TotalRenda { get; set; }
        public decimal TotalDeducao { get; set; }

        public decimal Calcular()
        {
            decimal valorBase = TotalRenda - TotalDeducao;
            return valorBase * 20 / 100;
        }
    }
}

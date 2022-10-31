namespace Ex3_Resolucao
{
    public interface ICalcularImpostoPais
    {
        public decimal TotalRenda { get; set; }
        public decimal TotalDeducao { get; set; }
        public decimal Calcular();
    }
}

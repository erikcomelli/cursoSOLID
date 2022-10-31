namespace Ex3_Resolucao
{
    class CalcularImpostoPais
    {
        ICalcularImpostoPais _calcularImpostoPais;

        public CalcularImpostoPais(ICalcularImpostoPais calcularImpostoPais)
        {
            _calcularImpostoPais = calcularImpostoPais;
        }

        public decimal Calcular()
        {
            return _calcularImpostoPais.Calcular();
        }
    }
}

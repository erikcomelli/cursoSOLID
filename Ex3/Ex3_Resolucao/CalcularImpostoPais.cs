namespace Ex3_Resolucao
{
    class CalcularImposto
    {
        ICalcularImpostoPais _calcularImpostoPais;

        public CalcularImposto(ICalcularImpostoPais calcularImpostoPais)
        {
            _calcularImpostoPais = calcularImpostoPais;
        }

        public decimal Calcular()
        {
            return _calcularImpostoPais.Calcular();
        }
    }
}

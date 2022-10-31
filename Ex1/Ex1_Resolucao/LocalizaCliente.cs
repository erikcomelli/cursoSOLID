namespace Ex1_Resolucao
{
    class LocalizaCliente
    {
        public static Cliente ProcuraPorPais(string pais)
        {
            return Cliente.GetClientes().Find(n => n.Pais == pais);
        }

        public static Cliente ProcuraPorNome(string nome)
        {
            return Cliente.GetClientes().Find(n => n.Nome == nome);            
        }
    }
}

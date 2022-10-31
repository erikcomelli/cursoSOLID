namespace Ex2_Resolucao
{
    internal class FileLogger : ILogger
    {
        public void Registrar(string mensagem)
        {
            File.WriteAllText(@"C:\\Users\\erik.comelli\\logTexto.txt", mensagem);
        }
    }
}

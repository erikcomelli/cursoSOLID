namespace Ex1_Resolucao
{
    interface ExportarDados<T, TT>
    {
        public T Exportar(List<TT> dados);
    }
}

namespace Ex4_Resolucao
{
    internal class Produto
    {
        IPromocao _promocao;

        public Produto(IPromocao promocao)
        {
            _promocao = promocao;
        }

        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

        public decimal DescontoPromocao()
        {
            return _promocao.TotalDesconto();
        }

        public decimal PrecoVenda()
        {
            return Preco - (Preco * DescontoPromocao());
        }

    }
}

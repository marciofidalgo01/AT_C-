public class Produto
        {
            public string Nome;
            public int QuantidadeEmEstoque;
            public double PrecoUnitario;

            public Produto(string nome, int quantidadeEmEstoque, double precoUnitario)
            {
                Nome = nome;
                QuantidadeEmEstoque = quantidadeEmEstoque;
                PrecoUnitario = precoUnitario;
            }
}
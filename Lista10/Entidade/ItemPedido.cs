namespace Lista10.Entidade
{
    public class ItemPedido
    {
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public Produto Produto { get; set; }

        public ItemPedido()
        {
        }

        public ItemPedido(int quantidade, double preco, Produto produprodutoct)
        {
            Quantidade = quantidade;
            Preco = preco;
            Produto = produprodutoct;
        }

        public double SubTotal()
        {
            return Preco * Quantidade;
        }

        public override string ToString()
        {
            return Produto.Nome + ", $" + Preco.ToString("F2") + ", Qauntidade: " + Quantidade + ", Subtotal: $" + SubTotal().ToString("F2");
        }
    }
}
namespace Exercicio11.Entidades
{
    public class ProdutoImportado : Produto
    {
        public ProdutoImportado()
        {
        }

        public ProdutoImportado(string nome, double preco, double taxas) : base(nome, preco)
        {
            Taxas = taxas;
        }

        public double Total()
        {
            return Preco + Taxas;
        }

        public override string Etiqueta()
        {
            return Nome + " $ " + Total().ToString("F2") + " (Taxas: $ " + Taxas.ToString("F2") + ")";
        }
        public double Taxas { get; set; }
    }
}
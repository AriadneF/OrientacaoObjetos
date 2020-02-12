namespace Exercicio11.Entidades
{
    public class Produto
    {
        public Produto()
        {
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public virtual string Etiqueta()
        {
            return Nome + " $ " + Preco.ToString("F2");
        }
        public string Nome { get; set; }
        public double Preco { get; set; }
    }
}
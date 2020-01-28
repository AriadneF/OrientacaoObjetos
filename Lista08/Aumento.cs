namespace Lista08
{
    public class Aumento
    {
        public Aumento(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentoSalario(double porcentagem)
        {
            Salario = Salario + porcentagem / 100.00 ;
        }

        public override string ToString()
        {
            return Id + ", " + Nome + ", " + Salario;
        }

        public int Id;
        public string Nome;
        public double Salario;
    }
}
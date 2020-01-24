namespace Lista06
{
    public class Conta
    {
        public Conta(int numeroConta, string titular)
        {
            NumeroConta = numeroConta;
            Titular = titular;
        }

        public Conta(int numeroConta, string titular, double saldo) : this(numeroConta, titular)
        {
            Saldo = saldo;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public void Deposito(double quantia)
        {
            Saldo = Saldo + quantia;
        }

        public override string ToString()
        {
            return "Conta: " + NumeroConta + ", " + "Titular: " + Titular + ", " + "Saldo: R$ " + Saldo.ToString("F2");
        }

        public int NumeroConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }
    }
}
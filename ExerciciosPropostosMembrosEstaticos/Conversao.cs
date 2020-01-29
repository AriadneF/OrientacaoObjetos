namespace ExerciciosPropostosMembrosEstaticos
{
    public class Conversao
    {
        public static double IOF = 6.0;
        public static double Converte(double cotacao, double compra)
        {
            double total = compra * cotacao;
            return total + total * IOF / 100.0;
        }
    }
}
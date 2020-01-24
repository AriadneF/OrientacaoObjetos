using System;
using System.Collections.Generic;
using System.Text;

namespace Lista01
{
    class Class1
    {
        Console.Write("Digite o primeiro código: ");
            int produto = Convert.ToInt32(Console.ReadLine());

            while (produto != 4)
            {
                if (produto == 1)
                {
                    Console.WriteLine("Álcool");
                    Console.Write("Digite o proximo código: ");
                }
                if (produto == 2)
                {
                    Console.WriteLine("Gasolina");
                    Console.Write("Digite o proximo código: ");
                }
                if (produto == 3)
                {
                    Console.WriteLine("Diesel");
                    Console.Write("Digite o proximo código: ");
                }
                if (produto != 1 && produto != 2 && produto != 3 && produto != 4)
                {
                    Console.WriteLine("Digite outro código");
                    break;
                }
            }

            Console.WriteLine("Muito obrigado!");
    }
}

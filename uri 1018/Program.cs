using System;

namespace uri_1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, n100, n50, n20, n10, n5, n2, n1, resto;

            n = int.Parse(Console.ReadLine());

            n100 = n / 100;
            resto = n % 100;

            n50 = n / 50;
            resto = n % 50;

            n20 = n / 20;
            resto = n % 20;

            n10 = n / 10;
            resto = n % 10;

            n5 = n / 5;
            resto = n % 5;

            n2 = n / 2;
            resto = n % 2;

            n1 = n / 1;
            resto = n % 1;

            Console.WriteLine(n);
            Console.WriteLine(n100 + " nota(s) de R$ 100,00");
            Console.WriteLine(n50 + " nota(s) de R$ 50,00");
            Console.WriteLine(n20 + " nota(s) de R$ 20,00");
            Console.WriteLine(n10 + " nota(s) de R$ 10,00");
            Console.WriteLine(n5 + " nota(s) de R$ 5,00");
            Console.WriteLine(n2 + " nota(s) de R$ 2,00");
            Console.WriteLine(n1 + " nota(s) de R$ 1,00");

        }
    }
}

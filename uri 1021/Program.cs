using System;
using System.Globalization;

namespace uri_1021
{
    class Program
    {
        static void Main(string[] args)
        {
            double N;
            int quociente, resto, nota, moeda;

            N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            resto = (int)(N * 100 + 0.5); // uma maneira de fazer casting (double para int)

            Console.WriteLine("NOTAS:");

            nota = 100;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 50;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 20;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 10;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 5;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 2;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            moeda = 100;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            Console.WriteLine("MOEDAS:");

            nota = 100;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 1.00");
            resto = resto % (moeda * 100);

            nota = 50;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.50");
            resto = resto % (moeda * 100);

            nota = 20;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.25");
            resto = resto % (moeda * 100);

            nota = 10;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.10");
            resto = resto % (moeda * 100);

            nota = 5;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0,05");
            resto = resto % (moeda * 100);

            nota = 1;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0,01");
            resto = resto % (moeda * 100);
        }
    }
}

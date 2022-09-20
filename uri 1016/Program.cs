using System;

namespace uri_1016
{
    class Program
    {
        static void Main(string[] args)
        {
            int distancia = int.Parse(Console.ReadLine());
            double kwPercorridoX = 0;
            double kwPercorridoY = 0;

            int minutos = 0;
            double distanciaEntreXeY = 0;
            while (distanciaEntreXeY < distancia)

            {
                kwPercorridoX += 1;
                kwPercorridoY += 1.5;
                distanciaEntreXeY = kwPercorridoY - kwPercorridoX;
                minutos += 1;
            }

            Console.WriteLine($"{minutos} minutos");
        }
    }
}

using System;
using System.Globalization;

namespace uRI_1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int autonomia = 12;

            float horasPercorridas, velocidadeMedia, gastoCombustivel;

            horasPercorridas = float.Parse(Console.ReadLine());
            velocidadeMedia = float.Parse(Console.ReadLine());

            gastoCombustivel = (velocidadeMedia / autonomia) * horasPercorridas;

            Console.WriteLine(gastoCombustivel.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ultima_atividade_repetição
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double nota2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double nota3 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Media = (nota1 * 3.5 + nota2 * 7.5) / 11;

            Console.WriteLine($"MEDIA = {Media.ToString("F5", CultureInfo.InvariantCulture)}");

            Console.ReadLine();
        }
    }
}
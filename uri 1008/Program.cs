using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        int func = int.Parse(Console.ReadLine());
        int horasTrab = int.Parse(Console.ReadLine());
        float valorHora = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        float salario = horasTrab * valorHora;

        Console.WriteLine("NUMBER = " + func);
        Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));

    }

}
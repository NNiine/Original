using System;

namespace Curso - pt 2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Concatenando Strings
            string primeiroNome, segundoNome;
            primeiroNome = "Bruno";
            segundoNome = "José";

            string nomeCompleto = string.Concat(primeiroNome, " ", segundoNome, " Oliveira");
            Console.WriteLine(nomeCompleto);

        }
    }
}
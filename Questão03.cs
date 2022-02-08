using System;

namespace Questão03.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite quantos anos completos de vida você tem: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            int dias = idade * 365;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Você já gastou "+ dias+" de vida !!!");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

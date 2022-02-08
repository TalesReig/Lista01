using System;

namespace Questão05.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double novosalbruto, novosalliquido,imposto;
            Console.Write("Digite seu salário atual:");
            double salarioinicial = Convert.ToDouble(Console.ReadLine());

            novosalbruto = salarioinicial * 1.15;
            novosalliquido = novosalbruto * 0.92;
            imposto = novosalbruto * 0.08;
            Console.WriteLine("Seu novo salário bruto é de:" + novosalbruto + "R$");
            Console.WriteLine("O Governo acaba de roubar de você um total de: " + imposto + "R$");
            Console.WriteLine("Seu novo salário líquido é de:" + novosalliquido + "R$");

            Console.ReadLine();
        }
    }
}

using System;

namespace Questão02.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double receita, popanca;
            Console.Write("Quantos pães foram vendidos ?");
            int totpao = Convert.ToInt32(Console.ReadLine());
            Console.Write("Quantas broas foram vendidas?");
            int totbroa = Convert.ToInt32(Console.ReadLine());

            //calculando o total vendido no dia 
            receita = (totpao * 0.12) + (totbroa * 1.5);
            popanca = receita * 0.1;

            Console.WriteLine("O total arrecadado foi de: " + receita + "R$.");
            Console.WriteLine("O total a ser depositado é de: " + popanca + "R$.");
        }
    }
}

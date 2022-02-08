using System;

namespace Questão01.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento;

            Console.Write("Digite a largura do terreno: ");
            do
            {
                largura = Convert.ToDouble(Console.ReadLine());
                if (largura <= 0)
                {
                    Console.WriteLine("Digite o Comprimento do terreno do terreno");
                }
            } while (largura <= 0);
            Console.Write("Digite o Comprimento do terreno do terreno: ");
            do
            {
                comprimento = Convert.ToDouble(Console.ReadLine());
                if (comprimento <= 0)
                {
                    Console.WriteLine("Digite o Comprimento do terreno do terreno");
                }
            } while (comprimento <= 0);

            double area = largura * comprimento;
            Console.WriteLine("O terreno tem uma área de:" + area + "ua");
            Console.ReadLine();
        }
    }
}

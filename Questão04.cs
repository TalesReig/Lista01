using System;

namespace Questão04.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double far;
            Console.Write("Digite a temperatura em graus Celcius: ");
            double cel = Convert.ToDouble(Console.ReadLine());

            far = cel * 1.8 + 32;
            Console.Write("Digite a temperatura em graus Fahrenheit é: " + far);
            Console.ReadLine();
        }
    }
}

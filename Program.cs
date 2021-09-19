using System;

namespace Exercicio_AreaTrianguloRet
{
    class Program
    {
        static void Main(string[] args)
        {
            double área, b, h;
            
            Console.Write("\nDigite o valor da base do retângulo: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura do retângulo:........");
            h = Convert.ToDouble(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            área = (b*h)/2;
            Console.WriteLine($"\nO valor da área é equlavente à {área}\n");
            Console.ResetColor();
        }
    }
}

using System;
using System.Globalization;

namespace CalcularIMC
{
    class Program
    {
        static void Main(string[] args) 
        {
            System.Console.Write("Informe o peso em kg: ");
            double peso = double.Parse(Console.ReadLine(),  CultureInfo.InvariantCulture);

            System.Console.Write("Informe a altura em metros: ");
            double altura = double.Parse(Console.ReadLine(),  CultureInfo.InvariantCulture);

            double valorIMC = peso / (altura * altura);

            if (valorIMC < 20)
            {
                System.Console.WriteLine("\nIMC = " + valorIMC + " -> Abaixo do Peso");
            }
            else if (valorIMC >= 20 && valorIMC < 24)
            {
                System.Console.WriteLine("\nIMC = " + valorIMC + " -> Normal");
            }
            else if (valorIMC >= 24 && valorIMC < 29)
            {
                System.Console.WriteLine("\nIMC = " + valorIMC + " -> Acima do Peso");
            }
            else if (valorIMC >= 29 && valorIMC <= 34)
            {
                System.Console.WriteLine("\nIMC = " + valorIMC + " -> Obeso");
            }
            else
            {
                System.Console.WriteLine("\nIMC = " + valorIMC + " -> Muito Obeso");
            }

            Console.ReadKey();
        }
    }
}
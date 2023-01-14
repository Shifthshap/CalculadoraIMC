using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o peso em Kg: ");
                double peso = double.Parse(Console.ReadLine());

            Console.Write("Informe a altura em metros: ");
            double altura = double.Parse(Console.ReadLine());

            double valorIMC = peso / (altura * altura);

            if (valorIMC < 20)
            {
                Console.WriteLine("\nIMC =" + valorIMC + " -> Abaixo do peso");
            }
            else if (valorIMC >= 20 && valorIMC <= 24)
            {
                Console.WriteLine("\nIMC =" + valorIMC + " -> Peso ideal");
            }
            else if (valorIMC >= 25 && valorIMC <= 29)
            {
                Console.WriteLine("\nIMC =" + valorIMC + " -> Acima do peso");
            }
        }
    }
}

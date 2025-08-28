using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo à Loteria!");
            Console.WriteLine("Qual o valor do Prêmio?");
            double premio = double.Parse(Console.ReadLine());

            Console.WriteLine("Aposta do amigo 1: ");
            double aposta1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Aposta do amigo 2: ");
            double aposta2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Aposta do amigo 3: ");
            double aposta3 = double.Parse(Console.ReadLine());

            double valorTotalApostado = aposta1 + aposta2 + aposta3;

            double premioAmigo1 = (aposta1 / valorTotalApostado) * premio;
            double premioAmigo2 = (aposta2 / valorTotalApostado) * premio;
            double premioAmigo3 = (aposta3 / valorTotalApostado) * premio;

            Console.WriteLine("O amigo 1 receberá: {0:F2}", premioAmigo1);
            Console.WriteLine("O amigo 2 receberá: {0:F2}", premioAmigo2);
            Console.WriteLine("O amigo 3 receberá: {0:F2}", premioAmigo3);
        }
    }
}

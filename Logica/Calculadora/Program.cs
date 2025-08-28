using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o primeiro número:");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            double n2 = int.Parse(Console.ReadLine());

            double divisao = (double)n1 / n2;

            Console.WriteLine("A soma dos números é: {0}", n1 + n2);
            Console.WriteLine("A Subtração dos números é: {0}", n1 - n2);
            Console.WriteLine("A Multiplicação dos números é: {0}", n1 * n2);
            Console.WriteLine("A Divisão dos números é: {0}", divisao);
            Console.WriteLine("O Resto da Divisão dos números é: {0}", n1 % n2);


            Console.WriteLine("Pressione ENTER para encerrar o programa!");
            Console.ReadKey();
        }
    }
}

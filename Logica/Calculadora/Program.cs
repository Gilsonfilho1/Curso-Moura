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
            int n1, n2;
            Console.WriteLine("Digite o primeiro número:");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("A soma dos números é: {0}", n1 + n2);
            Console.WriteLine("A Subtração dos números é: {0}", n1 - n2);
            Console.WriteLine("A Multiplicação dos números é: {0}", n1 * n2);
            Console.WriteLine("A Divisão dos números é: {0}", n1 / n2);
            Console.WriteLine("O Resto da Divisão dos números é: {0}", n1 % n2);


            Console.WriteLine("Pressione ENTER para encerrar o programa!");
            Console.ReadKey();
        }
    }
}

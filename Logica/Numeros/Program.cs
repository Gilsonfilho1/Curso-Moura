using System;

namespace Numeros
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");

            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("{1} {0} ", n1 * 2, "Dobro");
            Console.WriteLine("Pressione ENTER para encerrar o programa!");
            Console.ReadLine();
        }
    }
}
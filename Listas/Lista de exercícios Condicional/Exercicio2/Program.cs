using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            do
            {
                num1 = int.Parse(Console.ReadLine());
                if (num1 % 2 == 0)
                {
                    Console.WriteLine("PAR");
                }
                else
                {
                    Console.WriteLine("IMPAR");
                }
            } while (num1 != 2265); //Só pra fechar o programa mesmo.
          
        }
    }
}

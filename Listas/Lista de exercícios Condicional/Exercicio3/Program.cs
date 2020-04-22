using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2, veredito;
            string[] pegarValores = Console.ReadLine().Split(' ');
            valor1 = int.Parse(pegarValores[0]);
            valor2 = int.Parse(pegarValores[1]);

            if (valor1 > valor2)
            {
                veredito = valor1 % valor2;
            }
            else
            {
                veredito = valor2 % valor1;
            }
            if (veredito == 0)
            {
                Console.WriteLine("SÃO múltiplos");
            }
            else
            {
                Console.WriteLine("NÃO SÃO múltiplos");
            }


        }
    }
}

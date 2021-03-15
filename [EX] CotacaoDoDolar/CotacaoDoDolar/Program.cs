using System;
using System.Globalization;

namespace CotacaoDoDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos dólares vai comprar?");
            double dolsAComprar = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor a ser pago em reais: " + ConversorDeMoeda.Converter(dolsAComprar).ToString("F2", CultureInfo.InvariantCulture));
           
        }
    }
}

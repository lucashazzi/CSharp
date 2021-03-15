using System;
using System.Collections.Generic;
using System.Globalization;
using ExercicioHerancaEPolimorfismo.Entities;

namespace ExercicioHerancaEPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> listaProds = new List<Product>();

            Console.WriteLine("Whats the number of desired products to be inserted?");
            int qtdeProd = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdeProd; i++)
            {
                Console.WriteLine($"Product #{i} info: ");
                Console.WriteLine("Common, used or imported (c/u/i)? ");
                string tipo = Console.ReadLine();
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Product produto = new Product(name, price);

                if (tipo.ToUpper() == "U")
                {
                    Console.WriteLine("Manufacture Date: ");
                    DateTime ManufactureDate = DateTime.Parse(Console.ReadLine());
                    produto = new UsedProduct(name, price, ManufactureDate);
                }
                else if (tipo.ToUpper() == "I")
                {
                    Console.WriteLine("Customs Fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    produto = new ImportedProduct(name, price, customsFee);
                }
                else
                {
                    if (tipo.ToUpper() != "C")
                    {
                        Console.WriteLine("Produto inválido.");
                        Console.Beep();
                        return;
                    }
                }

                listaProds.Add(produto);
            }
            Console.WriteLine("\nPRICE TAGS: \n");
            foreach (Product produto in listaProds)
            {
               string priceTag =  produto.PriceTag();
               Console.WriteLine(priceTag + "\n");
            }
        }
    }
}


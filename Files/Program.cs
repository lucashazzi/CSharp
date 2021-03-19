using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Files.Entities;
namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> prods = new List<Product>();
            string SourcePath = @"C:\Users\lucas\source\repos\Files\res\file.csv";
            string TargetPath = @"C:\Users\lucas\source\repos\Files\res\file2.csv";

            try
            {
                using StreamReader sr = File.OpenText(SourcePath);
                while (!sr.EndOfStream)
                {
                    Product prod = new Product();
                    string line = sr.ReadLine();
                    string[] details = line.Split(";");
                    if (details.Length > 0 && details[0] != "") 
                    {
                        prod.Name = details[0];
                        prod.Value = double.Parse(details[1]);
                        prod.Amount = int.Parse(details[2]);
                        prods.Add(prod);
                    }
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine("Error!\n");
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("PRODUCTS: ");
            List<string> lines = new List<string>();
            foreach(Product product in prods)
            {
                Console.WriteLine("====================================");
                Console.WriteLine($"Name: {product.Name}");
                Console.WriteLine($"Value: ${product.Value.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Amount: {product.Amount}");
                Console.WriteLine($"Total value: ${product.GetTotalValue()}");
                Console.WriteLine("===================================\n");
                lines.Add(product.Name + ";" + product.GetTotalValue());
            }
            if(!File.Exists(TargetPath))
            {
                File.Create(TargetPath);
            }
            using StreamWriter sw = File.AppendText(TargetPath);
            foreach (string line in lines)
            {
                sw.WriteLine(line);
            }
        }
    }
}

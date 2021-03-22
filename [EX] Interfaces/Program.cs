using System;
using System.Collections.Generic;
using System.Globalization;
using _EX__Interfaces.Entities;
namespace _EX__Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert contract data: ");
            
            Console.WriteLine("Number: ");
            string number = Console.ReadLine();
            
            Console.WriteLine("Date: ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Contract Value: ");
            double value = double.Parse(Console.ReadLine());

            Console.WriteLine("Insert the number of stallments: ");
            int installments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, value, date, new BrickPayService(), installments);

            List<Installment> installmentList = contract.calculateInstallments();

            Console.WriteLine("Installments: ");
            foreach (Installment inst in installmentList)
            {
                Console.WriteLine(inst.DueDate.ToShortDateString() + " - " + inst.Amount);
                contract.TotalValue += inst.Amount;
            }

            Console.WriteLine(contract.TotalValue.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}

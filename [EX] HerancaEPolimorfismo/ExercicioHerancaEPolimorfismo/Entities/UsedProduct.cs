using System;

namespace ExercicioHerancaEPolimorfismo.Entities
{
    class UsedProduct : Product
    {
        protected DateTime manufactureDate { get; set; }
   
        public UsedProduct()
        { 
        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            this.manufactureDate = manufactureDate;
        }

        public DateTime ManufactureDate
        {
            get => manufactureDate;
            set
            {
                if(ManufactureDate.Year < 1800 || ManufactureDate > DateTime.Now)
                {
                    Console.WriteLine("Data inserida inválida.");
                }
                else
                {
                    manufactureDate = ManufactureDate;
                }
            }
        }

        public override string PriceTag()
        {
            return $"{base.PriceTag()} (Manufacture Date: {manufactureDate}).";
        }

    }
}

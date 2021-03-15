namespace ExercicioHerancaEPolimorfismo
{
    class ImportedProduct : Product
    {
        protected double customsFee { get; set; }

        public ImportedProduct()
        {
        }
        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            this.customsFee = customsFee;
        }
        public double totalPrice()
        {
            return customsFee + price;
        }

        public double CustomsFee
        {
            get => customsFee;
            set
            {
                if(CustomsFee >= 0)
                    customsFee = CustomsFee;
            }
        }
        public override string PriceTag()
        {
            return $"{name}: ${totalPrice()} (Customs Fee: ${customsFee}).";
        }

    }


}

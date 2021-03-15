namespace ExercicioHerancaEPolimorfismo
{
    class Product
    {
        protected string name { get; set; }
        protected double price { get; set; }

        public Product()
        { 
        }
        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public virtual string PriceTag()
        {
            return $"{name}: ${price}.";
        }
    }
}

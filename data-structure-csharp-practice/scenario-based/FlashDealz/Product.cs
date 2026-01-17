namespace bridge.DSA_Senario.FlashDealz
{
    class Product
    {
        private string name;
        private double discount;

        public Product(string name, double discount)
        {
            this.name = name;
            this.discount = discount;
        }

        public string GetName()
        {
            return name;
        }

        public double GetDiscount()
        {
            return discount;
        }
    }
}

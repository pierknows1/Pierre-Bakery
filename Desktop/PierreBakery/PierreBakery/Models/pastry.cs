namespace PierreBakery.Models
{
    public class Pastry
    {
        public int Price { get; set; }
        public int Quantity { get; set; }

        public Pastry( int quantity )
        {
            Price = 2;
            Quantity = quantity;
        }
        public int PastryTotal()
        {
            int pastryCost = Price * Quantity;
            if (Quantity >= 4)
            {
                int bogoPastry = (Quantity / 4 ) * Price;
                pastryCost -= bogoPastry;
            }
            return pastryCost;
            }
        }

}
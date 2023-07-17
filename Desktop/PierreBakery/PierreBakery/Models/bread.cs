namespace PierreBakery.Models
{
    public class Bread
    {   
        public int Price { get; set; }
        public int Quantity { get; set; }
        public Bread(int quantity)
        {
            Price = 5;
            Quantity = quantity;
        }
        public int BreadTotal()
        {
            return Price * Quantity;
        }
        public int CalculateBogo()
        { 
            if(Quantity != 3)
            {
                return Quantity * 5;
            }
            else {
                return 10;
            }
        }
        public int CalculateXBogo()
        {
            if(Quantity % 3 == 0)
            {
                return (Quantity / 3) * 10;
            }
            else {
                int remainder = Quantity % 3;
                int newCount = Quantity - remainder;
                return (remainder * 5) + ((newCount / 3) * 10);
            }
        }
    }
}
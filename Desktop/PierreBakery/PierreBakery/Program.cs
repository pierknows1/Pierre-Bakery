using System;
using PierreBakery.Models;

namespace Pierre_Bakery
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Pierre's Bakery!");
            Console.WriteLine("SPECIAL!!!!    SPECIAL!!!!    BUY 3 LOAVES OF BREAD FOR THE PRICE OF 2!!!");
            Console.WriteLine("SPECIAL!!!!    SPECIAL!!!!    BUY 4 PASTRIES FOR THE PRICE OF 3!!!");
            Console.WriteLine("Bread $5.00 ea. & Pastry $2.00 ea.");


            PlaceOrder();

            Console.WriteLine("Thank you for your order. Have a great day!");
        }

        private static void PlaceOrder()
        {
            Console.WriteLine();
            Console.Write("How many loaves of bread would you like? ");
            int breadQuantity = int.Parse(Console.ReadLine());

            Console.Write("How many pastries would you like? ");
            int pastryQuantity = int.Parse(Console.ReadLine());

            UIBakery bakery = new UIBakery(breadQuantity, pastryQuantity);
            int totalCost = bakery.TotalCost();

            Console.WriteLine();
            Console.WriteLine("Order Placed");
            Console.WriteLine("------- Total Order -------");
            Console.WriteLine("Breads: " + breadQuantity);
            Console.WriteLine("Pastries: " + pastryQuantity);
            Console.WriteLine("Total Cost: $" + totalCost);
        }
    }
}

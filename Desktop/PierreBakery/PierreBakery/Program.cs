using System;
using PierreBakery.Models;

namespace Pierre_Bakery
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Pierre's Bakery!");
            Console.WriteLine("SPECIAL!!!!    SPECIAL!!!!    BUY 3 LOAFS OF BREAD FOR THE PRICE OF 2");
            Console.WriteLine("SPECIAL!!!!    SPECIAL!!!!    BUY 4 PASTRIES FOR THE PRICE OF 3");


            PlaceOrder();

            Console.WriteLine("Thank you for your order. Have a great day!");
        }

        private static void PlaceOrder()
        {
            Console.WriteLine();
            Console.Write("Enter the quantity of bread: ");
            int breadQuantity = int.Parse(Console.ReadLine());

            Console.Write("Enter the quantity of pastries: ");
            int pastryQuantity = int.Parse(Console.ReadLine());

            UIBakery bakery = new UIBakery(breadQuantity, pastryQuantity);
            int totalCost = bakery.TotalCost();

            Console.WriteLine();
            Console.WriteLine("Placed Order");
            Console.WriteLine("------- Order Summary -------");
            Console.WriteLine("Breads: " + breadQuantity);
            Console.WriteLine("Pastries: " + pastryQuantity);
            Console.WriteLine("Total Cost: $" + totalCost);
        }
    }
}

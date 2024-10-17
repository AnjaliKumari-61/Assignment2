using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class A2Q1
    
    {
       public static void price()
        {
            // Prices of the 5 items
            double[] itemPrices = new double[5];

            // Input prices of 5 items
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter the price of item {i + 1}: ");
                itemPrices[i] = Convert.ToDouble(Console.ReadLine());
            }

            // Calculate total price
            double totalPrice = 0;
            foreach (double price in itemPrices)
            {
                totalPrice += price;
            }

            // Apply 10% discount if total price exceeds Rs. 3000
            if (totalPrice > 3000)
            {
                totalPrice *= 0.9;
            }

            // Display total price
            Console.WriteLine($"The total price after discount (if applicable) is: Rs. {totalPrice}");
        }
    }

}


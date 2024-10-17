using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class A2Q6
    {
        
       public  static void Taxi()
        {
            // Constants
            const double baseFare = 20.00;  // Flat rate for the first 2 km
            const double perKmRate = 15.00; // Rate per km for additional distance
            const double nightSurchargeRate = 1.5; // 50% night surcharge

            // Input distance traveled
            Console.Write("Enter the distance traveled in kilometers: ");
            double distance = Convert.ToDouble(Console.ReadLine());

            // Input time of the ride
            Console.Write("Enter the time of the ride (24-hour format, e.g., 22 for 10 PM): ");
            int hour = Convert.ToInt32(Console.ReadLine());

            // Calculate fare
            double fare = baseFare;

            if (distance > 2)
            {
                fare += (distance - 2) * perKmRate;
            }

            // Apply night surcharge if the ride occurs after 10 PM
            if (hour >= 22 || hour < 6)
            {
                fare *= nightSurchargeRate;
            }

            // Display the total fare
            Console.WriteLine($"The total fare for your ride is: Rs. {fare}");
        }
    }


}

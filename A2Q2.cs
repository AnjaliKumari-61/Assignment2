using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class A2Q2
    {

      public static void temperature()
        {
            // Input temperature in Celsius
            Console.Write("Enter the temperature in Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            // Convert Celsius to Fahrenheit
            double fahrenheit = (celsius * 9 / 5) + 32;

            // Display the converted temperature
            Console.WriteLine($"The temperature in Fahrenheit is: {fahrenheit}°F");

            // Display a warning if the temperature is below 0°C
            if (celsius < 0)
            {
                Console.WriteLine("Warning: The temperature is below freezing point (0°C)!");
            }
        }
    }

}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class A2Q7
  
    {
        public static void attendence()
        {
            const int totalDays = 5;
            bool[] attendance = new bool[totalDays];
            int daysAttended = 0;

            // Record attendance for 5 days
            for (int i = 0; i < totalDays; i++)
            {
                Console.Write($"Enter attendance for Day {i + 1} (P for Present, A for Absent): ");
                char input = Convert.ToChar(Console.ReadLine().ToUpper());

                if (input == 'P')
                {
                    attendance[i] = true;
                    daysAttended++;
                }
                else if (input == 'A')
                {
                    attendance[i] = false;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'P' for Present or 'A' for Absent.");
                    i--; // Re-enter the same day's attendance
                }
            }

            // Display total number of days attended
            Console.WriteLine($"\nTotal days attended: {daysAttended} out of {totalDays}");

            // Check if the student has perfect attendance
            if (daysAttended == totalDays)
            {
                Console.WriteLine("The student has perfect attendance!");
            }
            else
            {
                Console.WriteLine("The student does not have perfect attendance.");
            }
        }
    }

}


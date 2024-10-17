using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment20
{
    internal class A2Q8
    {

        

        public  static void ExpenseTracker()
        {
            monthlyExpenses = new decimal[12];
        }

        // Set the expense for a particular month
        public void SetExpense(int month, decimal amount)
        {
            if (month < 1 || month > 12)
            {
                Console.WriteLine("Invalid month. Please enter a month between 1 and 12.");
                return;
            }
            monthlyExpenses[month - 1] = amount;
        }

        // Calculate total expenses for the year
        public decimal GetTotalExpenses()
        {
            return monthlyExpenses.Sum();
        }

        // Get the month with the highest expense
        public int GetMonthWithHighestExpense()
        {
            return Array.IndexOf(monthlyExpenses, monthlyExpenses.Max()) + 1;
        }

        // Get the month with the lowest expense
        public int GetMonthWithLowestExpense()
        {
            return Array.IndexOf(monthlyExpenses, monthlyExpenses.Min()) + 1;
        }

        // Display monthly expenses
        public void DisplayMonthlyExpenses()
        {
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine($"Month {i + 1}: ${monthlyExpenses[i]}");
            }
        }
    }

    class Program
    {
        static void ExpenseTracker()
        {
            ExpenseTracker tracker = new ExpenseTracker();

            // Set some sample expenses
            tracker.SetExpense(1, 1200.50m); // January
            tracker.SetExpense(2, 950.75m);  // February
            tracker.SetExpense(3, 1300.00m); // March
            tracker.SetExpense(4, 900.00m);  // April
            tracker.SetExpense(5, 1100.50m); // May
            tracker.SetExpense(6, 1450.00m); // June
            tracker.SetExpense(7, 950.00m);  // July
            tracker.SetExpense(8, 1250.25m); // August
            tracker.SetExpense(9, 975.50m);  // September
            tracker.SetExpense(10, 1125.00m); // October
            tracker.SetExpense(11, 1200.75m); // November
            tracker.SetExpense(12, 1600.00m); // December

            // Display all monthly expenses
            tracker.DisplayMonthlyExpenses();

            // Calculate total expenses
            decimal totalExpenses = tracker.GetTotalExpenses();
            Console.WriteLine($"\nTotal Expenses for the Year: ${totalExpenses}");

            // Find the month with the highest and lowest expenses
            int highestExpenseMonth = tracker.GetMonthWithHighestExpense();
            int lowestExpenseMonth = tracker.GetMonthWithLowestExpense();

            Console.WriteLine($"\nMonth with Highest Expense: {highestExpenseMonth}");
            Console.WriteLine($"Month with Lowest Expense: {lowestExpenseMonth}");
        }
    }
}


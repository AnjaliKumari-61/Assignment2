using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class A2Q3
    {
        public static void ATM()
        {
            double balance = 5000.00; // Initial balance

        while (true)
        {
            Console.WriteLine("\nWelcome to Simple ATM");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Exit");
            Console.Write("Please select an option (1-4): ");
            
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    // Check Balance
                    Console.WriteLine($"Your current balance is: Rs. {balance}");
                    break;

                case 2:
                    // Deposit Money
                    Console.Write("Enter the amount to deposit: Rs. ");
                    double depositAmount = Convert.ToDouble(Console.ReadLine());
        balance += depositAmount;
                    Console.WriteLine($"You have successfully deposited Rs. {depositAmount}. Your new balance is: Rs. {balance}");
                    break;

                case 3:
                    // Withdraw Money
                    Console.Write("Enter the amount to withdraw: Rs. ");
                    double withdrawAmount = Convert.ToDouble(Console.ReadLine());

                    if (withdrawAmount <= balance)
                    {
                        balance -= withdrawAmount;
                        Console.WriteLine($"You have successfully withdrawn Rs. {withdrawAmount}. Your new balance is: Rs. {balance}");
                    }
                    else
                    {
                        Console.WriteLine("Insufficient funds! Transaction canceled.");
                    }
break;

                case 4:
    // Exit
    Console.WriteLine("Thank you for using Simple ATM. Goodbye!");
    return;

default:
    Console.WriteLine("Invalid option! Please try again.");
    break;
}
        }
    }
}
    }


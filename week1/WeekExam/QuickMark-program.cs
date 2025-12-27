using System;
using QuickMark;

class Program
{
    static void Main()
    {
        QuickMarks obj = new QuickMarks();
        int choice = 0;

        do
        {
            Console.WriteLine("\n================== QuickMark Traders ==================");
            Console.WriteLine("1. Create New Transaction (Enter Purchase & Selling Details)");
            Console.WriteLine("2. View Last Transaction");
            Console.WriteLine("3. Calculate Profit/Loss (Recompute & Print)");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your option: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    obj.CreateTransaction();
                    break;

                case 2:
                    obj.ViewTransaction();
                    break;

                case 3:
                    obj.CalculateProfitLoss();
                    break;

                case 4:
                    Console.WriteLine("Thank you. Application closed normally.");
                    break;

                default:
                    Console.WriteLine("Invalid menu option. Please try again.");
                    break;
            }

        } while (choice != 4);
    }
}

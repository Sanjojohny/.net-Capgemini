using System;
using MediCare;


class Program
{
    static void Main()
    {
        PatientBill billObj = new PatientBill();
        int choice = 0;

        do
        {
            Console.WriteLine("\n=========== MediCare Billing System ===========");
            billObj.Menu();
            Console.Write("Enter your choice: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    billObj.Create();
                    break;

                case 2:
                    billObj.View();
                    break;

                case 3:
                    billObj.Clear();
                    break;

                case 4:
                    Console.WriteLine("Thank you. Application closed normally.");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select between 1 and 4.");
                    break;
            }

        } while (choice != 4);
    }
}

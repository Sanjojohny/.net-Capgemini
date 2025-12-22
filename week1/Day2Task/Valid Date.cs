

class ValidDateCheck
{
    public static void CheckDate()
    {
        Console.WriteLine("Enter day:");
        int day = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Enter month:");
        int month = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Enter year:");
        int year = Int32.Parse(Console.ReadLine());

        bool isLeapYear =
            (year % 400 == 0) ||
            (year % 4 == 0 && year % 100 != 0);

        int maxDays;

        if (month < 1 || month > 12)
        {
            Console.WriteLine("Invalid Date");
            return;
        }

        if (month == 2)
        {
            
            if (isLeapYear)
            {
                maxDays = 29;
            }
            else
            {
                maxDays = 28;
            }
        }
        else if (
            month == 4 || month == 6 ||
            month == 9 || month == 11
        )
        {
            maxDays = 30;
        }
        else
        {
            maxDays = 31;
        }

        if (day >= 1 && day <= maxDays)
        {
            Console.WriteLine("Valid Date");
        }
        else
        {
            Console.WriteLine("Invalid Date");
        }
    }
}


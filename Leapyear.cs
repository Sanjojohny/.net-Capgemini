using System.Runtime.CompilerServices;

class LeapYear
{
    public static void CheckLeap()
    {
        Console.WriteLine("enter the year");
        int year=Int32.Parse(Console.ReadLine());
        if(year%400==0 ||(year%4==0 && year % 100 !=0))
        {
            Console.WriteLine($"year {year} is Leap Year");
            
        }
        else
        {
            Console.WriteLine($" year {year} is not leap year ");
        }
    }
}
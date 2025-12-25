using System;
using LibraryManagementSystem;
class Program
{
    public static void Main()
    {
        Book objBook=new Book();
        objBook.AcceptDetails();
        Console.WriteLine("Enter the days to read");
        int daysToRead=Int32.Parse(Console.ReadLine());
        Console.WriteLine("enter the late FEE RATE");
        double dailyFeeLate=double.Parse(Console.ReadLine());
        Console.WriteLine("Avarge price Read per Day"+objBook.AveragePagesReadPerDay(daysToRead));
        Console.WriteLine("LateFee"+objBook.CalculateLateFee(dailyFeeLate));

    }
}
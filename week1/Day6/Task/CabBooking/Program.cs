using System;
using CabBooking;
class Program
{
    public static void Main()
    {
        Console.WriteLine("Cab Project ");
        CabDetails objCab=new CabDetails();
        Console.WriteLine("enter the booking Id");
        objCab.BookingID=Console.ReadLine();
        if (objCab.ValidateBookingID())
        {
            Console.WriteLine("enter the cab Type");
            objCab.CabType=Console.ReadLine();
            Console.WriteLine("enter the Distance in km");
            objCab.Distance=Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter the waiting time in minutes");
            objCab.WaitingTime=Int32.Parse(Console.ReadLine());
            Console.WriteLine($"the fare amount is {objCab.CalculateFareAmount():F2}");

            
        }
        else
        {
            Console.WriteLine("Invalid booking ID");
        }
    

        
    }   
}
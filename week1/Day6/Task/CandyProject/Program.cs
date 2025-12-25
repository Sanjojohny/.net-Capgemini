using System;
using System.Security.Cryptography.X509Certificates;
using CandyApplication;
class Program
{
    public static void Main()
    {
        Candy objCandy=new Candy();
        Console.WriteLine("Enter the flavour");
        objCandy.Flavour=Console.ReadLine();

       
        
        Console.WriteLine("enetr the Quantity");
        objCandy.Quantity=Int32.Parse(Console.ReadLine());
        Console.WriteLine("enter the price per peixe");
        objCandy.PricePerPiece=Int32.Parse(Console.ReadLine());
        if (!objCandy.ValidateCandyFlavour())
            {
                Console.WriteLine("invalid dlavour");
                return;

            }
        objCandy.DiscountPer();
        double TotalPrice;
        double Discount;
        objCandy.CalculateDiscount(out TotalPrice,out Discount);

        Console.WriteLine("Total = "+TotalPrice);
        Console.WriteLine("Discount price ="+Discount);
    }

}
using System;
namespace Example2;
class Program
{
    public static void Main()
    {
        OrderProccessor objP=new OrderProccessor();
        Notification objN=new Notification();
        Billing objB=new Billing();
        objP.OrderPlaced+=objN.SendAlert;
        objP.OrderPlaced+=objB.Billingmethod;

        System.Console.WriteLine("enter the customer oder");
        int a=Int32.Parse(Console.ReadLine());
        objP.OrderProcess(a);

        System.Console.WriteLine("enter the customer oder");
        int b=Int32.Parse(Console.ReadLine());
        objP.OrderPlaced+=objN.SendAlert;
        objP.OrderPlaced-=objB.Billingmethod;

        objP.OrderProcess(b);

        


    }
}
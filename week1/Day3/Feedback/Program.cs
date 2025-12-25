using System;
using FeedBack;
class Program
{
    public static void Main()
    {
        double totalRating=0;
        Console.WriteLine("entr the numbetrt of customers");
        int input=Int32.Parse(Console.ReadLine());
        Feed[] objFeed=new Feed[input];
        for(int i = 0; i < input; i++)
        {
            objFeed[i]=new Feed();
            Console.WriteLine($"customer id ={i+1}");
            Console.WriteLine("enter the movile number");
            objFeed[i].MobileNumber=Console.ReadLine();
            Console.WriteLine("feedback rating out of 5");
            objFeed[i].FeedbackRating=double.Parse(Console.ReadLine());
            totalRating+=objFeed[i].FeedbackRating;


        }
        Console.Write("Customer    Details  ");
        for(int i = 0; i < input; i++)
        {
            objFeed[i].Display();
        }

        double avargeFeedbackRating=totalRating/input;
        Console.WriteLine($"AvarageFeedBack={avargeFeedbackRating}");

    }
}

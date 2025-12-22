using System;

class ProfitLoss
{
    public static void Calculate()
    {
        Console.WriteLine("Enter Cost Price:");
        double cp = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter Selling Price:");
        double sp = double.Parse(Console.ReadLine());

        if (sp > cp)
        {
            double profit = sp - cp;
            double profitPercent = (profit / cp) * 100;

            Console.WriteLine($"Profit = {profit}");
            Console.WriteLine($"Profit Percentage = {profitPercent:F2}%");
        }
        else if (cp > sp)
        {
            double loss = cp - sp;
            double lossPercent = (loss / cp) * 100;

            Console.WriteLine($"Loss = {loss}");
            Console.WriteLine($"Loss Percentage = {lossPercent:F2}%");
        }
        else
        {
            Console.WriteLine("No Profit No Loss");
        }
    }
}


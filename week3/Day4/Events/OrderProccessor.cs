using System;

namespace Example2;

public class OrderProccessor
{
    public delegate void NotifyOrder(int OrderId);
    public event NotifyOrder OrderPlaced;

    public void OrderProcess(int OrderId)
    {
        System.Console.WriteLine("oder id placed succesfully ");
        System.Console.WriteLine($"oder id {OrderId} ");
        System.Console.WriteLine("\t invoking event");
        OrderPlaced?.Invoke(OrderId);
        
    }

}

using System;
using System.Security.Cryptography.X509Certificates;
using LaptopPrice;
class Program
{
    public static void Main()
    {
        
        System.Console.WriteLine("enter 1 for laptop");
        System.Console.WriteLine("enter 2 for device");
        int choice=Int32.Parse(Console.ReadLine());
        if (choice == 1)
        {

            LapTop obj=new LapTop();
            Console.Write(" \n\t Enter the processor");
            obj.Processor = Console.ReadLine();

            Console.WriteLine("Enter the ram size");
            obj.RamSize = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the hard disk size");
            obj.HardDiskSize = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the graphic card size");
            obj.GraphicCard = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the display size");
            obj.DisplaySize = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the battery volt");
            obj.BatteryVolt = int.Parse(Console.ReadLine());

            Console.WriteLine("Laptop price is " + obj.LaptopPriceCalculation());
        }
        else if(choice==2){
            DeskTop a=new DeskTop();
            
            Console.WriteLine("Enter the processor");
            Console.WriteLine("processing types: --i3--i4--i5-- ");
            a.Processor = Console.ReadLine();

            Console.WriteLine("Enter the ram size");
            a.RamSize = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the hard disk size");
            a.HardDiskSize = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the graphic card size");
            a.GraphicCard = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the display size");
            a.MonitorSize = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the battery volt");
            a.PowerSupplyVolt = int.Parse(Console.ReadLine());

            Console.WriteLine("Desktop price "+a.DeskTopPriceCalculation());
        }
        
            
        
        
        
    }
}

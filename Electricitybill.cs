

class ElectrcityBill
{
    public static void Bill()
    {
        Console.WriteLine("enter the Unit Consumed");
        int Unit=Int32.Parse(Console.ReadLine());
        double bill;
        if (Unit < 199)
        {
            bill=Unit*1.20;
        }
        else if(Unit>=200 && Unit <= 400)
        {
            bill=Unit*1.50;
        }
        else if(Unit>400 && Unit <= 600)
        {
            bill=Unit*1.80;
        }
        else
        {
            bill=Unit*2.00;
        }
        if (Unit > 400)
        {
            bill=bill*0.15;
        }
        Console.WriteLine($"Electricity bill= {bill}");
    }
    
        
}

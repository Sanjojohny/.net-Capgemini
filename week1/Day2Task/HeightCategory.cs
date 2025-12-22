class HeightCat
{
    public static void CheckHeight()
    {
        Console.WriteLine("enter the height ");
        String? input=Console.ReadLine();
        if(int.TryParse(input,out int height))
        {
            if (height < 150)
            {
                System.Console.WriteLine($"  height :{height} = Dwarf");
            }
            else if(height >= 150 && height <= 165)
            {
                System.Console.WriteLine($"  height is {height} = avarage");
            }
            else if(height >= 165 && height <= 190)
            {
                System.Console.WriteLine($" height :{height} = Tall");
            }
            else
            {
                System.Console.WriteLine($"  height :{height} = Abnormal");
            }
        }
        else
        {
            System.Console.WriteLine("invalid input type a whole number");
        }
        
    }
}

class StonePaperSciccor
{
    public static void Evaluate()
    {
        Console.WriteLine("enter /stone /paper /scissor \n");
        Console.WriteLine("enter the input of player A: ");
        string? A=Console.ReadLine();
        Console.WriteLine("enter input of Player B");
        string? B=Console.ReadLine();

        
        
        if(A=="stone" && B == "scissor")
        {
            Console.WriteLine("player A won");
        }
        else if(A=="paper" &&   B == "stone")
        {
            System.Console.WriteLine("player A won");
        }
        else if(A=="scissor" && B == "paper")
        {
            
        }
        else if (A == B)
        {
            Console.WriteLine("Draw");
        }
        else
        {
            Console.WriteLine("Player B won");
        }


    }
}

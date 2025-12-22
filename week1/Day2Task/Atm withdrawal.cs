class AtmWithDraw
{
    public static void CheckAtm()
    {
        Console.WriteLine("Insert the card (Yes/No)");
        string? a=Console.ReadLine();
        if (a == "Yes")
        {
            Console.WriteLine("Enter the Pin");
            string? b=Console.ReadLine();
                if(!int.TryParse(b,out int pin))
                {    
                Console.WriteLine("invalid Pin");
                return; 
                }
            if (pin == 1234)
            {
                Console.WriteLine("Entrer the amount to withdraw");
                int amount=int.Parse(Console.ReadLine());
                if (amount < 10000)
                {
                    Console.WriteLine($"balance={10000-amount}");
                }
                else
                {
                    Console.WriteLine("insufficienr balance");
                }
            }
            else
            {
                Console.WriteLine("Enter  A Valid Pin");
            }

        }
        else
        {
            Console.WriteLine("Transaction incomplete");
        }
        Console.WriteLine("Transaction completd \n ---------------Thank You---------");
            

            
    }
            
        


        
}


class PrimeNumber
{
    public static void CheckPrime()
    {
        Console.WriteLine("checking prime number :---enter a number");
        String? input=Console.ReadLine();
         if(!int.TryParse(input,out int a)){
            Console.WriteLine("ENTER a valid number");
            return;
        }
        
        for(int i = 2; i <=a; i++)
        
        {
            int count=0;
            for(int j = 1; j <=i; j++)
            {
                if (i % j == 0)
                {
                    count++;
                    
                }
            }
            if (count == 2)
            {
                System.Console.WriteLine($"{i} is prime");
                
            }
            else
            {
                System.Console.WriteLine($"{i} is not prime");
            }         
        }

    }
}
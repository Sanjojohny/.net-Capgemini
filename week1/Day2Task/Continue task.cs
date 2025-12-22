

class Continue_task
{
    public static void ContinueCheck()
    {
        for(int i = 0; i <=50; i++)
        {
            if (i % 3 == 0)
            {
                continue;
            }
            Console.WriteLine($" 1 to 50 excluding the multiples of 3 :  {i}" );
            
        
        }
    }

}

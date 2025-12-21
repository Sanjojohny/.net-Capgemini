class LargeNum
{
    public static void CheckLarge()
    {
        Console.WriteLine("enter the first number");
        int a=Int32.Parse(Console.ReadLine());
        Console.WriteLine("enter the second number");
        int b=Int32.Parse(Console.ReadLine());
        Console.WriteLine("enter the third number");
        int c=Int32.Parse(Console.ReadLine());

        int Max;
        if(a<0 ||  b<0  || c<0)
        {    System.Console.WriteLine("enter valid numabees");
            return;
        } 
            if(a>b && a > c)
            {
                Max=a;
                

            }
            else if( b>a && b>c)
            {
                Max=b;
                
            }
            else
            {
                Max=c;
                
            }
        
        Console.WriteLine($"max={Max}");


                


    }
}


class Calculator
{
    public static void CalFuntions()
    {
        Console.WriteLine(" (+) for adddition");
        Console.WriteLine(" (-) for subtraction");
        Console.WriteLine(" (*) for multiplication");
        Console.WriteLine(" (/) for division");
        
        Console.WriteLine("enter the input a: ");
        int a=Int32.Parse(Console.ReadLine());
        Console.WriteLine("enter the input B: ");
        int b=Int32.Parse(Console.ReadLine());
        Console.WriteLine("ENTER THE CHOICE IN OPTIONS");
        char choice=char.Parse(Console.ReadLine());


        switch (choice)
        {
            case '+':
                Console.WriteLine($"output= {a+b}");
                return;
            case '-':
                Console.WriteLine($"output= {a-b}");
                return;
            case '*':
                Console.WriteLine($"output={a*b}");
                return;
            case '/':
                Console.WriteLine($"output= {a/b}");
                return;
            default:
                Console.WriteLine("invalid");
                return;

                
        }

    }
}
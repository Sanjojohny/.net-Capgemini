class Palindrome
{
     public static void CheckPal()
    {
        Console.WriteLine("enter the number you want to check");
        int input=Int32.Parse(Console.ReadLine());
        int i =0 ;
        int a=input;
        
        int rev=0;
        while(  i < input)
        {
            int og=input%10;
            rev=rev*10+og;
            input=input/10;
        }
        if (a==rev)
        {
            Console.WriteLine($"is palindrome : {a}");
            
        }
        else
        {
            Console.WriteLine($"{a} = not a palindrome");
        }
    }
}

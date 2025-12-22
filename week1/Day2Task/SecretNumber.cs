class SecretNumber{
    public static void GuessNumber()
    {
        int secretNumber=9;
        int guess;
        Console.WriteLine("Guess the Secret Number betweenn 1 and 10)");
        do
        {
            Console.WriteLine("guess the number");
            guess=Int32.Parse(Console.ReadLine());
            if(guess < secretNumber)
            {
                System.Console.WriteLine("low ");
            }
            else if(guess > secretNumber)
            {
                System.Console.WriteLine("high");
            }
            else
            {
                System.Console.WriteLine("you got it right");
            }
        }
        while(secretNumber!=guess);
    }

}

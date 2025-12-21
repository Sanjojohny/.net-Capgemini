class ConsVowels
{
    //method to check whether it is vowels or not
    public static void CheckCV()
    {
        Console.WriteLine("enter the charecter");
        string? input=Console.ReadLine();

        
        if(!char.TryParse(input,out char ch))
        {
            Console.WriteLine("Invalid input");
            return;
        }
        int result;

        if(ch =='A' || ch =='E' || ch=='I' || ch=='O' || ch=='U' || ch =='a' || ch =='e' || ch=='i' || ch=='o' || ch == 'u')
        {
            result=1;
        }
        else
        {
             result=2;
        }
        switch (result)
        {
            case 1:
                Console.WriteLine($"character {ch} is Vowel");
                return;
            case 2:
                Console.WriteLine($"charecter {ch} is Consonant");
                return;
        }

    }
}

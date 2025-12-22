class GradeDescription
{
    public static void GradeDes()
    {
        Console.WriteLine("Enter input Grade");
        string? input=Console.ReadLine();
        if(!char.TryParse(input,out char ch))
        {
            System.Console.WriteLine("invalid type");
            return;
        }
        switch (ch)
        {
            case 'A':
                Console.WriteLine("Excellent");
                break;
            case 'B':
                Console.WriteLine("verygood");
                break;
            case 'C':
                Console.WriteLine("Good");
                break;
            case 'D':
                Console.WriteLine("Avarage");
                break;
            case 'F':
                Console.WriteLine("Fail");
                break;
            default:
                Console.WriteLine("invalid grade");
                break;

                
        }

    }
}

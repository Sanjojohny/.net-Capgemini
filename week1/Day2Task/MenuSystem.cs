

using System.Diagnostics;
using System.Runtime.Intrinsics.Arm;

class MenuSystem
{
    public static void Menuclass()
    {
        void menu()
        {
            Console.WriteLine(" 1. two add A and B");
            Console.WriteLine(" 2. two subtarct  A and B");
            Console.WriteLine(" 1. two Multiply A and B");
            Console.WriteLine(" 1. two divide A and B");
        }
        int choice;
        do
        {
            
            Console.WriteLine("enter number a");
            int a=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter number B");
            int b=Int32.Parse(Console.ReadLine());

            menu();
            Console.WriteLine("enter your choice");
            choice=Int32.Parse(Console.ReadLine());

            switch(choice){
                case 1:
                    System.Console.WriteLine($"{a+b}");
                    return;
                case 2:
                    System.Console.WriteLine($"{a-b}");
                    return;
                case 3:
                    System.Console.WriteLine($"{a*b}");
                    return;
                case 4:
                    System.Console.WriteLine($"{a/b}");
                    return;
                default:
                    System.Console.WriteLine("invalid cjoice");
                    return;
                
            }



        }
        while (choice != 5);

    }


}


class Admission
{
    public static void CheckAdmission(){
        Console.WriteLine("enter the mark in Maths: ");
        int Maths=Int32.Parse(Console.ReadLine());
        Console.WriteLine("enter the mark in Physics: ");
        int Phy=Int32.Parse(Console.ReadLine());
        Console.WriteLine("enter the mark in chemistry: ");
        int Chem=Int32.Parse(Console.ReadLine());

        int Total=Maths+Phy+Chem;

        if(Maths>=65 && Phy>=55 && Chem>=50 &&(Total>=180 || Maths + Phy > 140))
        {
            Console.WriteLine("Student is eligible for admission");
        }
        else
        {
            Console.WriteLine("No admission");
        }
    }
}

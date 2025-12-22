
class SumOfDigits
{
    public static void  CheckSum()
    {
            Console.WriteLine("enter the input");
            int input=Int32.Parse(Console.ReadLine());
            
            while (input>=10)
            {
                int sum=0;
                while(input>0){
                
                sum=sum+input%10;
                input=input/10;

            }
            input=sum;

        }
        System.Console.WriteLine($"input= {input}");

            
     }

        

}

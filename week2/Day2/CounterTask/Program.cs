using System;
namespace CounterTask;
class Program
{
    public static void Main()
    {
        int[] data={0,1,0,1,1,1,1};
        Counter C=new Counter(data);
        try
        {
            string res=C.getCount();
            Console.WriteLine(res);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
            
        }

    }
}

using System;


namespace CounterTask;

public class Counter
{
    public int[] data;
     
     public Counter(int[] data)
    {
        this.data=data;
    }
    

    public string getCount()
    {
        int onecount=0;
        int zerocount=0;
        foreach(int value in data)
        {
            if (value == 0)
            {
                zerocount++;
                
            }
            else if (value == 1)
            {
                onecount++;
            }

            
        }
        if(zerocount%2==0 && onecount % 2 == 0)
        {
            return "great";
        }
        else if(zerocount %2 !=0 && onecount % 2 != 0)
        {
            return "great";
        }
        else if(zerocount %2==0 && onecount % 2 != 0)
        {
            throw new ExceptionOne("One comes odd times");
        }
        else
        {
            throw new ExceptionZero("Zero comes odd times");
        }

    }
    

}
class ExceptionOne : Exception
{
    public ExceptionOne(string message):base(message){}
    
}
class ExceptionZero : Exception
{
    public ExceptionZero(string message):base(message){}
}


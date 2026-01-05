using System;
using System.Diagnostics.Contracts;

namespace KhataEx1;

public class Khata
{
    private Dictionary<string,int>record;

    public Khata(Dictionary<string, int> record)
    {
        this.record=record;
    }

    
    public int getTotal()
    
    {
        int total=0;
        foreach(int amount in record.Values)
        {
            total+=amount;
        }
        return total;
        
    }

    
    public int getRepeatAmount()
    {
        int repeated=0;
        List<int>RepeatedList=new List<int>();
        
        foreach(int amount in record.Values)
        {
            if(RepeatedList.Contains(amount))
            {
                continue;
                
            }
            int count=0;
        
            foreach(int values in record.Values)
            {
                if (values == amount)
                {
                    count++;
                    
                }
            }
                if (count > 1)
                {
                    repeated++;
                }
                RepeatedList.Add(amount);
            
        }
        return repeated;


        
    }

}

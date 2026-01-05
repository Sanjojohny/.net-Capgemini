using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using KhataEx1;
class Program
{
    public static void Main()
    {
        Dictionary<string,int>record= new Dictionary<string, int>()
        {
            {"Milk",100},
            {"Tea",50},
            {"cofee",100},
            {"sugar",50},
            {"salt",200}
            
        };

        Khata K=new Khata(record);
        System.Console.WriteLine("--------------\t");
        System.Console.WriteLine(K.getTotal());
        System.Console.WriteLine(K.getRepeatAmount());



    }
        

            
            
        
   
    
}
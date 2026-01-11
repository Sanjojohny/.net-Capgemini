using System;
namespace Dictionary;

class Program
{
    public static void Main()
    {
          Dictionary<int,DictionaryDemo>objDict=new Dictionary<int,DictionaryDemo>()
          
          {
              {101,new DictionaryDemo{ID=101,Name="SANJO",salary=100}},
              {102,new DictionaryDemo{ID=104,Name="liJO",salary=1000}},
              {103,new DictionaryDemo{ID=108,Name="kiJO",salary=9000}}
                
            
                  
            };

            foreach(KeyValuePair<int,DictionaryDemo>kvp in objDict){
                System.Console.WriteLine($"Id: {kvp.Key}, Name = {kvp.Value.Name}, Salary = {kvp.Value.salary}");

            
        }

        //UPDATE

        System.Console.WriteLine("\t enter the id to update");
        int updateId=Int32.Parse(Console.ReadLine());

        

        // if (objDict.ContainsKey(updateId))
        // {
        //     System.Console.WriteLine("enter new name");
        //     objDict[updateId].Name=Console.ReadLine();
        // }             

        ////------or----------
        if(objDict.TryGetValue(updateId,out DictionaryDemo cust))
        {
            System.Console.WriteLine("enter new name");
            cust.Name=Console.ReadLine();
            System.Console.WriteLine("enter new salary");
            cust.salary=Int32.Parse(Console.ReadLine());

        }


        System.Console.WriteLine("enter id you want to remove");
        int remId=Int32.Parse(Console.ReadLine());
        if (objDict.ContainsKey(remId))
        {
            objDict.Remove(remId);
            
        }
        else
        {
            System.Console.WriteLine("Invalid object");
        }

        foreach(var item in objDict)
        {
            System.Console.WriteLine($"{item.Key},{item.Value.Name},{item.Value.salary}");
        }


        System.Console.WriteLine("\t----------------End--------------");
       

            
              
          


    }
}
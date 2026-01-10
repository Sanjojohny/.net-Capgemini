using System;
using System.Collections.Generic;


using RealEstateMn;
class Program
{
    public static void Main()
    {
        RealEstateApp objReal=new RealEstateApp();
        objReal.AddListing(new RealEstateListing{ID=101,Title="TITLE",Description="GOOD ONE",Price=100,Location="Malappuram"});
        objReal.AddListing(new RealEstateListing{ID=103,Title="Barca",Description="super ONE",Price=109,Location="kalappuram"});
        objReal.AddListing(new RealEstateListing{ID=105,Title="beevi",Description="Excellent ONE",Price=110,Location="Malappuram"});

        //displayy after adding

        foreach(IRealEstateListing item in objReal.GetListings())
        {
            System.Console.WriteLine("-----------------------------------------------------");
            System.Console.WriteLine($" \t ID: {item.ID}, Title:{item.Title},Description:{item.Description},price:{item.Price},Location : {item.Location}");
        }

        System.Console.WriteLine("\t Enter the ID you need to remove");
        int a=Int32.Parse(Console.ReadLine());

        objReal.RemoveListingId(a);

        //display after removing
        foreach(IRealEstateListing item in objReal.GetListings())
        {
            System.Console.WriteLine($" \t ID: {item.ID}, Title:{item.Title},Description:{item.Description},price:{item.Price},Location : {item.Location}");
        }
        
            //UPDATING
       
        

        
    
        Console.WriteLine("Enter the title you need to update:");
        RealEstateListing updated = new RealEstateListing();

        // Title is used as the search key in BL
        
        updated.Title = Console.ReadLine();

        Console.WriteLine("Enter new ID:");
        updated.ID = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter new description:");
        updated.Description = Console.ReadLine();

        Console.WriteLine("Enter new location:");
        updated.Location = Console.ReadLine();

        Console.WriteLine("Enter new price:");
        updated.Price = int.Parse(Console.ReadLine());

        objReal.UpdateListing(updated);

        //display after updations
        foreach(IRealEstateListing item in objReal.GetListings())
        {
            System.Console.WriteLine($" \t ID: {item.ID}, Title:{item.Title},Description:{item.Description},price:{item.Price},Location : {item.Location}");
        }

        Console.WriteLine("\nEnter the location:");
        string loc = Console.ReadLine();

        List<IRealEstateListing> locList =
            objReal.GetListingByLocation(loc);

        Console.WriteLine($"\n--- Listings in {loc} ---");
        foreach (IRealEstateListing item in locList)
        {
            System.Console.WriteLine(
        $"ID:{item.ID}, Title:{item.Title}, Desc:{item.Description}, Price:{item.Price}, Location:{item.Location}");
        }

        Console.WriteLine("\nEnter min amount:");
        int min = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter max amount:");
        int max = int.Parse(Console.ReadLine());

        List<IRealEstateListing> priceList =
            objReal.GetListingByPriceRange(min, max);

        Console.WriteLine("\n--- Listings in Price Range ---");
        foreach (IRealEstateListing item in priceList)
        {
                System.Console.WriteLine(
        $"ID:{item.ID}, Title:{item.Title}, Desc:{item.Description}, Price:{item.Price}, Location:{item.Location}");
    
        }

                
        
        

        
            
    
        
    }
}
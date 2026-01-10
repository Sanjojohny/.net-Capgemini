using System;


namespace RealEstateMn;

public class RealEstateApp
{
    private List<IRealEstateListing> listings=new List<IRealEstateListing>();
    public void AddListing(IRealEstateListing listing)
    {
        listings.Add(listing);
    }
    public void RemoveListingId(int listingID)
    {
        IRealEstateListing rm=listings.Find(a=>a.ID==listingID);
        if (rm != null)
        {
            listings.Remove(rm);
        }
    }
    public void UpdateListing(IRealEstateListing updatedlisting)
    {
        IRealEstateListing up=listings.Find(a=>a.Title==updatedlisting.Title);
        if (up != null)
        {
            up.ID=updatedlisting.ID;
            up.Description=updatedlisting.Description;
            up.Location=updatedlisting.Location;
            up.Price=updatedlisting.Price;

        }
    }
    public List<IRealEstateListing> GetListings()
    {
        return listings;
    }
    public List<IRealEstateListing> GetListingByLocation(string Locations)
    {
        List<IRealEstateListing>result=new List<IRealEstateListing>();
        
        foreach(IRealEstateListing item in listings)
        {
            if( item.Location==Locations)
            {
                result.Add(item);
                
            }


            
        }
        return result;
        

        
    }
    public  List<IRealEstateListing>GetListingByPriceRange(int minPrice,int maxPrice)
    {
        List<IRealEstateListing> priceList=new List<IRealEstateListing>();
        foreach(IRealEstateListing item in listings)
        {
            if(item.Price>minPrice && item.Price < maxPrice)
            {
                priceList.Add(item);
            }
        }
        return priceList;
    }




}

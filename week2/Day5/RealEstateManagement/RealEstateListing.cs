using System;


namespace RealEstateMn;

public class RealEstateListing:IRealEstateListing
{
    public int ID{get;set;}
    public string Title{get;set;}=string.Empty;
    public string Description{get;set;}=string.Empty;
    public int Price{get;set;}
    public string Location{get;set;}=string.Empty;

}

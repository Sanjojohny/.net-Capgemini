using System;

namespace CandyApplication;

public class Candy
{
    #region properties
    public string Flavour{get;set;}
    public int Quantity{get;set;}
    public int PricePerPiece{get;set;}
    public double TotalPrice{get;set;}
    public double Discount{get;set;}
    #endregion
    public bool ValidateCandyFlavour()
    {
        if(Flavour=="Strawberry" || Flavour=="Lemon" || Flavour == "Mint")
        {
            return true;
        }
        else
        {
            return false;
        }


    }
    double Disc=0;

    public double DiscountPer()
    {
        
        if (Flavour == "Strawberry")
        {
            Disc=15;
        
            
        }
        else if (Flavour == "Lemon")
        {
            Disc=10;

        }
        else if (Flavour == "Mint")
        {
            Disc=5;

        }
        return Disc;

        
    }



    public void CalculateDiscount(out double  TotalPrice,out double  Discount)
    {
        TotalPrice=Quantity*PricePerPiece;
        Discount=TotalPrice-(TotalPrice*Disc/100);
        
    }


}

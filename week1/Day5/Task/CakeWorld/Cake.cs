using System;

namespace CakeWorld;

public class Cake
{
    public string flavour{get;set;}=string.Empty;
    public int quantityInKg{get;set;}
    public double pricePerKg{get;set;}
    public int cakeQuantity{get;}
    public bool CakeOrder(){
        if(!(flavour=="Chocolate" || flavour=="Red Velvet" || flavour=="Vanila"))
        {
            throw InvalidFlavourException();
        }
        if (cakeQuantity > 0)
        {
            throw new quantityInvlidException();
            
        }
        return true;

    }
    public Discount()
    {
        int dis=0;
        if (flavour == "Chocolate")
        {
            dis=5;
            return ;
        }
        else if (flavour == "vanilla")
        {
            dis=
        }
    }
    
    
    

    public CalculatePrice()
    {
        

        
    }

}

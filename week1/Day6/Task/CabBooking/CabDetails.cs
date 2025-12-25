using System;

namespace CabBooking;

public class CabDetails:Cab
{
    
    public bool ValidateBookingID()
    {
    
        // 1. Length must be 6
        if (BookingID.Length != 6)
            return false;

        // 2. Must start with "AC@"
        if (!BookingID.StartsWith("AC@"))
            return false;

        // 3. Last 3 characters must be digits
        for (int i = 3; i <= 5; i++)
        {
            if (!(BookingID[i] >= '0' && BookingID[i] <= '9'))
                return false;
        }

        return true;
    }
    
    public double CalculateFareAmount()
    {
        int PricePerKm=0;
        if (CabType == "Hatchback")
        {
            PricePerKm=10;
        }
        else if (CabType == "Sedan")
        {
            PricePerKm=20; 
        }
        else if (CabType =="SUV")
        {
            PricePerKm=30;
        }
        double waitingCharge=Math.Sqrt(WaitingTime);
        double fare=Distance*PricePerKm+waitingCharge;
        return fare;
    }


}

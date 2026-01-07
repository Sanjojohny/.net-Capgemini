using System;


namespace DigitalPettyCashLe;

class IncomeTransaction:Transacton
{
    public string Source{get;set;}
    public  override string GetSummary()
    {
        return "Amount" + Amount + "Source:" + Source;
               
         
    }
    
}

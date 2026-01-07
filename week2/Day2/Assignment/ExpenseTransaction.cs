using System;

namespace DigitalPettyCashLe;

 class ExpenseTransaction:Transacton
{
    public string Category{get;set;}
    public override string GetSummary()
    {
        return "Amount" + Amount + "Source:" + Category;
        
    }

    

    
}

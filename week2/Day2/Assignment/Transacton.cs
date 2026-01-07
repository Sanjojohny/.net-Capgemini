using System;

namespace DigitalPettyCashLe;

abstract class Transacton:IReportable
{
     public int Id{get;set;}
     public DateTime Date{get;set;}
     public int Amount {get;set;}
     public string Description{get;set;}

     public abstract string GetSummary();







}

{
    public string Source{get;set;}
    
}

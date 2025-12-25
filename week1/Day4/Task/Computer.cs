

namespace LaptopPrice;

public class Computer
{
    
    public string Name{get;set;}
    public string Processor{get;set;}
    public int RamSize{get;set;}
    public int HardDiskSize{get;set;}
    public int GraphicCard{get;set;}

    //public int RamPrice{get;}=200;    this is a readonly cannot modify
    //++
    // 
    // 
    // ++public int RamPrice=20;
    //doesnot need to create fields as public

    public Computer()
    {
        Name="";
        Processor="";
    }





}

using System;

namespace LibraryManagementSystem;

public class Book
{
    #region Name
    
    string title=string.Empty;
    string author=string.Empty;
    int numPages;
    DateTime dueDate;
    DateTime returnedDate;
  
    #endregion

    public Book(){}
        
    
    public Book(string Title,string Author,int Numpages,DateTime DueDate,DateTime ReturnedDate){
        title=Title;
        author=Author;
        numPages=Numpages;
        dueDate=DueDate;
        returnedDate=ReturnedDate;
       



        
    }

    public void AcceptDetails()
    {
        Console.WriteLine("A Time To Kill");
        Console.WriteLine("enetr the Title");
        title=Console.ReadLine();
        Console.WriteLine("Enter the author");
        author=Console.ReadLine();
        Console.WriteLine("enter the number of pages");
        numPages=Int32.Parse(Console.ReadLine());
        Console.WriteLine("enter the DueDate");
        dueDate=DateTime.Parse(Console.ReadLine());
        Console.WriteLine("enter the return date");
        returnedDate=DateTime.Parse(Console.ReadLine());



        
        
    }
    public double AveragePagesReadPerDay(int daysToRead)
    {
        
        double AvaragePage=numPages/daysToRead;
        return AvaragePage;
        
    }
    public double CalculateLateFee(double dailyFeeLate)
    {
        int DaysLate =(returnedDate-dueDate).Days;

        double LateFee=DaysLate*dailyFeeLate;
        
        return LateFee;
        
        
}
}

        





    




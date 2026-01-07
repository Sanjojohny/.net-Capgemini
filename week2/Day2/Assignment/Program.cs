using System;
using System.Collections.Generic;

namespace DigitalPettyCashLe;

class Program
{
    static void Main()
    {
        
        Ledger<IncomeTransaction> incomeLedger =new Ledger<IncomeTransaction>();
        Ledger<ExpenseTransaction> expenseLedger =new Ledger<ExpenseTransaction>();
        incomeLedger.AddEntry(new IncomeTransaction { Amount = 500, Source = "Main Cash" });

        expenseLedger.AddEntry(new ExpenseTransaction { Amount = 20, Category = "Stationery" });

        expenseLedger.AddEntry(new ExpenseTransaction { Amount = 15, Category = "Team Snacks" });
        decimal totalIncome = incomeLedger.CalculateTotal();
        decimal totalExpense = expenseLedger.CalculateTotal();
        decimal netBalance = totalIncome - totalExpense;
        
        Console.WriteLine("Total Received : $" + totalIncome);
        Console.WriteLine("Total Spent    : $" + totalExpense);
        Console.WriteLine("Net Balance    : $" + netBalance);

        

    }
}
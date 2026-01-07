using System;
using System.Collections.Generic;

namespace DigitalPettyCashLe;

public class Ledger<T> where T : Transacton
{
    private List<T> transactions = new List<T>();

    
    public void AddEntry(T entry)
    {
        transactions.Add(entry);
    }

    
    public decimal CalculateTotal()
    {
        decimal total = 0;

        foreach (T tot in transactions)
        {
            total += tot.Amount;
        }

        return total;
    }

    
    public List<T> GetAllTransactions()
    {
        return transactions;
    }

    
    public List<T> GetTransactionsByDate(DateTime date)
    {
        List<T> result = new List<T>();

        foreach (T tot in transactions)
        {
            if (tot.Date.Date == date.Date)
            {
                result.Add(tot);
            }
        }

        return result;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

public class LedgerService {
    private readonly List<Transaction> _transactions;

    public LedgerService(List<Transaction> transactions) {
        _transactions = transactions;
    } 

    public List<Transaction> GetTransactions(){
        return _transactions;
    }

    public void AddTransaction(Transaction transaction){
        _transactions.Add(transaction);
    }

    public decimal CalculateLedgerTotalAmount(){
        return _transactions.Sum(transaction => transaction.Amount);
    }

    public decimal GetLastWeekCost(){
        var lastMonday = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek - 6);
        var lastSunday = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);

        return _transactions
        .Where(transaction => 
            transaction.CreatedAt <= lastSunday 
            && transaction.CreatedAt >= lastMonday
            && transaction.Amount < 0)
        .Sum(transaction => transaction.Amount);
    }
}
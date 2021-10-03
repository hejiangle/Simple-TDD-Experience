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
}
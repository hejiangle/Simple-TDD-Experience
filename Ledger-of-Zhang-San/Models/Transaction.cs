using System;
public class Transaction {
    public Transaction(string name, decimal amount, DateTime createdAt)
    {
        ItemName = name;
        Amount = amount;
        CreatedAt = createdAt;
    }

    public string ItemName {get;}
    public decimal Amount {get;}
    public DateTime CreatedAt {get;}

    public override string ToString() => $"Item: {ItemName} | Amount: {Amount} | Created at: {CreatedAt}";

} 
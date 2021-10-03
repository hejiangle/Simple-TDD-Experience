using System.Collections.Generic;
using System;
public static class TransactionsHelper {
    public static List<Transaction> GenerateTransactions(){
        return new List<Transaction> {
                new Transaction("Milke", -10, new DateTime(2021, 8, 22)),
                new Transaction("Apple", -15, new DateTime(2021, 8, 30)),
                new Transaction("Salary", 500, new DateTime(2021, 8, 30)),
                new Transaction("Watermelon", -12, new DateTime(2021, 9, 1)),
                new Transaction("Dinner", -200, new DateTime(2021, 9, 15)),
                new Transaction("Salary", 500, new DateTime(2021, 9, 30)),
                new Transaction("Bilibli vip", -9, new DateTime(2021, 10, 1))
            };
    }
} 
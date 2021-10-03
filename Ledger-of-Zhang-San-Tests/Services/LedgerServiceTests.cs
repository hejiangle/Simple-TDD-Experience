using System.Collections.Generic;
using System;
using System.Linq;
using Xunit;

namespace Ledger_of_Zhang_San_Tests.Services
{
    public class LedgerServiceTests
    {
        [Fact]
        public void Given_TransactionsExistsBeforeLastMonday_When_GetLastWeekCostTransaction_Then_FilterOutTheTransactionsBeofreLastMonday()
        {
        //Given
            var lastMonday = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek - 6);
            var testTransactions = new List<Transaction> {
                new Transaction("A", 1, lastMonday.AddDays(-2)),
                new Transaction("B", -1, lastMonday.AddDays(-1)),
                new Transaction("C", 1, lastMonday.AddDays(0)),
                new Transaction("D", -1, lastMonday.AddDays(1)),
                new Transaction("E", -1, lastMonday.AddDays(2)),
                new Transaction("F", 1, lastMonday.AddDays(3)),
                new Transaction("G", 1, lastMonday.AddDays(4)),
                new Transaction("H", -1, lastMonday.AddDays(5)),
                new Transaction("I", 1, lastMonday.AddDays(6))
            };
            var ledgerService = new LedgerService(testTransactions);
        //When
            var result = ledgerService.GetLastWeekCostTransactions();
        //Then
            Assert.Equal(7, result.Count);
            Assert.False(result.Exists(transaction => "A".Equals(transaction.ItemName)));
            Assert.False(result.Exists(transaction => "B".Equals(transaction.ItemName)));
        }
    }
}

using System.Transactions;
using System.Collections.Generic;
using System;
using Xunit;

namespace Ledger_of_Zhang_San_Tests.Services
{
    public class LedgerServiceTests
    {
        [Fact]
        public void Given_TransactionsInLedger_When_GetLastWeekCost_Then_ReturnCorrectAmount()
        {
            //Given
            var lastMonday = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek - 6);
            var lastSunday = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);
            var testTransactions = new List<Transaction> {
                new Transaction("A", -1, lastMonday.AddDays(-1)),
                new Transaction("B", -1, lastMonday.AddDays(0)),
                new Transaction("C", -1, lastMonday.AddDays(3)),
                new Transaction("D", 1, lastMonday.AddDays(3)),
                new Transaction("E", -1, lastSunday.AddDays(0)),
                new Transaction("F", -1, lastSunday.AddDays(1)),
            };
            var ledgerService = new LedgerService(testTransactions);
            //When
            var result = ledgerService.GetLastWeekCost();
            //Then
            Assert.Equal(-3, result);
        }
    }
}

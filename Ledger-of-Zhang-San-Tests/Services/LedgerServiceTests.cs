using System;
using Xunit;

namespace Ledger_of_Zhang_San_Tests.Services
{
    public class LedgerServiceTests
    {
        private readonly LedgerService _ledgerService;

        public LedgerServiceTests() {
            var testData = TransactionsHelper.GenerateTransactions(); 
            _ledgerService = new LedgerService(testData);
        }

        [Fact]
        public void TestName()
        {
        //Given
        
        //When
        
        //Then
        }
    }
}

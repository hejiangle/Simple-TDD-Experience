using System;

namespace Ledger_of_Zhang_San
{
    class Program
    {
        private static LedgerService _ledgerService;

        static void Main(string[] args)
        {
            Console.WriteLine("I'm Zhang San, I have a ledger.");
            SetupLedger();
            Console.WriteLine("Currently, the ledger includes following items:");
            _ledgerService.GetTransactions().ForEach(item => Console.WriteLine($"{item.ToString()}"));
            var transactionsTotalAmount = _ledgerService.CalculateLedgerTotalAmount();
            Console.WriteLine($"The total amount is {transactionsTotalAmount}.");

            Console.WriteLine("Could you please help with calculating my cost in last nature week?");
        }

        private static void SetupLedger(){
            var transactions = TransactionsHelper.GenerateTransactions();
            _ledgerService = new LedgerService(transactions);
        }
    }
}

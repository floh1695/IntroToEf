using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTransactionsEf
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new TransactionDb();

            // Add random data
            var rnd = new Random();
            foreach (var _ in Enumerable.Range(0, 10))
            {
                var actionList = new string[] { "deposit", "withdraw" };
                db.Transactions.Add(new Transaction
                {
                    Timestamp = DateTime.Now.AddDays(-rnd.Next(7)),
                    Action = actionList[rnd.Next(actionList.Count())],
                    AccountNumber = rnd.Next().ToString(),
                    AmountChanged = rnd.Next(-1000, 1000),
                    NewAmount = rnd.Next(-2000, 10000),
                });
            }
            db.SaveChanges();

            Console.WriteLine("Todays transactions");
            var todaysTransactions = db.Transactions
                .Where(transaction => transaction.Timestamp >= DateTime.Today);
            foreach (var transaction in todaysTransactions)
            {
                Console.WriteLine(transaction.Timestamp);
            }

            Console.WriteLine("Last 10 transactions");
            var tenMostRecentTransactions = db.Transactions
                .OrderByDescending(transaction => transaction.Timestamp)
                .Take(10);
            foreach (var transaction in tenMostRecentTransactions)
            {
                Console.WriteLine(transaction.Timestamp);
            }

            var numberOfTransactionsToday = db.Transactions
                .Count(transaction => transaction.Timestamp >= DateTime.Today);
            Console.WriteLine($"Transactions today: {numberOfTransactionsToday}");
        }
    }
}

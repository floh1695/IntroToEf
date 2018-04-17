using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BankTransactionsEf
{
    class TransactionDb : DbContext
    {
        public TransactionDb()
            : base(@"Server=localhost\SQLEXPRESS;Database=TransactionDbEf;Trusted_Connection=True;")
        { }

        public DbSet<Transaction> Transactions { get; set; }
    }
}

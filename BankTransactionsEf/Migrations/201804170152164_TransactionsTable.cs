namespace BankTransactionsEf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TransactionsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Timestamp = c.DateTime(nullable: false),
                        Action = c.String(),
                        AccountNumber = c.String(),
                        AmountChanged = c.Decimal(nullable: false, precision: 18, scale: 2),
                        newAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Transactions");
        }
    }
}

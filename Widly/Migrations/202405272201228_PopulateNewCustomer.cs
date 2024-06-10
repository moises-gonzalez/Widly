namespace Widly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateNewCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsLetter, MembershipTypeId, BirthDate) VALUES ('John Doe', 'True', 1, '01/01/1980')");
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsLetter, MembershipTypeId, BirthDate) VALUES ('Jane Doe', 'False', 2, NULL)");
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsLetter, MembershipTypeId, BirthDate) VALUES ('Carl Doe', 'True', 3, '06/06/1980')");
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsLetter, MembershipTypeId, BirthDate) VALUES ('Lily Doe', 'False', 4, NULL)"); 
        }
        
        public override void Down()
        {
        }
    }
}

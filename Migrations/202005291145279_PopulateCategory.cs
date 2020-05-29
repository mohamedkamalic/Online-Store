namespace OnlineStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategory : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT category ON");
            Sql("INSERT INTO category (Id, Name, number_of_products) values (1,'mobiles',0)");
            Sql("INSERT INTO category (Id, Name, number_of_products) values (2,'computers',0)");
            Sql("INSERT INTO category (Id, Name, number_of_products) values (3,'clothes',0)");
            Sql("SET IDENTITY_INSERT category off");
        }
        
        public override void Down()
        {
        }
    }
}

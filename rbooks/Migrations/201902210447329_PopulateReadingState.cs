namespace rbooks.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateReadingState : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO ReadStates(Id,State) VALUES(1,'Read')");
            Sql("INSERT INTO ReadStates(Id,State) VALUES(2,'Not Read')");
            Sql("INSERT INTO ReadStates(Id,State) VALUES(3,'Dropped')");
            Sql("INSERT INTO ReadStates(Id,State) VALUES(4,'To Be Read')");
        }
        
        public override void Down()
        {
        }
    }
}

namespace rbooks.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReadingstate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ReadStates",
                c => new
                    {
                        id = c.Byte(nullable: false),
                        state = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.Books", "ReadState_id", c => c.Byte());
            CreateIndex("dbo.Books", "ReadState_id");
            AddForeignKey("dbo.Books", "ReadState_id", "dbo.ReadStates", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "ReadState_id", "dbo.ReadStates");
            DropIndex("dbo.Books", new[] { "ReadState_id" });
            DropColumn("dbo.Books", "ReadState_id");
            DropTable("dbo.ReadStates");
        }
    }
}

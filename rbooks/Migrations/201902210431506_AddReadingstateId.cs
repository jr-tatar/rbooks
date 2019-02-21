namespace rbooks.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReadingstateId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Books", "ReadState_id", "dbo.ReadStates");
            DropIndex("dbo.Books", new[] { "ReadState_id" });
            RenameColumn(table: "dbo.Books", name: "ReadState_id", newName: "ReadStateId");
            AlterColumn("dbo.Books", "ReadStateId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Books", "ReadStateId");
            AddForeignKey("dbo.Books", "ReadStateId", "dbo.ReadStates", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "ReadStateId", "dbo.ReadStates");
            DropIndex("dbo.Books", new[] { "ReadStateId" });
            AlterColumn("dbo.Books", "ReadStateId", c => c.Byte());
            RenameColumn(table: "dbo.Books", name: "ReadStateId", newName: "ReadState_id");
            CreateIndex("dbo.Books", "ReadState_id");
            AddForeignKey("dbo.Books", "ReadState_id", "dbo.ReadStates", "id");
        }
    }
}

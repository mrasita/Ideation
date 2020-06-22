namespace Ideation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MeetingTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Meetings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Status = c.String(),
                        Owner_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Owner_Id)
                .Index(t => t.Owner_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Ideas", "Meeting_Id", c => c.Int());
            AddColumn("dbo.Ideas", "Owner_Id", c => c.Int());
            CreateIndex("dbo.Ideas", "Meeting_Id");
            CreateIndex("dbo.Ideas", "Owner_Id");
            AddForeignKey("dbo.Ideas", "Meeting_Id", "dbo.Meetings", "Id");
            AddForeignKey("dbo.Ideas", "Owner_Id", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ideas", "Owner_Id", "dbo.Users");
            DropForeignKey("dbo.Ideas", "Meeting_Id", "dbo.Meetings");
            DropForeignKey("dbo.Meetings", "Owner_Id", "dbo.Users");
            DropIndex("dbo.Meetings", new[] { "Owner_Id" });
            DropIndex("dbo.Ideas", new[] { "Owner_Id" });
            DropIndex("dbo.Ideas", new[] { "Meeting_Id" });
            DropColumn("dbo.Ideas", "Owner_Id");
            DropColumn("dbo.Ideas", "Meeting_Id");
            DropTable("dbo.Users");
            DropTable("dbo.Meetings");
        }
    }
}

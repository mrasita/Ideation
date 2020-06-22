namespace Ideation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Username", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.Users", "Password", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.Users", "Role", c => c.String());
            AlterColumn("dbo.Users", "Name", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Name", c => c.String());
            DropColumn("dbo.Users", "Role");
            DropColumn("dbo.Users", "Password");
            DropColumn("dbo.Users", "Username");
        }
    }
}

namespace GamesLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBoughtGametToUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "LastBoughtGame", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "LastBoughtGame");
        }
    }
}

namespace GamesLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAnnotationsForGames : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Games", "Title", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Games", "Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Games", "Description", c => c.String());
            AlterColumn("dbo.Games", "Title", c => c.String(nullable: false));
        }
    }
}

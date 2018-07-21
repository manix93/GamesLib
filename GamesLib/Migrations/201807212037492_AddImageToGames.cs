namespace GamesLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImageToGames : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "Image", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "Image");
        }
    }
}

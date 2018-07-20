namespace GamesLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGameTitleAsRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Games", "Title", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Games", "Title", c => c.String());
        }
    }
}

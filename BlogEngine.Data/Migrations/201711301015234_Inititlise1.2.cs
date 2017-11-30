namespace BlogEngine.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inititlise12 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BlogCatagories", "Destription", c => c.String());
            DropColumn("dbo.BlogCatagories", "Content");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BlogCatagories", "Content", c => c.String());
            DropColumn("dbo.BlogCatagories", "Destription");
        }
    }
}

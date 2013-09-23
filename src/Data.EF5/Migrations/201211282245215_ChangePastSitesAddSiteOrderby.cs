namespace Data.EF5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangePastSitesAddSiteOrderby : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Site", "Orderby", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Site", "Orderby");
        }
    }
}

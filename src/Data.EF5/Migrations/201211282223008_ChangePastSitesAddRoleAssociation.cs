namespace Data.EF5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangePastSitesAddRoleAssociation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Role", "Site_Id", "dbo.Site");
            DropIndex("dbo.Role", new[] { "Site_Id" });
            RenameColumn(table: "dbo.Role", name: "Site_Id", newName: "SiteId");
            AddForeignKey("dbo.Role", "SiteId", "dbo.Site", "Id", cascadeDelete: true);
            CreateIndex("dbo.Role", "SiteId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Role", new[] { "SiteId" });
            DropForeignKey("dbo.Role", "SiteId", "dbo.Site");
            RenameColumn(table: "dbo.Role", name: "SiteId", newName: "Site_Id");
            CreateIndex("dbo.Role", "Site_Id");
            AddForeignKey("dbo.Role", "Site_Id", "dbo.Site", "Id");
        }
    }
}

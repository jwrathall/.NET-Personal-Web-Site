namespace Data.EF5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPastSites : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Site",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Client = c.String(),
                        Thumbnail = c.String(),
                        Url = c.String(),
                        Summary = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Site_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Site", t => t.Site_Id)
                .Index(t => t.Site_Id);
            
            CreateTable(
                "dbo.SiteImages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SiteId = c.Int(nullable: false),
                        ImageName = c.String(),
                        FolderName = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Site", t => t.SiteId, cascadeDelete: true)
                .Index(t => t.SiteId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.SiteImages", new[] { "SiteId" });
            DropIndex("dbo.Role", new[] { "Site_Id" });
            DropForeignKey("dbo.SiteImages", "SiteId", "dbo.Site");
            DropForeignKey("dbo.Role", "Site_Id", "dbo.Site");
            DropTable("dbo.SiteImages");
            DropTable("dbo.Role");
            DropTable("dbo.Site");
        }
    }
}

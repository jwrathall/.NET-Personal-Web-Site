namespace Data.EF5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSkillsToSites : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Skill",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SkillName = c.String(nullable: false),
                        SkillAbbreviation = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SkillsMap",
                c => new
                    {
                        SiteId = c.Int(nullable: false),
                        SkillId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SiteId, t.SkillId })
                .ForeignKey("dbo.Site", t => t.SiteId, cascadeDelete: true)
                .ForeignKey("dbo.Skill", t => t.SkillId, cascadeDelete: true)
                .Index(t => t.SiteId)
                .Index(t => t.SkillId);
            
            AddColumn("dbo.Site", "Detail", c => c.String());
        }
        
        public override void Down()
        {
            DropIndex("dbo.SkillsMap", new[] { "SkillId" });
            DropIndex("dbo.SkillsMap", new[] { "SiteId" });
            DropForeignKey("dbo.SkillsMap", "SkillId", "dbo.Skill");
            DropForeignKey("dbo.SkillsMap", "SiteId", "dbo.Site");
            DropColumn("dbo.Site", "Detail");
            DropTable("dbo.SkillsMap");
            DropTable("dbo.Skill");
        }
    }
}

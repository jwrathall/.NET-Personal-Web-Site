namespace Data.EF5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSubjectTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Subject",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Summary = c.String(),
                        OrderBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Topic",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubjectId = c.Int(nullable: false),
                        Title = c.String(),
                        Detail = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Subject", t => t.SubjectId, cascadeDelete: true)
                .Index(t => t.SubjectId);
            
            CreateTable(
                "dbo.TopicHighlight",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TopicId = c.Int(nullable: false),
                        Title = c.String(),
                        Summary = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Topic", t => t.TopicId, cascadeDelete: true)
                .Index(t => t.TopicId);
            
            DropTable("dbo.Navigation");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Navigation",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Summary = c.String(),
                        OrderBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropIndex("dbo.TopicHighlight", new[] { "TopicId" });
            DropIndex("dbo.Topic", new[] { "SubjectId" });
            DropForeignKey("dbo.TopicHighlight", "TopicId", "dbo.Topic");
            DropForeignKey("dbo.Topic", "SubjectId", "dbo.Subject");
            DropTable("dbo.TopicHighlight");
            DropTable("dbo.Topic");
            DropTable("dbo.Subject");
        }
    }
}

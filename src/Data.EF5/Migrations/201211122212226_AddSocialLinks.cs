namespace Data.EF5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSocialLinks : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Social",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Icon = c.String(),
                        Title = c.String(),
                        Url = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Social");
        }
    }
}

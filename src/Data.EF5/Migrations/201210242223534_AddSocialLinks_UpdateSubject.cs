namespace Data.EF5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSocialLinks_UpdateSubject : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Subject", "Url", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Subject", "Url");
        }
    }
}

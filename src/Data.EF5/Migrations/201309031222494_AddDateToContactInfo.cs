namespace Data.EF5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateToContactInfo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ContactInfo", "CreateDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ContactInfo", "CreateDate");
        }
    }
}

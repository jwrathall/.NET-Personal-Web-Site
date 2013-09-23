namespace Data.EF5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDatabaseAssociations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Role", "Title", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Role", "Title", c => c.String());
        }
    }
}

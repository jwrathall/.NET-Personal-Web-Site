namespace Data.EF5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDatabaseAssociations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Role", "Title", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Role", "Title", c => c.String(nullable: false));
        }
    }
}

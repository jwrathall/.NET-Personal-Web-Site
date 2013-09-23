namespace Data.EF5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSortIdSocial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Social", "Sort_Id", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Social", "Sort_Id");
        }
    }
}

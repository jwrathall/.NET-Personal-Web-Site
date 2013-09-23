namespace Data.EF5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateIconToClassName : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.Social", "Class_name", c => c.String());
           // DropColumn("dbo.Social", "Icon");
            RenameColumn("dbo.Social", "Icon", "Class_name");
        }
        
        public override void Down()
        {
           // AddColumn("dbo.Social", "Icon", c => c.String());
           // DropColumn("dbo.Social", "Class_name");
            RenameColumn("dbo.Social", "Class_name", "Icon");
        }
    }
}

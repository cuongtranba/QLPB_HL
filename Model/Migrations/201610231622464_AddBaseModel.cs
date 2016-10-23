namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBaseModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblIndexItem", "IsDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tblIndexItem", "IsDeleted");
        }
    }
}

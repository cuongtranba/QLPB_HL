namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeAvailable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblIndexStock", "StockAvailable", c => c.Int(nullable: false));
            DropColumn("dbo.tblIndexStock", "StockAvilable");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tblIndexStock", "StockAvilable", c => c.Double(nullable: false));
            DropColumn("dbo.tblIndexStock", "StockAvailable");
        }
    }
}

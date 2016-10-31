namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeStock : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tblIndexStock", "CountImportDoc", c => c.Int(nullable: false));
            AlterColumn("dbo.tblIndexStock", "CountExportDoc", c => c.Int(nullable: false));
            AlterColumn("dbo.tblIndexStock", "isFull", c => c.Boolean(nullable: false));
            AlterColumn("dbo.tblIndexStock", "StockAvilable", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tblIndexStock", "StockAvilable", c => c.Double());
            AlterColumn("dbo.tblIndexStock", "isFull", c => c.Boolean());
            AlterColumn("dbo.tblIndexStock", "CountExportDoc", c => c.Int());
            AlterColumn("dbo.tblIndexStock", "CountImportDoc", c => c.Int());
        }
    }
}

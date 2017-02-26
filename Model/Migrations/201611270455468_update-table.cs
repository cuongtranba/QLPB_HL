namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tblSoDuKho", "OpenQty", c => c.Double(nullable: false));
            AlterColumn("dbo.tblSoDuKho", "OpenUnitPrice", c => c.Double(nullable: false));
            AlterColumn("dbo.tblSoDuKho", "InPeriodQty", c => c.Double(nullable: false));
            AlterColumn("dbo.tblSoDuKho", "InputUnitPrice", c => c.Double(nullable: false));
            AlterColumn("dbo.tblSoDuKho", "OutPeriodQty", c => c.Double(nullable: false));
            AlterColumn("dbo.tblSoDuKho", "OutputUnitPrice", c => c.Double(nullable: false));
            AlterColumn("dbo.tblSoDuKho", "CloseQty", c => c.Double(nullable: false));
            AlterColumn("dbo.tblSoDuKho", "CloseUnitPrice", c => c.Double(nullable: false));
            AlterColumn("dbo.tblSoDuKho", "OpenAmount", c => c.Double(nullable: false));
            AlterColumn("dbo.tblSoDuKho", "InputAmount", c => c.Double(nullable: false));
            AlterColumn("dbo.tblSoDuKho", "OutputAmount", c => c.Double(nullable: false));
            AlterColumn("dbo.tblSoDuKho", "CloseAmount", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tblSoDuKho", "CloseAmount", c => c.Double());
            AlterColumn("dbo.tblSoDuKho", "OutputAmount", c => c.Double());
            AlterColumn("dbo.tblSoDuKho", "InputAmount", c => c.Double());
            AlterColumn("dbo.tblSoDuKho", "OpenAmount", c => c.Double());
            AlterColumn("dbo.tblSoDuKho", "CloseUnitPrice", c => c.Double());
            AlterColumn("dbo.tblSoDuKho", "CloseQty", c => c.Double());
            AlterColumn("dbo.tblSoDuKho", "OutputUnitPrice", c => c.Double());
            AlterColumn("dbo.tblSoDuKho", "OutPeriodQty", c => c.Double());
            AlterColumn("dbo.tblSoDuKho", "InputUnitPrice", c => c.Double());
            AlterColumn("dbo.tblSoDuKho", "InPeriodQty", c => c.Double());
            AlterColumn("dbo.tblSoDuKho", "OpenUnitPrice", c => c.Double());
            AlterColumn("dbo.tblSoDuKho", "OpenQty", c => c.Double());
        }
    }
}

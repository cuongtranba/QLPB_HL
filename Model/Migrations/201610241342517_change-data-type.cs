namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedatatype : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tblIndexItem", "UnitRate1", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.tblIndexItem", "UnitRate2", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.tblIndexItem", "BuyPrice", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.tblIndexItem", "SalePrice", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tblIndexItem", "SalePrice", c => c.Double());
            AlterColumn("dbo.tblIndexItem", "BuyPrice", c => c.Double());
            AlterColumn("dbo.tblIndexItem", "UnitRate2", c => c.Double());
            AlterColumn("dbo.tblIndexItem", "UnitRate1", c => c.Double());
        }
    }
}

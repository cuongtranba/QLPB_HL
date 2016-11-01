namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aaaa : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tblIndexDocument", "isLock", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tblIndexDocument", "isLock", c => c.Boolean());
        }
    }
}

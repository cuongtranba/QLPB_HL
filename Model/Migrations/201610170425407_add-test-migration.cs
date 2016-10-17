namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtestmigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblSysUser", "TestMigration", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tblSysUser", "TestMigration");
        }
    }
}

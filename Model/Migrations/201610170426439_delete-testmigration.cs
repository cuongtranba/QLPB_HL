namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletetestmigration : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.tblSysUser", "TestMigration");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tblSysUser", "TestMigration", c => c.String());
        }
    }
}

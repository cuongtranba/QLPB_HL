namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addisdeletecolumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblDataAccVote", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.tblIndexAccount", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.tblIndexBranch", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.tblIndexCurrency", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.tblIndexCurrencyExRate", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.tblIndexDocument", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.tblIndexDocumentSub", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.tblIndexDocumentType", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.tblIndexFeeGroup", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.tblIndexFee", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.tblIndexFixedAssest", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.tblIndexInOutReason", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.tblIndexItemGroup", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.tblIndexLoader", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.tblIndexObjectGroup", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.tblIndexObject", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.tblIndexObjectType", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.tblIndexPaymentMethod", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.tblIndexStock", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.tblIndexTransport", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.tblIndexUnit", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.tblKhoCanDoi", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.tblPhieuXuatTheoKho", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.tblSoDuKho", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.tblSysFunction", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.tblSysInfo", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.tblSysPara", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.tblSysUserRight", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.tblSysUser", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.tblSysWorkingLock", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.tblSysWorkingPeriod", "IsDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tblSysWorkingPeriod", "IsDeleted");
            DropColumn("dbo.tblSysWorkingLock", "IsDeleted");
            DropColumn("dbo.tblSysUser", "IsDeleted");
            DropColumn("dbo.tblSysUserRight", "IsDeleted");
            DropColumn("dbo.tblSysPara", "IsDeleted");
            DropColumn("dbo.tblSysInfo", "IsDeleted");
            DropColumn("dbo.tblSysFunction", "IsDeleted");
            DropColumn("dbo.tblSoDuKho", "IsDeleted");
            DropColumn("dbo.tblPhieuXuatTheoKho", "IsDeleted");
            DropColumn("dbo.tblKhoCanDoi", "IsDeleted");
            DropColumn("dbo.tblIndexUnit", "IsDeleted");
            DropColumn("dbo.tblIndexTransport", "IsDeleted");
            DropColumn("dbo.tblIndexStock", "IsDeleted");
            DropColumn("dbo.tblIndexPaymentMethod", "IsDeleted");
            DropColumn("dbo.tblIndexObjectType", "IsDeleted");
            DropColumn("dbo.tblIndexObject", "IsDeleted");
            DropColumn("dbo.tblIndexObjectGroup", "IsDeleted");
            DropColumn("dbo.tblIndexLoader", "IsDeleted");
            DropColumn("dbo.tblIndexItemGroup", "IsDeleted");
            DropColumn("dbo.tblIndexInOutReason", "IsDeleted");
            DropColumn("dbo.tblIndexFixedAssest", "IsDeleted");
            DropColumn("dbo.tblIndexFee", "IsDeleted");
            DropColumn("dbo.tblIndexFeeGroup", "IsDeleted");
            DropColumn("dbo.tblIndexDocumentType", "IsDeleted");
            DropColumn("dbo.tblIndexDocumentSub", "IsDeleted");
            DropColumn("dbo.tblIndexDocument", "IsDeleted");
            DropColumn("dbo.tblIndexCurrencyExRate", "IsDeleted");
            DropColumn("dbo.tblIndexCurrency", "IsDeleted");
            DropColumn("dbo.tblIndexBranch", "IsDeleted");
            DropColumn("dbo.tblIndexAccount", "IsDeleted");
            DropColumn("dbo.tblDataAccVote", "IsDeleted");
        }
    }
}

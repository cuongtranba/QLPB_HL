using System;
using System.Reflection;

namespace Model
{
    using System.Data.Entity;

    public partial class HongLienDb : DbContext
    {
        public HongLienDb()
            : base("name=HongLienDb")
        {
        }

        public virtual DbSet<tblDataAccVote> tblDataAccVotes { get; set; }
        public virtual DbSet<tblIndexAccount> tblIndexAccounts { get; set; }
        public virtual DbSet<tblIndexBranch> tblIndexBranches { get; set; }
        public virtual DbSet<tblIndexCurrency> tblIndexCurrencies { get; set; }
        public virtual DbSet<tblIndexCurrencyExRate> tblIndexCurrencyExRates { get; set; }
        public virtual DbSet<tblIndexDocument> tblIndexDocuments { get; set; }
        public virtual DbSet<tblIndexDocumentSub> tblIndexDocumentSubs { get; set; }
        public virtual DbSet<tblIndexDocumentType> tblIndexDocumentTypes { get; set; }
        public virtual DbSet<tblIndexFee> tblIndexFees { get; set; }
        public virtual DbSet<tblIndexFeeGroup> tblIndexFeeGroups { get; set; }
        public virtual DbSet<tblIndexFixedAssest> tblIndexFixedAssests { get; set; }
        public virtual DbSet<tblIndexInOutReason> tblIndexInOutReasons { get; set; }
        public virtual DbSet<tblIndexItem> tblIndexItems { get; set; }
        public virtual DbSet<tblIndexItemGroup> tblIndexItemGroups { get; set; }
        public virtual DbSet<tblIndexLoader> tblIndexLoaders { get; set; }
        public virtual DbSet<tblIndexObject> tblIndexObjects { get; set; }
        public virtual DbSet<tblIndexObjectGroup> tblIndexObjectGroups { get; set; }
        public virtual DbSet<tblIndexObjectType> tblIndexObjectTypes { get; set; }
        public virtual DbSet<tblIndexPaymentMethod> tblIndexPaymentMethods { get; set; }
        public virtual DbSet<tblIndexStock> tblIndexStocks { get; set; }
        public virtual DbSet<tblIndexTransport> tblIndexTransports { get; set; }
        public virtual DbSet<tblIndexUnit> tblIndexUnits { get; set; }
        public virtual DbSet<tblKhoCanDoi> tblKhoCanDois { get; set; }
        public virtual DbSet<tblPhieuXuatTheoKho> tblPhieuXuatTheoKhoes { get; set; }
        public virtual DbSet<tblSoDuKho> tblSoDuKhoes { get; set; }
        public virtual DbSet<tblSysFunction> tblSysFunctions { get; set; }
        public virtual DbSet<tblSysInfo> tblSysInfoes { get; set; }
        public virtual DbSet<tblSysPara> tblSysParas { get; set; }
        public virtual DbSet<tblSysUser> tblSysUsers { get; set; }
        public virtual DbSet<tblSysUserRight> tblSysUserRights { get; set; }
        public virtual DbSet<tblSysWorkingLock> tblSysWorkingLocks { get; set; }
        public virtual DbSet<tblSysWorkingPeriod> tblSysWorkingPeriods { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblDataAccVote>().Map(m =>
            {
                m.MapInheritedProperties();
            });
            modelBuilder.Entity<tblIndexAccount>().Map(m =>
            {
                m.MapInheritedProperties();
            });
            modelBuilder.Entity<tblIndexBranch>().Map(m =>
            {
                m.MapInheritedProperties();
            });
            modelBuilder.Entity<tblIndexCurrency>().Map(m =>
            {
                m.MapInheritedProperties();
            });
            modelBuilder.Entity<tblIndexCurrencyExRate>().Map(m =>
            {
                m.MapInheritedProperties();
            });
            modelBuilder.Entity<tblIndexDocument>().Map(m =>
            {
                m.MapInheritedProperties();
            });
            modelBuilder.Entity<tblIndexDocumentSub>().Map(m =>
            {
                m.MapInheritedProperties();
            });
            modelBuilder.Entity<tblIndexDocumentType>().Map(m =>
            {
                m.MapInheritedProperties();
            });
            modelBuilder.Entity<tblIndexFee>().Map(m =>
            {
                m.MapInheritedProperties();
            });
            modelBuilder.Entity<tblIndexFeeGroup>().Map(m =>
            {
                m.MapInheritedProperties();
            });
            modelBuilder.Entity<tblIndexFixedAssest>().Map(m =>
            {
                m.MapInheritedProperties();
            });
            modelBuilder.Entity<tblIndexInOutReason>().Map(m =>
            {
                m.MapInheritedProperties();
            });
            modelBuilder.Entity<tblIndexItem>().Map(m =>
            {
                m.MapInheritedProperties();
            });
            modelBuilder.Entity<tblIndexItemGroup>().Map(m =>
            {
                m.MapInheritedProperties();
            });
            modelBuilder.Entity<tblIndexLoader>().Map(m =>
            {
                m.MapInheritedProperties();
            });
            modelBuilder.Entity<tblIndexObject>().Map(m =>
            {
                m.MapInheritedProperties();
            });
            modelBuilder.Entity<tblIndexObjectGroup>().Map(m =>
            {
                m.MapInheritedProperties();
            });
            modelBuilder.Entity<tblIndexObjectType>().Map(m =>
            {
                m.MapInheritedProperties();
            });
            modelBuilder.Entity<tblIndexPaymentMethod>().Map(m =>
            {
                m.MapInheritedProperties();
            });
            modelBuilder.Entity<tblIndexStock>().Map(m =>
            {
                m.MapInheritedProperties();
            });
            modelBuilder.Entity<tblIndexTransport>().Map(m =>
            {
                m.MapInheritedProperties();
            });
            modelBuilder.Entity<tblIndexUnit>().Map(m =>
            {
                m.MapInheritedProperties();
            });
            modelBuilder.Entity<tblKhoCanDoi>().Map(m =>
            {
                m.MapInheritedProperties();
            });
            modelBuilder.Entity<tblPhieuXuatTheoKho>().Map(m =>
            {
                m.MapInheritedProperties();
            });
            modelBuilder.Entity<tblSoDuKho>().Map(m =>
            {
                m.MapInheritedProperties();
            });
            modelBuilder.Entity<tblSysFunction>().Map(m =>
            {
                m.MapInheritedProperties();
            });
            modelBuilder.Entity<tblSysInfo>().Map(m =>
            {
                m.MapInheritedProperties();
            });
            modelBuilder.Entity<tblSysPara>().Map(m =>
            {
                m.MapInheritedProperties();
            });
            modelBuilder.Entity<tblSysUser>().Map(m =>
            {
                m.MapInheritedProperties();
            });
            modelBuilder.Entity<tblSysUserRight>().Map(m =>
            {
                m.MapInheritedProperties();
            });
            modelBuilder.Entity<tblSysWorkingLock>().Map(m =>
            {
                m.MapInheritedProperties();
            });
            modelBuilder.Entity<tblSysWorkingPeriod>().Map(m =>
            {
                m.MapInheritedProperties();
            });
        }
    }
}

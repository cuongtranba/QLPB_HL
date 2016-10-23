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
            modelBuilder.Entity<tblIndexItem>().Map(m =>
            {
                m.MapInheritedProperties();
            });
        }
    }
}

﻿using Microsoft.EntityFrameworkCore;
using NiksoftCore.DataAccess;

namespace NiksoftCore.Bourse.Service
{
    public class BourseDbContext : NikDbContext, IBourseUnitOfWork
    {

        public BourseDbContext(string connectionString) : base(connectionString)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        public DbSet<BourseUser> Users { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<UserBankAccount> UserBankAccounts { get; set; }
        public DbSet<Fee> Fees { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<BranchMaster> BranchMasters { get; set; }
        public DbSet<BranchMarketer> BranchMarketers { get; set; }
        public DbSet<BranchConsultant> BranchConsultants { get; set; }
        public DbSet<BranchUser> BranchUsers { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<MediaCategory> MediaCategories { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<ContractFee> ContractFees { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new BourseUserMap());
            builder.ApplyConfiguration(new UserProfileMap());
            builder.ApplyConfiguration(new UserBankAccountMap());
            builder.ApplyConfiguration(new FeeMap());
            builder.ApplyConfiguration(new BranchMap());
            builder.ApplyConfiguration(new BranchMasterMap());
            builder.ApplyConfiguration(new BranchMarketerMap());
            builder.ApplyConfiguration(new BranchConsultantMap());
            builder.ApplyConfiguration(new BranchUserMap());
            builder.ApplyConfiguration(new ContractMap());
            builder.ApplyConfiguration(new MediaCategoryMap());
            builder.ApplyConfiguration(new MediaMap());
            builder.ApplyConfiguration(new ContractFeeMap());
        }
    }
}

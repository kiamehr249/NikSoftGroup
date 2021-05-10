﻿using Microsoft.EntityFrameworkCore;
using NiksoftCore.DataAccess;

namespace NiksoftCore.SystemBase.Service
{
    public class SystemBaseDbContext : NikDbContext, ISystemUnitOfWork
    {

        public SystemBaseDbContext(string connectionString) : base(connectionString)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        public DbSet<SystemSetting> SystemSettings { get; set; }
        public DbSet<PanelMenu> PanelMenus { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<SystemFile> SystemFiles { get; set; }
        public DbSet<ContentCategory> ContentCategories { get; set; }
        public DbSet<GeneralContent> GeneralContents { get; set; }
        public DbSet<ContentFile> ContentFiles { get; set; }
        public DbSet<MenuCategory> MenuCategories { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<NikUser> NikUsers { get; set; }
        public DbSet<NikRole> NikRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new SystemSettingMap());
            builder.ApplyConfiguration(new PanelMenuMap());
            builder.ApplyConfiguration(new UserProfileMap());
            builder.ApplyConfiguration(new CountryMap());
            builder.ApplyConfiguration(new ProvinceMap());
            builder.ApplyConfiguration(new CityMap());
            builder.ApplyConfiguration(new SystemFileMap());
            builder.ApplyConfiguration(new ContentCategoryMap());
            builder.ApplyConfiguration(new GeneralContentMap());
            builder.ApplyConfiguration(new ContentFileMap());
            builder.ApplyConfiguration(new MenuCategoryMap());
            builder.ApplyConfiguration(new MenuMap());
            builder.ApplyConfiguration(new NikUserMap());
            builder.ApplyConfiguration(new NikRoleMap());
        }
    }
}

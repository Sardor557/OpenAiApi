using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using System.Linq;
using Toolbelt.ComponentModel.DataAnnotations;
using System;
using OpenAiApi.Database.Extensions;
using OpenAiApi.Database.Models;

namespace OpenAiApi.Database
{
    public sealed partial class MyDbContext : DbContext
    {

        #region dbSet
        public DbSet<tbTelegramUser> tbTelegramUsers { get; set; }
        public DbSet<tbTelegramUserMessage> tbTelegramUserMessages { get; set; }
        public DbSet<tbUser> tbUsers { get; set; }
        #endregion

        
        public MyDbContext(DbContextOptions options) : base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Seed();
            modelBuilder.BuildIndexesFromAnnotations();

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
        }

        public DbConnection GetDbConnection()
        {
            return Database.GetDbConnection();
        }
    }
}
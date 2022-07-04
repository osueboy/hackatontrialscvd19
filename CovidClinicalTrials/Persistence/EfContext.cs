using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class EfContext : DbContext
    {
        public DbSet<ClinicalTrialRecord> Trials { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public string DbPath { get; }

        public EfContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "covid.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClinicalTrialRecord>()
                .OwnsOne(x => x.Inclusion);
        }
    }
}
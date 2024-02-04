using Microsoft.EntityFrameworkCore;
using System.IO;

namespace QoutationProject.DbSets
{
    internal class MainDbContext : DbContext
    {
        public MainDbContext()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = @$"Data Source = {Environment.CurrentDirectory}\Qoutation\Database.db";
            optionsBuilder.UseSqlite(path);
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Items> Items { get; set; }
        public DbSet<CurrencyPrice> CurrencyPrices { get; set; }
    }
}
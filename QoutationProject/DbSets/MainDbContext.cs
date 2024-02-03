using Microsoft.EntityFrameworkCore;

namespace QoutationProject.DbSets
{
    internal class MainDbContext : DbContext
    {
        public MainDbContext()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = " + Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\Database.db");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Items> Items { get; set; }
        public DbSet<CurrencyPrice> CurrencyPrices { get; set; }
    }
}
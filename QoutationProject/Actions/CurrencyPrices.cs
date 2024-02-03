namespace QoutationProject.Actions
{
    internal class CurrencyPrices
    {
        private readonly DbSets.MainDbContext db;
        public CurrencyPrices()
        {
            db = new DbSets.MainDbContext();
        }
        internal bool AddCurrencyPrices(DbSets.CurrencyPrice currencyPrice)
        {
            bool result = true;
            try
            {
                db.CurrencyPrices.Add(currencyPrice);
                db.SaveChanges();
            }
            catch
            {
                result = false;
            }
            finally
            {
                db.Dispose();
            }
            return result;
        }
        internal List<DbSets.CurrencyPrice> GetCurrencyPrices
        {
            get
            {
                DbSets.MainDbContext dbContext = new();
                try
                {
                    return dbContext.CurrencyPrices.ToList();
                }
                catch { return new(); }
                finally
                {
                    dbContext.Dispose();
                }
            }
        }
    }
}

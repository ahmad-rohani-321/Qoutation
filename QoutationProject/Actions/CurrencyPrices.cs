using Microsoft.EntityFrameworkCore;
namespace QoutationProject.Actions
{
    internal class CurrencyPrices : IDisposable
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
                db.Database.OpenConnection();
                db.CurrencyPrices.Add(currencyPrice);
                db.SaveChanges();
            }
            catch
            {
                result = false;
            }
            finally
            {
                db.Database.CloseConnection();
            }
            return result;
        }

        internal List<DbSets.CurrencyPrice> GetCurrencyPrices
        {
            get
            {
                try
                {
                    db.Database.OpenConnection();
                    return db.CurrencyPrices.ToList();
                }
                catch { return new(); }
                finally
                {
                    db.Database.CloseConnection();
                }
            }
        }
        internal int Count
        {
            get
            {
                try
                {
                    return db.CurrencyPrices.Count();
                }
                catch { return 0; }
                finally
                {
                    db.Database.CloseConnection();
                }
            }
        }
        internal DbSets.CurrencyPrice GetLastCurrencyPrice
        {
            get
            {
                try
                {
                    return db.CurrencyPrices.OrderByDescending(x => x.Id).FirstOrDefault()!;
                }
                catch { return default!; }
                finally { db.Database.CloseConnection(); }
            }
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
using Microsoft.EntityFrameworkCore;
using QoutationProject.DbSets;
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
                if (db.Items.Count() > 0)
                {
                    foreach (var item in db.Items)
                    {
                        item.DollarPrice = decimal.Round(item.FinalPrice / currencyPrice.DollarPrice, 3);
                        item.AfghaniPrice = decimal.Round(item.DollarPrice * currencyPrice.AghaniPrice, 3);
                        item.KaldarPrice = decimal.Round(item.DollarPrice * currencyPrice.KaldarPrice, 3);
                    }
                }
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
        internal bool Update(DbSets.CurrencyPrice currency)
        {
            try
            {
                DbSets.CurrencyPrice price = db.CurrencyPrices.SingleOrDefault(x => x.Id == currency.Id);
                price.DollarPrice = currency.DollarPrice;
                price.AghaniPrice = currency.AghaniPrice;
                price.KaldarPrice = currency.KaldarPrice;
                foreach (var item in db.Items)
                {
                    if (item.FinalPrice > 0)
                    {
                        item.DollarPrice = decimal.Round(item.FinalPrice / price.DollarPrice, 3);
                    }
                    item.AfghaniPrice = decimal.Round(item.DollarPrice * price.AghaniPrice, 3);
                    item.KaldarPrice = decimal.Round(item.DollarPrice * price.KaldarPrice, 3);
                }

                db.SaveChanges();
                return true;
            }
            catch { return false; }
            finally { db.Database.CloseConnection(); }
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
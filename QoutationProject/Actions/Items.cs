using Microsoft.EntityFrameworkCore;
using QoutationProject.DbSets;
namespace QoutationProject.Actions
{
    internal class Items : IDisposable
    {
        private MainDbContext db;
        public Items()
        {
            db = new MainDbContext();
        }
        internal List<DbSets.Items> GetItems
        {
            get
            {
                try
                {
                    db.Database.OpenConnection();
                    return db.Items.ToList();
                }
                catch { return new(); }
                finally
                {
                    db.Database.CloseConnection();
                }
            }
        }
        internal bool Add(DbSets.Items item)
        {
            try
            {
                db.Database.OpenConnection();
                db.Items.Add(item);
                db.SaveChanges();
                return true;
            }
            catch { return false; }
            finally
            {
                db.Database.CloseConnection();
            }
        }
        internal bool Update(DbSets.Items item)
        {
            try
            {
                db.Database.OpenConnection();
                DbSets.Items i = db.Items.SingleOrDefault(x => x.Id == item.Id)!;
                i.ItemName = item.ItemName;
                i.PurchasePrice = item.PurchasePrice;
                i.DollarPrice = item.DollarPrice; ;
                i.KaldarPrice = item.KaldarPrice;
                i.FinalPrice = item.FinalPrice;
                i.AfghaniPrice = item.AfghaniPrice;
                i.ProfitPercentage = item.ProfitPercentage;
                db.SaveChanges();
                return true;
            }
            catch { return false; }
            finally { db.Database.CloseConnection(); }
        }
        internal bool Delete(int id)
        {
            try
            {
                db.Items.Remove(db.Items.SingleOrDefault(x => x.Id==id)!);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
            finally { db.Database.CloseConnection(); }
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}

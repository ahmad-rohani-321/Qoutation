using QoutationProject.DbSets;
namespace QoutationProject.Actions
{
    internal class Items
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
                    return db.Items.ToList();
                }
                catch { return new(); }
            }
        }
        internal bool Add(DbSets.Items item)
        {
            try
            {
                db.Items.Add(item);
                db.SaveChanges();
                return true;
            }
            catch { return false; }
        }
        internal bool Update(DbSets.Items item)
        {
            try
            {
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
        }
        ~Items()
        {
            db.Dispose();
        }
    }
}

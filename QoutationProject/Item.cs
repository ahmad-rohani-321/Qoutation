using DevExpress.XtraScheduler.Commands;

namespace QoutationProject
{
    public partial class Item : DevExpress.XtraEditors.XtraForm
    {
        private readonly DbSets.Items _item = null!;
        private readonly DbSets.CurrencyPrice _currencyPrice = default!;
        public Item()
        {
            InitializeComponent();
            Actions.CurrencyPrices cur = new Actions.CurrencyPrices();
            _currencyPrice = cur.GetLastCurrencyPrice;
            cur.Dispose();
        }
        public Item(DbSets.Items item)
        {
            InitializeComponent();
            _item = item;
            Actions.CurrencyPrices cur = new Actions.CurrencyPrices();
            _currencyPrice = cur.GetLastCurrencyPrice;
            cur.Dispose();
            TxtId.EditValue = _item.Id;
            TxtItemName.Text = _item.ItemName;
            TxtPurchasePrice.Value = _item.PurchasePrice;
            TxtPercentage.Value = _item.ProfitPercentage;
            TxtFinalPrice.Value = _item.FinalPrice;
            TxtDollarPrice.Value = _item.DollarPrice;
            TxtAfghaniPrice.Value = _item.AfghaniPrice;
            TxtKaldarPrice.Value = _item.KaldarPrice;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Valid())
            {
                Actions.Items items = new Actions.Items();
                if (_item != null)
                {
                    DbSets.Items item = new()
                    {
                        Id = _item.Id,
                        ItemName = TxtItemName.Text,
                        DollarPrice = TxtDollarPrice.Value,
                        AfghaniPrice = TxtAfghaniPrice.Value,
                        FinalPrice = TxtFinalPrice.Value,
                        KaldarPrice = TxtKaldarPrice.Value,
                        ProfitPercentage = TxtPercentage.Value,
                        PurchasePrice = TxtPurchasePrice.Value,
                    };
                    bool updated = items.Update(item);
                    if (updated)
                    {
                        Defaults.MessageBox("جنس سو تغیر");
                        this.Close();
                    }
                    else
                    {
                        Defaults.MessageBox("جنس نه سو تغیر");
                    }
                }
                else
                {
                    DbSets.Items item = new()
                    {
                        ItemName = TxtItemName.Text,
                        DollarPrice = TxtDollarPrice.Value,
                        AfghaniPrice = TxtAfghaniPrice.Value,
                        FinalPrice = TxtFinalPrice.Value,
                        KaldarPrice = TxtKaldarPrice.Value,
                        ProfitPercentage = TxtPercentage.Value,
                        PurchasePrice = TxtPurchasePrice.Value,
                    };
                    bool added = items.Add(item);
                    if (added)
                    {
                        Defaults.MessageBox("نوی جنس اضافه سو");
                        this.Close();
                    }
                    else
                    {
                        Defaults.MessageBox("نوس جنس اضافه نه سو");
                    }
                }
            }
        }

        private bool Valid()
        {
            bool result = true;
            if (TxtItemName.Text.Length < 0)
            {
                TxtItemName.ErrorText = "د جنس نوم ورسوئ";
                result = false;
            }
            else
            {
                TxtItemName.ErrorText = default!;
            }
            if (TxtPurchasePrice.Value < 0)
            {
                TxtPurchasePrice.ErrorText = "قیمت تر صفر مه کموئ";
                result = false;
            }
            else
            {
                TxtPurchasePrice.ErrorText = default!;
            }
            if (TxtPercentage.Value < 0 || TxtPercentage.Value > 100)
            {
                TxtPercentage.ErrorText = "فیصدي تر صفر مه کوئ او مه يې هم اضافه کوئ";
                result = false;
            }
            else
            {
                TxtPercentage.ErrorText = default!;
            }
            if (TxtDollarPrice.Value < 0)
            {
                TxtDollarPrice.ErrorText = "قیمت تر صفر مه کموئ";
                result = false;
            }
            else
            {
                TxtDollarPrice.ErrorText = default!;
            }
            return result;
        }

        private void TxtPurchasePrice_EditValueChanged(object sender, EventArgs e)
        {
            calculatePurchase();
        }

        private void TxtPercentage_EditValueChanged(object sender, EventArgs e)
        {
            calculatePurchase();
        }
        private void calculatePurchase()
        {
            TxtFinalPrice.Value = Math.Round((TxtPurchasePrice.Value + ((TxtPercentage.Value * TxtPurchasePrice.Value) / 100)), 3);
            TxtDollarPrice.Value = Math.Round((TxtFinalPrice.Value / _currencyPrice.DollarPrice), 3);
        }

        private void TxtDollarPrice_EditValueChanged(object sender, EventArgs e)
        {
            calculateCurrencyPrice();
        }

        private void calculateCurrencyPrice()
        {
            TxtAfghaniPrice.Value = Math.Round((TxtDollarPrice.Value * _currencyPrice.AghaniPrice), 3);
            TxtKaldarPrice.Value = Math.Round((TxtDollarPrice.Value * _currencyPrice.KaldarPrice), 3);
        }
    }
}
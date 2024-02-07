using DevExpress.XtraEditors;
using DevExpress.XtraSpreadsheet.Forms;
namespace QoutationProject
{
    public partial class CurrencyPrice : XtraForm
    {
        private readonly Actions.CurrencyPrices currencyPrices;
        private readonly DbSets.CurrencyPrice currency;
        public CurrencyPrice()
        {
            InitializeComponent();
            currencyPrices = new();
            currency = currencyPrices.GetLastCurrencyPrice;
            if (currency != null)
            {
                TxtDollarToAfghani.Value = currency.AghaniPrice;
                TxtDollarToKaldar.Value = currency.KaldarPrice;
                TxtYenToDollar.Value = currency.DollarPrice;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Valid())
            {
                if (currency == null)
                {
                    DbSets.CurrencyPrice currencyPrice = new DbSets.CurrencyPrice()
                    {
                        AghaniPrice = TxtDollarToAfghani.Value,
                        KaldarPrice = TxtDollarToKaldar.Value,
                        DollarPrice = TxtYenToDollar.Value,
                        Date = DateOnly.FromDateTime(DateTime.Now)
                    };
                    bool added = currencyPrices.AddCurrencyPrices(currencyPrice);
                    if (added)
                    {
                        Defaults.MessageBox("عملیه تکمیل سوه");
                        Close();

                    }
                    else
                    {
                        Defaults.MessageBox("عملیه تکمیل نه سوه");
                    }
                }
                else
                {
                    DbSets.CurrencyPrice currencyPrice = new DbSets.CurrencyPrice()
                    {
                        Id = currency.Id,
                        AghaniPrice = TxtDollarToAfghani.Value,
                        KaldarPrice = TxtDollarToKaldar.Value,
                        DollarPrice = TxtYenToDollar.Value
                    };
                    bool update = currencyPrices.Update(currencyPrice);
                    if (update)
                    {
                        Defaults.MessageBox("عملیه تکمیل سوه");
                        Close();
                    }
                    else
                    {
                        Defaults.MessageBox("عملیه تکمیل نه سوه");
                    }
                }
            }
        }

        private bool Valid()
        {
            bool result = true;
            if (TxtDollarToAfghani.Value <= 0)
            {
                TxtDollarToAfghani.ErrorText = "صفر عدد نه منل کیږي";
                result = false;
            }
            else
            {
                TxtDollarToAfghani.ErrorText = default!;
            }
            if (TxtDollarToKaldar.Value <= 0)
            {
                TxtDollarToKaldar.ErrorText = "صفر عدد نه منل کیږي";
                result = false;
            }
            else
            {
                TxtDollarToKaldar.ErrorText = default!;
            }
            return result;
        }
    }
}
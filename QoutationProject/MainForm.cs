using DevExpress.Mvvm.Native;

namespace QoutationProject
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnNewItem_Click(object sender, EventArgs e)
        {
            using (Actions.CurrencyPrices currency = new())
            {
                if (currency.Count != 0)
                {
                    Item item = new Item();
                    item.ShowDialog();
                    item.Dispose();
                    Actions.Items items = new();
                    gridItems.DataSource = items.GetItems;
                    items.Dispose();
                }
                else
                {
                    Defaults.MessageBox("هیله ده د اسعارو قیمتونه ورسوئ");
                }
            }
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            if (viewItems.SelectedRowsCount == 1)
            {
                DbSets.Items item = (DbSets.Items)viewItems.GetFocusedRow();
                Item i = new Item();
                i.ShowDialog();
                i.Dispose();
                Actions.Items items = new();
                gridItems.DataSource = items.GetItems;
                gridItems.RefreshDataSource();
            }
        }

        private void btnEditPrice_Click(object sender, EventArgs e)
        {
            CurrencyPrice currencyPrice = new CurrencyPrice();
            currencyPrice.ShowDialog();
            currencyPrice.Dispose();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new();
            fileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                viewItems.ExportToXlsx(fileDialog.FileName);
            }
            fileDialog.Dispose();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            Actions.Items item = new();
            gridItems.DataSource = item.GetItems;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (viewItems.SelectedRowsCount > 0)
            {
                if (Defaults.YesNoMessageBox("غواړي جنس ډیلیټ کړئ") == DialogResult.Yes)
                {
                    Actions.Items item = new();
                    if (item.Delete((int)viewItems.GetFocusedRowCellValue("Id")))
                    {
                        gridItems.DataSource = item.GetItems;
                    }
                    item.Dispose();
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Defaults.YesNoMessageBox("غواړئ فورم بند کړئ") == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnResetDatabase_Click(object sender, EventArgs e)
        {
            ResetDatabase d = new ResetDatabase();
            d.ShowDialog();
            d.Dispose();
        }
    }
}
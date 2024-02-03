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
            Item item = new Item();
            item.ShowDialog();
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.ShowDialog();
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
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Actions.Items item = new();
            gridItems.DataSource = item.GetItems;
        }
    }
}
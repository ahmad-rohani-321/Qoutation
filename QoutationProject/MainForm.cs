﻿using DevExpress.Mvvm.Native;
using DevExpress.XtraReports.UI;
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
                Item i = new Item(item);
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
            PrintItems print = new();
            print.DataSource = gridItems.DataSource;
            print.CreateDocument();
            ReportPrintTool tool = new(print);
            tool.ShowPreviewDialog();
            tool.Dispose();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            Actions.Items item = new();
            gridItems.DataSource = item.GetItems;
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
        private void btnItemDelete_Click(object sender, EventArgs e)
        {
            if (viewItems.SelectedRowsCount > 0)
            {
                if (Defaults.YesNoMessageBox("غواړي جنس ډیلیټ کړئ") == DialogResult.Yes)
                {
                    Actions.Items item = new();
                    if (item.Delete((int)viewItems.GetFocusedRowCellValue("Id")))
                    {
                        gridItems.DataSource = item.GetItems;
                        gridItems.RefreshDataSource();
                        gridItems.Refresh();
                    }
                    item.Dispose();
                }
            }
        }
        private void btnRefreshPage_Click(object sender, EventArgs e)
        {
            Actions.Items item = new();
            gridItems.DataSource = item.GetItems;
            gridItems.RefreshDataSource();
            gridItems.Refresh();
        }
    }
}
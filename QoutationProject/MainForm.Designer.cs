namespace QoutationProject
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            btnPrint = new DevExpress.XtraEditors.SimpleButton();
            btnEditPrice = new DevExpress.XtraEditors.SimpleButton();
            btnEditItem = new DevExpress.XtraEditors.SimpleButton();
            btnNewItem = new DevExpress.XtraEditors.SimpleButton();
            gridItems = new DevExpress.XtraGrid.GridControl();
            viewItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(btnPrint);
            layoutControl1.Controls.Add(btnEditPrice);
            layoutControl1.Controls.Add(btnEditItem);
            layoutControl1.Controls.Add(btnNewItem);
            layoutControl1.Controls.Add(gridItems);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(1358, 668);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(916, 16);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(131, 34);
            btnPrint.StyleController = layoutControl1;
            btnPrint.TabIndex = 5;
            btnPrint.Text = "ایکسیل";
            btnPrint.Click += btnPrint_Click;
            // 
            // btnEditPrice
            // 
            btnEditPrice.Location = new Point(1053, 16);
            btnEditPrice.Name = "btnEditPrice";
            btnEditPrice.Size = new Size(123, 34);
            btnEditPrice.StyleController = layoutControl1;
            btnEditPrice.TabIndex = 3;
            btnEditPrice.Text = "د اسعارو روز نرخ";
            btnEditPrice.Click += btnEditPrice_Click;
            // 
            // btnEditItem
            // 
            btnEditItem.Location = new Point(1182, 16);
            btnEditItem.Name = "btnEditItem";
            btnEditItem.Size = new Size(77, 34);
            btnEditItem.StyleController = layoutControl1;
            btnEditItem.TabIndex = 2;
            btnEditItem.Text = "تغیر جنس";
            btnEditItem.Click += btnEditItem_Click;
            // 
            // btnNewItem
            // 
            btnNewItem.Location = new Point(1265, 16);
            btnNewItem.Name = "btnNewItem";
            btnNewItem.Size = new Size(77, 34);
            btnNewItem.StyleController = layoutControl1;
            btnNewItem.TabIndex = 0;
            btnNewItem.Text = "نوی جنس";
            btnNewItem.Click += btnNewItem_Click;
            // 
            // gridItems
            // 
            gridItems.Location = new Point(16, 56);
            gridItems.MainView = viewItems;
            gridItems.Name = "gridItems";
            gridItems.Size = new Size(1326, 596);
            gridItems.TabIndex = 4;
            gridItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { viewItems });
            // 
            // viewItems
            // 
            viewItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn2, gridColumn3, gridColumn4, gridColumn5, gridColumn6, gridColumn7, gridColumn8 });
            viewItems.GridControl = gridItems;
            viewItems.Name = "viewItems";
            viewItems.OptionsBehavior.Editable = false;
            viewItems.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            gridColumn1.Caption = "شمېره";
            gridColumn1.FieldName = "Id";
            gridColumn1.MinWidth = 25;
            gridColumn1.Name = "gridColumn1";
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            gridColumn2.Caption = "جنس نوم";
            gridColumn2.FieldName = "ItemName";
            gridColumn2.MinWidth = 25;
            gridColumn2.Name = "gridColumn2";
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 1;
            gridColumn2.Width = 300;
            // 
            // gridColumn3
            // 
            gridColumn3.Caption = "خرید نرخ";
            gridColumn3.FieldName = "PurchasePrice";
            gridColumn3.MinWidth = 25;
            gridColumn3.Name = "gridColumn3";
            gridColumn3.Visible = true;
            gridColumn3.VisibleIndex = 2;
            gridColumn3.Width = 165;
            // 
            // gridColumn4
            // 
            gridColumn4.Caption = "ګټه او مصرف";
            gridColumn4.FieldName = "ProfitPercent";
            gridColumn4.MinWidth = 25;
            gridColumn4.Name = "gridColumn4";
            gridColumn4.Visible = true;
            gridColumn4.VisibleIndex = 3;
            gridColumn4.Width = 165;
            // 
            // gridColumn5
            // 
            gridColumn5.Caption = "تمام شد نرخ";
            gridColumn5.FieldName = "FinalPrice";
            gridColumn5.MinWidth = 25;
            gridColumn5.Name = "gridColumn5";
            gridColumn5.Visible = true;
            gridColumn5.VisibleIndex = 4;
            gridColumn5.Width = 165;
            // 
            // gridColumn6
            // 
            gridColumn6.Caption = "ډالر نرخ";
            gridColumn6.FieldName = "DollarPrice";
            gridColumn6.MinWidth = 25;
            gridColumn6.Name = "gridColumn6";
            gridColumn6.Visible = true;
            gridColumn6.VisibleIndex = 5;
            gridColumn6.Width = 165;
            // 
            // gridColumn7
            // 
            gridColumn7.Caption = "افغانۍ نرخ";
            gridColumn7.FieldName = "AfghaniPrice";
            gridColumn7.MinWidth = 25;
            gridColumn7.Name = "gridColumn7";
            gridColumn7.Visible = true;
            gridColumn7.VisibleIndex = 6;
            gridColumn7.Width = 100;
            // 
            // gridColumn8
            // 
            gridColumn8.Caption = "کلدار نرخ";
            gridColumn8.FieldName = "KaldarPrice";
            gridColumn8.MinWidth = 25;
            gridColumn8.Name = "gridColumn8";
            gridColumn8.Visible = true;
            gridColumn8.VisibleIndex = 7;
            gridColumn8.Width = 155;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, layoutControlItem3, layoutControlItem4, emptySpaceItem1, layoutControlItem5 });
            Root.Name = "Root";
            Root.Size = new Size(1358, 668);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = gridItems;
            layoutControlItem1.Location = new Point(0, 40);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(1332, 602);
            layoutControlItem1.TextSize = new Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = btnNewItem;
            layoutControlItem2.Location = new Point(1249, 0);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(83, 40);
            layoutControlItem2.TextSize = new Size(0, 0);
            layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = btnEditItem;
            layoutControlItem3.Location = new Point(1166, 0);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(83, 40);
            layoutControlItem3.TextSize = new Size(0, 0);
            layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = btnEditPrice;
            layoutControlItem4.Location = new Point(1037, 0);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new Size(129, 40);
            layoutControlItem4.TextSize = new Size(0, 0);
            layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new Point(0, 0);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new Size(900, 40);
            emptySpaceItem1.TextSize = new Size(0, 0);
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = btnPrint;
            layoutControlItem5.Location = new Point(900, 0);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new Size(137, 40);
            layoutControlItem5.TextSize = new Size(0, 0);
            layoutControlItem5.TextVisible = false;
            // 
            // MainForm
            // 
            Appearance.Options.UseFont = true;
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1358, 668);
            Controls.Add(layoutControl1);
            Name = "MainForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "عمومي صفحه";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)viewItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gridItems;
        private DevExpress.XtraGrid.Views.Grid.GridView viewItems;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.SimpleButton btnEditPrice;
        private DevExpress.XtraEditors.SimpleButton btnEditItem;
        private DevExpress.XtraEditors.SimpleButton btnNewItem;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}
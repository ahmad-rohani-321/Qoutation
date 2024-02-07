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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            btnRefreshPage = new DevExpress.XtraEditors.SimpleButton();
            btnItemDelete = new DevExpress.XtraEditors.SimpleButton();
            btnResetDatabase = new DevExpress.XtraEditors.SimpleButton();
            pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
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
            layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem9).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(btnRefreshPage);
            layoutControl1.Controls.Add(btnItemDelete);
            layoutControl1.Controls.Add(btnResetDatabase);
            layoutControl1.Controls.Add(pictureEdit1);
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
            layoutControl1.Size = new Size(1358, 634);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // btnRefreshPage
            // 
            btnRefreshPage.Location = new Point(1072, 139);
            btnRefreshPage.Name = "btnRefreshPage";
            btnRefreshPage.Size = new Size(130, 35);
            btnRefreshPage.StyleController = layoutControl1;
            btnRefreshPage.TabIndex = 8;
            btnRefreshPage.Text = "صفحه تازه کول";
            btnRefreshPage.Click += btnRefreshPage_Click;
            // 
            // btnItemDelete
            // 
            btnItemDelete.Location = new Point(1072, 180);
            btnItemDelete.Name = "btnItemDelete";
            btnItemDelete.Size = new Size(130, 35);
            btnItemDelete.StyleController = layoutControl1;
            btnItemDelete.TabIndex = 7;
            btnItemDelete.Text = "جنس ډیلیټ";
            btnItemDelete.Click += btnItemDelete_Click;
            // 
            // btnResetDatabase
            // 
            btnResetDatabase.Location = new Point(1072, 16);
            btnResetDatabase.Name = "btnResetDatabase";
            btnResetDatabase.Size = new Size(270, 35);
            btnResetDatabase.StyleController = layoutControl1;
            btnResetDatabase.TabIndex = 6;
            btnResetDatabase.Text = "ډاټابېس";
            btnResetDatabase.Click += btnResetDatabase_Click;
            // 
            // pictureEdit1
            // 
            pictureEdit1.EditValue = resources.GetObject("pictureEdit1.EditValue");
            pictureEdit1.Location = new Point(16, 16);
            pictureEdit1.Name = "pictureEdit1";
            pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            pictureEdit1.Size = new Size(299, 199);
            pictureEdit1.StyleController = layoutControl1;
            pictureEdit1.TabIndex = 1;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(1208, 180);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(134, 35);
            btnPrint.StyleController = layoutControl1;
            btnPrint.TabIndex = 4;
            btnPrint.Text = "چاپ";
            btnPrint.Click += btnPrint_Click;
            // 
            // btnEditPrice
            // 
            btnEditPrice.Location = new Point(1208, 139);
            btnEditPrice.Name = "btnEditPrice";
            btnEditPrice.Size = new Size(134, 35);
            btnEditPrice.StyleController = layoutControl1;
            btnEditPrice.TabIndex = 3;
            btnEditPrice.Text = "د اسعارو روز نرخ";
            btnEditPrice.Click += btnEditPrice_Click;
            // 
            // btnEditItem
            // 
            btnEditItem.Location = new Point(1072, 98);
            btnEditItem.Name = "btnEditItem";
            btnEditItem.Size = new Size(270, 35);
            btnEditItem.StyleController = layoutControl1;
            btnEditItem.TabIndex = 2;
            btnEditItem.Text = "تغیر جنس";
            btnEditItem.Click += btnEditItem_Click;
            // 
            // btnNewItem
            // 
            btnNewItem.Location = new Point(1072, 57);
            btnNewItem.Name = "btnNewItem";
            btnNewItem.Size = new Size(270, 35);
            btnNewItem.StyleController = layoutControl1;
            btnNewItem.TabIndex = 0;
            btnNewItem.Text = "نوی جنس";
            btnNewItem.Click += btnNewItem_Click;
            // 
            // gridItems
            // 
            gridItems.Location = new Point(16, 221);
            gridItems.MainView = viewItems;
            gridItems.Name = "gridItems";
            gridItems.Size = new Size(1326, 397);
            gridItems.TabIndex = 5;
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
            gridColumn4.Caption = "ګټه او مصرف %";
            gridColumn4.FieldName = "ProfitPercentage";
            gridColumn4.MinWidth = 25;
            gridColumn4.Name = "gridColumn4";
            gridColumn4.Visible = true;
            gridColumn4.VisibleIndex = 3;
            gridColumn4.Width = 165;
            // 
            // gridColumn5
            // 
            gridColumn5.Caption = "تمام شد نرخ ین";
            gridColumn5.FieldName = "FinalPrice";
            gridColumn5.MinWidth = 25;
            gridColumn5.Name = "gridColumn5";
            gridColumn5.Visible = true;
            gridColumn5.VisibleIndex = 4;
            gridColumn5.Width = 165;
            // 
            // gridColumn6
            // 
            gridColumn6.Caption = "$";
            gridColumn6.FieldName = "DollarPrice";
            gridColumn6.MinWidth = 25;
            gridColumn6.Name = "gridColumn6";
            gridColumn6.Visible = true;
            gridColumn6.VisibleIndex = 5;
            gridColumn6.Width = 165;
            // 
            // gridColumn7
            // 
            gridColumn7.Caption = "AFN";
            gridColumn7.FieldName = "AfghaniPrice";
            gridColumn7.MinWidth = 25;
            gridColumn7.Name = "gridColumn7";
            gridColumn7.Visible = true;
            gridColumn7.VisibleIndex = 6;
            gridColumn7.Width = 100;
            // 
            // gridColumn8
            // 
            gridColumn8.Caption = "PKR";
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
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem8, layoutControlItem2, layoutControlItem3, layoutControlItem4, layoutControlItem5, emptySpaceItem1, layoutControlItem6, layoutControlItem7, layoutControlItem9 });
            Root.Name = "Root";
            Root.Size = new Size(1358, 634);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = gridItems;
            layoutControlItem1.Location = new Point(0, 205);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(1332, 403);
            layoutControlItem1.TextSize = new Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            layoutControlItem8.Control = pictureEdit1;
            layoutControlItem8.Location = new Point(0, 0);
            layoutControlItem8.MinSize = new Size(26, 26);
            layoutControlItem8.Name = "layoutControlItem8";
            layoutControlItem8.Size = new Size(305, 205);
            layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutControlItem8.TextSize = new Size(0, 0);
            layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = btnNewItem;
            layoutControlItem2.Location = new Point(1056, 41);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(276, 41);
            layoutControlItem2.TextSize = new Size(0, 0);
            layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = btnEditItem;
            layoutControlItem3.Location = new Point(1056, 82);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(276, 41);
            layoutControlItem3.TextSize = new Size(0, 0);
            layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = btnEditPrice;
            layoutControlItem4.Location = new Point(1192, 123);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new Size(140, 41);
            layoutControlItem4.TextSize = new Size(0, 0);
            layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = btnPrint;
            layoutControlItem5.Location = new Point(1192, 164);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new Size(140, 41);
            layoutControlItem5.TextSize = new Size(0, 0);
            layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new Point(305, 0);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new Size(751, 205);
            emptySpaceItem1.TextSize = new Size(0, 0);
            // 
            // layoutControlItem6
            // 
            layoutControlItem6.Control = btnResetDatabase;
            layoutControlItem6.Location = new Point(1056, 0);
            layoutControlItem6.Name = "layoutControlItem6";
            layoutControlItem6.Size = new Size(276, 41);
            layoutControlItem6.TextSize = new Size(0, 0);
            layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            layoutControlItem7.Control = btnItemDelete;
            layoutControlItem7.Location = new Point(1056, 164);
            layoutControlItem7.Name = "layoutControlItem7";
            layoutControlItem7.Size = new Size(136, 41);
            layoutControlItem7.TextSize = new Size(0, 0);
            layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            layoutControlItem9.Control = btnRefreshPage;
            layoutControlItem9.Location = new Point(1056, 123);
            layoutControlItem9.Name = "layoutControlItem9";
            layoutControlItem9.Size = new Size(136, 41);
            layoutControlItem9.TextSize = new Size(0, 0);
            layoutControlItem9.TextVisible = false;
            // 
            // MainForm
            // 
            Appearance.Options.UseFont = true;
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1358, 634);
            Controls.Add(layoutControl1);
            Font = new Font("Calibri", 13.8F);
            IconOptions.Icon = (Icon)resources.GetObject("MainForm.IconOptions.Icon");
            IconOptions.Image = (Image)resources.GetObject("MainForm.IconOptions.Image");
            Name = "MainForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "عمومي صفحه";
            WindowState = FormWindowState.Maximized;
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)viewItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem8).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem9).EndInit();
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
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton btnResetDatabase;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SimpleButton btnItemDelete;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.SimpleButton btnRefreshPage;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
    }
}
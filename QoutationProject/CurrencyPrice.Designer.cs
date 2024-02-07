namespace QoutationProject
{
    partial class CurrencyPrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrencyPrice));
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            TxtYenToDollar = new DevExpress.XtraEditors.SpinEdit();
            TxtDollarToKaldar = new DevExpress.XtraEditors.SpinEdit();
            TxtDollarToAfghani = new DevExpress.XtraEditors.SpinEdit();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TxtYenToDollar.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtDollarToKaldar.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtDollarToAfghani.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem5).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(TxtYenToDollar);
            layoutControl1.Controls.Add(TxtDollarToKaldar);
            layoutControl1.Controls.Add(TxtDollarToAfghani);
            layoutControl1.Controls.Add(btnSave);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(493, 314);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // TxtYenToDollar
            // 
            TxtYenToDollar.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            TxtYenToDollar.Location = new Point(16, 159);
            TxtYenToDollar.Name = "TxtYenToDollar";
            TxtYenToDollar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            TxtYenToDollar.Size = new Size(373, 46);
            TxtYenToDollar.StyleController = layoutControl1;
            TxtYenToDollar.TabIndex = 3;
            // 
            // TxtDollarToKaldar
            // 
            TxtDollarToKaldar.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            TxtDollarToKaldar.Location = new Point(16, 97);
            TxtDollarToKaldar.Name = "TxtDollarToKaldar";
            TxtDollarToKaldar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            TxtDollarToKaldar.Size = new Size(366, 46);
            TxtDollarToKaldar.StyleController = layoutControl1;
            TxtDollarToKaldar.TabIndex = 2;
            // 
            // TxtDollarToAfghani
            // 
            TxtDollarToAfghani.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            TxtDollarToAfghani.Location = new Point(16, 35);
            TxtDollarToAfghani.Name = "TxtDollarToAfghani";
            TxtDollarToAfghani.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            TxtDollarToAfghani.Size = new Size(361, 46);
            TxtDollarToAfghani.StyleController = layoutControl1;
            TxtDollarToAfghani.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(16, 225);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(461, 35);
            btnSave.StyleController = layoutControl1;
            btnSave.TabIndex = 4;
            btnSave.Text = "ثبت";
            btnSave.Click += btnSave_Click;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem3, layoutControlItem1, layoutControlItem2, layoutControlItem5, emptySpaceItem1, emptySpaceItem2, emptySpaceItem3, emptySpaceItem4, emptySpaceItem5 });
            Root.Name = "Root";
            Root.Size = new Size(493, 314);
            Root.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = btnSave;
            layoutControlItem3.Location = new Point(0, 209);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(467, 41);
            layoutControlItem3.TextSize = new Size(0, 0);
            layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = TxtDollarToAfghani;
            layoutControlItem1.Location = new Point(0, 19);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(467, 52);
            layoutControlItem1.Text = "ډالر په افغانۍ";
            layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            layoutControlItem1.TextSize = new Size(95, 28);
            layoutControlItem1.TextToControlDistance = 5;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = TxtDollarToKaldar;
            layoutControlItem2.Location = new Point(0, 81);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(467, 52);
            layoutControlItem2.Text = "ډالر په کلدار";
            layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            layoutControlItem2.TextSize = new Size(90, 28);
            layoutControlItem2.TextToControlDistance = 5;
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = TxtYenToDollar;
            layoutControlItem5.Location = new Point(0, 143);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new Size(467, 52);
            layoutControlItem5.Text = "ډالر په ین";
            layoutControlItem5.TextSize = new Size(72, 28);
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new Point(0, 250);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new Size(467, 38);
            emptySpaceItem1.TextSize = new Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            emptySpaceItem2.AllowHotTrack = false;
            emptySpaceItem2.Location = new Point(0, 71);
            emptySpaceItem2.Name = "emptySpaceItem2";
            emptySpaceItem2.Size = new Size(467, 10);
            emptySpaceItem2.TextSize = new Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            emptySpaceItem3.AllowHotTrack = false;
            emptySpaceItem3.Location = new Point(0, 133);
            emptySpaceItem3.Name = "emptySpaceItem3";
            emptySpaceItem3.Size = new Size(467, 10);
            emptySpaceItem3.TextSize = new Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            emptySpaceItem4.AllowHotTrack = false;
            emptySpaceItem4.Location = new Point(0, 195);
            emptySpaceItem4.Name = "emptySpaceItem4";
            emptySpaceItem4.Size = new Size(467, 14);
            emptySpaceItem4.TextSize = new Size(0, 0);
            // 
            // emptySpaceItem5
            // 
            emptySpaceItem5.AllowHotTrack = false;
            emptySpaceItem5.Location = new Point(0, 0);
            emptySpaceItem5.Name = "emptySpaceItem5";
            emptySpaceItem5.Size = new Size(467, 19);
            emptySpaceItem5.TextSize = new Size(0, 0);
            // 
            // CurrencyPrice
            // 
            Appearance.Options.UseFont = true;
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(493, 314);
            Controls.Add(layoutControl1);
            Font = new Font("Calibri", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IconOptions.Icon = (Icon)resources.GetObject("CurrencyPrice.IconOptions.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CurrencyPrice";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "د اسعارو روز نرخ";
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TxtYenToDollar.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtDollarToKaldar.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtDollarToAfghani.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SpinEdit TxtDollarToKaldar;
        private DevExpress.XtraEditors.SpinEdit TxtDollarToAfghani;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SpinEdit TxtYenToDollar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
    }
}
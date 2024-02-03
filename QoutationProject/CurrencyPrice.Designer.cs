﻿namespace QoutationProject
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
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            gridCurrency = new DevExpress.XtraGrid.GridControl();
            viewCurrency = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            TxtDollarToAfghani = new DevExpress.XtraEditors.SpinEdit();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            TxtDollarToKaldar = new DevExpress.XtraEditors.SpinEdit();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridCurrency).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewCurrency).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtDollarToAfghani.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtDollarToKaldar.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(TxtDollarToKaldar);
            layoutControl1.Controls.Add(TxtDollarToAfghani);
            layoutControl1.Controls.Add(gridCurrency);
            layoutControl1.Controls.Add(btnSave);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(751, 422);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // gridCurrency
            // 
            gridCurrency.Location = new Point(16, 16);
            gridCurrency.MainView = viewCurrency;
            gridCurrency.Name = "gridCurrency";
            gridCurrency.Size = new Size(446, 390);
            gridCurrency.TabIndex = 4;
            gridCurrency.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { viewCurrency });
            // 
            // viewCurrency
            // 
            viewCurrency.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn2, gridColumn3, gridColumn4 });
            viewCurrency.GridControl = gridCurrency;
            viewCurrency.Name = "viewCurrency";
            viewCurrency.OptionsBehavior.Editable = false;
            viewCurrency.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            gridColumn1.Caption = "شمېره";
            gridColumn1.FieldName = "Id";
            gridColumn1.MinWidth = 25;
            gridColumn1.Name = "gridColumn1";
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 0;
            gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            gridColumn2.Caption = "افغانۍ په ډالر";
            gridColumn2.FieldName = "AghaniPrice";
            gridColumn2.MinWidth = 25;
            gridColumn2.Name = "gridColumn2";
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 1;
            gridColumn2.Width = 94;
            // 
            // gridColumn3
            // 
            gridColumn3.Caption = "کلدار په ډالر";
            gridColumn3.FieldName = "KaldarPrice";
            gridColumn3.MinWidth = 25;
            gridColumn3.Name = "gridColumn3";
            gridColumn3.Visible = true;
            gridColumn3.VisibleIndex = 2;
            gridColumn3.Width = 94;
            // 
            // gridColumn4
            // 
            gridColumn4.Caption = "نېټه";
            gridColumn4.FieldName = "Date";
            gridColumn4.MinWidth = 25;
            gridColumn4.Name = "gridColumn4";
            gridColumn4.Visible = true;
            gridColumn4.VisibleIndex = 3;
            gridColumn4.Width = 94;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(468, 112);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(267, 34);
            btnSave.StyleController = layoutControl1;
            btnSave.TabIndex = 3;
            btnSave.Text = "ثبت";
            btnSave.Click += btnSave_Click;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem3, layoutControlItem4, layoutControlItem1, layoutControlItem2 });
            Root.Name = "Root";
            Root.Size = new Size(751, 422);
            Root.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = btnSave;
            layoutControlItem3.Location = new Point(452, 96);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(273, 300);
            layoutControlItem3.TextSize = new Size(0, 0);
            layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = gridCurrency;
            layoutControlItem4.Location = new Point(0, 0);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new Size(452, 396);
            layoutControlItem4.TextSize = new Size(0, 0);
            layoutControlItem4.TextVisible = false;
            // 
            // TxtDollarToAfghani
            // 
            TxtDollarToAfghani.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            TxtDollarToAfghani.Location = new Point(468, 16);
            TxtDollarToAfghani.Name = "TxtDollarToAfghani";
            TxtDollarToAfghani.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            TxtDollarToAfghani.Size = new Size(175, 42);
            TxtDollarToAfghani.StyleController = layoutControl1;
            TxtDollarToAfghani.TabIndex = 5;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = TxtDollarToAfghani;
            layoutControlItem1.Location = new Point(452, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(273, 48);
            layoutControlItem1.Text = "ډالر په افغانۍ";
            layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            layoutControlItem1.TextSize = new Size(87, 24);
            layoutControlItem1.TextToControlDistance = 5;
            // 
            // TxtDollarToKaldar
            // 
            TxtDollarToKaldar.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            TxtDollarToKaldar.Location = new Point(468, 64);
            TxtDollarToKaldar.Name = "TxtDollarToKaldar";
            TxtDollarToKaldar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            TxtDollarToKaldar.Size = new Size(181, 42);
            TxtDollarToKaldar.StyleController = layoutControl1;
            TxtDollarToKaldar.TabIndex = 6;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = TxtDollarToKaldar;
            layoutControlItem2.Location = new Point(452, 48);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(273, 48);
            layoutControlItem2.Text = "ډالر په کلدار";
            layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            layoutControlItem2.TextSize = new Size(81, 24);
            layoutControlItem2.TextToControlDistance = 5;
            // 
            // CurrencyPrice
            // 
            Appearance.Options.UseFont = true;
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(751, 422);
            Controls.Add(layoutControl1);
            Font = new Font("Calibri", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CurrencyPrice";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "د اسعارو روز نرخ";
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridCurrency).EndInit();
            ((System.ComponentModel.ISupportInitialize)viewCurrency).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtDollarToAfghani.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtDollarToKaldar.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.GridControl gridCurrency;
        private DevExpress.XtraGrid.Views.Grid.GridView viewCurrency;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.SpinEdit TxtDollarToKaldar;
        private DevExpress.XtraEditors.SpinEdit TxtDollarToAfghani;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}
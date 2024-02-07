namespace QoutationProject
{
    partial class ResetDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetDatabase));
            btnBackUp = new DevExpress.XtraEditors.SimpleButton();
            btnRestore = new DevExpress.XtraEditors.SimpleButton();
            btnDeleteDatabase = new DevExpress.XtraEditors.SimpleButton();
            SuspendLayout();
            // 
            // btnBackUp
            // 
            btnBackUp.Location = new Point(107, 78);
            btnBackUp.Name = "btnBackUp";
            btnBackUp.Size = new Size(233, 36);
            btnBackUp.TabIndex = 0;
            btnBackUp.Text = "بک آپ";
            btnBackUp.Click += btnBackUp_Click;
            // 
            // btnRestore
            // 
            btnRestore.Location = new Point(107, 138);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(233, 36);
            btnRestore.TabIndex = 1;
            btnRestore.Text = "نوی ډاټابېس";
            btnRestore.Click += btnRestore_Click;
            // 
            // btnDeleteDatabase
            // 
            btnDeleteDatabase.Location = new Point(107, 198);
            btnDeleteDatabase.Name = "btnDeleteDatabase";
            btnDeleteDatabase.Size = new Size(233, 36);
            btnDeleteDatabase.TabIndex = 1;
            btnDeleteDatabase.Text = "ډیلیټ ډاټابېس";
            btnDeleteDatabase.Click += btnDeleteDatabase_Click;
            // 
            // ResetDatabase
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(447, 405);
            Controls.Add(btnDeleteDatabase);
            Controls.Add(btnRestore);
            Controls.Add(btnBackUp);
            IconOptions.Icon = (Icon)resources.GetObject("ResetDatabase.IconOptions.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ResetDatabase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "د ډاټابېس صفحه";
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnBackUp;
        private DevExpress.XtraEditors.SimpleButton btnRestore;
        private DevExpress.XtraEditors.SimpleButton btnDeleteDatabase;
    }
}
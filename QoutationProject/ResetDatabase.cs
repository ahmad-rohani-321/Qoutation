using DevExpress.XtraEditors;
using Microsoft.EntityFrameworkCore;
using QoutationProject.DbSets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QoutationProject
{
    public partial class ResetDatabase : DevExpress.XtraEditors.XtraForm
    {
        public ResetDatabase()
        {
            InitializeComponent();
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new();
            fileDialog.Filter = "Sqlite files (*.db)|*.db";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = @$"{Environment.CurrentDirectory}\Qoutation\Database.db";
                File.Copy(path, fileDialog.FileName);
                Defaults.MessageBox("بک آپ ثبت سو");
                Close();
            }
            fileDialog.Dispose();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                MainDbContext db = new MainDbContext();
                db.Database.CreateExecutionStrategy();
                db.Database.Migrate();
                Defaults.MessageBox("نوی ډاټابېس جوړ سو");
                Close();
            }
            catch { }
        }

        private void btnDeleteDatabase_Click(object sender, EventArgs e)
        {
            if (!File.Exists(@$"{Environment.CurrentDirectory}\Qoutation\Database.db"))
            {
                Defaults.MessageBox(message: "ډاټابېس ډیلیټ سوی دی");
            }
            else
            {
                File.Delete(@$"{Environment.CurrentDirectory}\Qoutation\Database.db");
                Defaults.MessageBox(message: "ډاټابېس ډیلیټ سو");
                Close();
            }
        }
    }
}
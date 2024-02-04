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
            string path = @$"{Environment.CurrentDirectory}\Qoutation\Database.db";
            string toPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)}\Database.db";
            if (!File.Exists($@"{Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)}\Database.db"))
            {
                File.Copy(path, toPath);
                Defaults.MessageBox("فایل ډیسکټاپ ته کاپي سو");
            }
            else
            {
                File.Delete(path);
                File.Copy(path, toPath);
                Defaults.MessageBox("فایل ډیسکټاپ ته کاپي سو");
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @$"Data Source = {Environment.CurrentDirectory}\Qoutation\Database.db";
                MainDbContext db = new MainDbContext();
                db.Database.CreateExecutionStrategy();
                db.Database.Migrate();
            }
            catch 
            {

                throw;
            }
        }
    }
}
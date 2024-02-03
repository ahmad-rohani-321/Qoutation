﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QoutationProject
{
    internal static class Defaults
    {
        internal static void MessageBox(string message)
        {
            XtraMessageBox.Show(message, "خبرتیا", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

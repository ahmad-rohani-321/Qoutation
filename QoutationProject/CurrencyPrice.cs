﻿using DevExpress.XtraEditors;
using QoutationProject.Actions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QoutationProject
{
    public partial class CurrencyPrice : XtraForm
    {
        Actions.CurrencyPrices currencyPrices;
        public CurrencyPrice()
        {
            InitializeComponent();
            currencyPrices = new();
            gridCurrency.DataSource = currencyPrices.GetCurrencyPrices;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Valid())
            {
                DbSets.CurrencyPrice currencyPrice = new DbSets.CurrencyPrice()
                {
                    AghaniPrice = TxtDollarToAfghani.Value,
                    KaldarPrice = TxtDollarToKaldar.Value,
                    Date = DateOnly.FromDateTime(DateTime.Now)
                };
                bool added = currencyPrices.AddCurrencyPrices(currencyPrice);
                if (added)
                {
                    Defaults.MessageBox("عملیه تکمیل سوه");
                    gridCurrency.DataSource = currencyPrices.GetCurrencyPrices;

                }
                else
                {
                    Defaults.MessageBox("عملیه تکمیل نه سوه");
                }
            }
        }

        private bool Valid()
        {
            bool result = true;
            if (TxtDollarToAfghani.Value <= 0)
            {
                TxtDollarToAfghani.ErrorText = "صفر عدد نه منل کیږي";
                result = false;
            }
            else
            {
                TxtDollarToAfghani.ErrorText = default!;
            }
            if (TxtDollarToKaldar.Value <= 0)
            {
                TxtDollarToKaldar.ErrorText = "صفر عدد نه منل کیږي";
                result = false;
            }
            else
            {
                TxtDollarToKaldar.ErrorText = default!;
            }
            return result;
        }
    }
}
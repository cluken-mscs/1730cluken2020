using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clukenex2b1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate(object sender, EventArgs e)
        {
            decimal amountAustralia = Convert.ToDecimal(txtAmountAustralia.Text);
            decimal rateAustralia = Convert.ToDecimal(txtRateAustralia.Text);
            decimal usdAustralia = amountAustralia * rateAustralia;
            txtUSDAustralia.Text = usdAustralia.ToString("0.00");


            decimal amountAlbania = Convert.ToDecimal(txtAmountAlbania.Text);
            decimal rateAlbania = Convert.ToDecimal(txtRateAlbania.Text);
            decimal usdAlbania = amountAlbania * rateAlbania;
            txtUSDAlbania.Text = usdAlbania.ToString("0.00");

            decimal amountBhutan = Convert.ToDecimal(txtAmountBhutan.Text);
            decimal rateBhutan = Convert.ToDecimal(txtRateBhutan.Text);
            decimal usdBhutan = amountBhutan * rateBhutan;
            txtUSDBhutan.Text = usdBhutan.ToString("0.00");

            decimal amountBritain = Convert.ToDecimal(txtAmountBritain.Text);
            decimal rateBritain = Convert.ToDecimal(txtRateBritain.Text);
            decimal usdBritain = amountBritain * rateBritain;
            txtUSDBritain.Text = usdBritain.ToString("0.00");

            decimal totalUSD = usdAustralia + usdAlbania + usdBhutan + usdBritain;
            txtUSDTotal.Text = totalUSD.ToString("0.00");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            {
                txtAmountAustralia.Text = "0.00";
                txtRateAustralia.Text = "0.725707";
                txtAmountAlbania.Text = "0.00";
                txtRateAlbania.Text = "0.00952487";
                txtAmountBhutan.Text = "0.00";
                txtRateBhutan.Text = "0.0135549";
                txtAmountBritain.Text = "0.00";
                txtRateBritain.Text = "1.31971";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

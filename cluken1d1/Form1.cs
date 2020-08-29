using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cluken1d1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void australiaTextChanged(object sender, EventArgs e)
        {
            txtUSDAustralia.Text = (
                           Convert.ToDecimal(txtRateAustralia.Text) 
                         * Convert.ToDecimal(txtAmountAustralia.Text)
                                    ).ToString("0.00");
        }

        private void albaniaTextChanged(object sender, EventArgs e)
        {
            txtUSDAlbania.Text = (
                            Convert.ToDecimal(txtRateAlbania.Text)
                          * Convert.ToDecimal(txtAmountAlbania.Text)
                                  ).ToString("0.00");
        }

        private void bhutanTextChanged(object sender, EventArgs e)
        {
           txtUSDBhutan.Text = (
                            Convert.ToDecimal(txtRateBhutan.Text)
                          * Convert.ToDecimal(txtAmountBhutan.Text)
                                  ).ToString("0.00");

        }

        private void britainTextChanged(object sender, EventArgs e)
        {
            txtUSDBritain.Text = (
                Convert.ToDecimal(txtRateBritain.Text)
              * Convert.ToDecimal(txtAmountBritain.Text)
              ).ToString("0.00");
        }

        private void usdTextChanged(object sender, EventArgs e)
        {
            txtUSDTotal.Text = (
                Convert.ToDecimal(txtUSDAustralia.Text)
                + Convert.ToDecimal(txtUSDAlbania.Text)
                + Convert.ToDecimal(txtUSDBhutan.Text)
                + Convert.ToDecimal(txtUSDBritain.Text)
                ).ToString("0.00");


        }

        private void btnReset_Click(object sender, EventArgs e)
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();



        }
    }
}
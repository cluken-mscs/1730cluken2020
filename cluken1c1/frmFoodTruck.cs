using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cluken1c1
{
    public partial class frmFoodTruck : Form
    {
        public frmFoodTruck()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtHotDogsSubtotal.Text = (
                    4.0m * Convert.ToDecimal(txtHotDogs.Text)
                ).ToString("0.00");
            txtHamburgersSubtotal.Text = (
                    5.0m * Convert.ToDecimal(txtHamburgers.Text)
                ).ToString("0.00");
            txtPretaxTotal.Text = (
                    Convert.ToDecimal(txtHotDogsSubtotal.Text)
                + Convert.ToDecimal(txtHamburgersSubtotal.Text)
                ).ToString("0.00");
            txtTaxTotal.Text = (
                    .06875m * Convert.ToDecimal(txtHotDogsSubtotal.Text) 
                + .06875m * Convert.ToDecimal(txtHamburgersSubtotal.Text)
                 ).ToString("0.00");
            txtTotal.Text = (
                    Convert.ToDecimal(txtPretaxTotal.Text)
                + Convert.ToDecimal(txtTaxTotal.Text)
                ).ToString("0.00");

            btnClear.Focus();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtHotDogs.Text = "0";
            txtHamburgers.Text = "0";
            txtHotDogsSubtotal.Text = "";
            txtHamburgersSubtotal.Text = "";
            txtPretaxTotal.Text = "";
            txtTaxTotal.Text = "";
            txtTotal.Text = "";
            txtHotDogs.Focus();

        }
        

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtHotDogs_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

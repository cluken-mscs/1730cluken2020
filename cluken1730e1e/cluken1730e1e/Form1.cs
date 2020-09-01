using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cluken1730e1e
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

        private void txtTestAverage_TextChanged(object sender, EventArgs e)
        {
            txtTestAverage.Text = (
                Convert.ToDecimal(txtTestOne.Text)
            + Convert.ToDecimal(txtTestTwo.Text)
            + Convert.ToDecimal(txtTestThree.Text)
            ).ToString("0.00");

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtTestAverage.Text = (
              Convert.ToDecimal(txtTestOne.Text) /3
            + Convert.ToDecimal(txtTestTwo.Text) /3
            + Convert.ToDecimal(txtTestThree.Text) /3
                )
                .ToString("0.00");

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTestOne.Text = "0.00";
            txtTestTwo.Text = "0.00";
            txtTestThree.Text = "0.00";
            txtTestAverage.Text = "0.00";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

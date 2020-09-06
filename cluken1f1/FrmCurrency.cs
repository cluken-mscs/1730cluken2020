using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cluken1f2
{
    public partial class FrmCurrency : Form
    {
        public FrmCurrency()
        {
            InitializeComponent();
        }

        private void FrmCurrency_Load(object sender, EventArgs e)
        {
            btnAlbania.BackgroundImage = picAlbania.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnUK.BackgroundImage = picUKDim.Image;
            lblCurrency.Text = btnAlbania.Text + ": ";
            txtRate.Text = "0.00952487";
            txtUSD.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            txtCurrency.Focus();

        }

        private void btnAlbania_Click(object sender, EventArgs e)
        {
            btnAlbania.BackgroundImage = picAlbania.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnUK.BackgroundImage = picUKDim.Image;
            lblCurrency.Text = btnAlbania.Text +": ";
            txtRate.Text = "0.00952487";
            txtCurrency.Focus();
        }

        private void btnAustralia_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnAlbania.BackgroundImage = picAlbaniaDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnUK.BackgroundImage = picUKDim.Image;
            lblCurrency.Text = btnAustralia.Text + ": ";
            txtRate.Text = "0.725707";
            txtCurrency.Focus();
        }

        private void btnBhutan_Click(object sender, EventArgs e)
        {
            btnBhutan.BackgroundImage = picBhutan.Image;
            btnAlbania.BackgroundImage = picAlbaniaDim.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnUK.BackgroundImage = picUKDim.Image;
            lblCurrency.Text = btnBhutan.Text + ": ";
            txtRate.Text = "0.0135549";
            txtCurrency.Focus();
        }

        private void btnUK_Click(object sender, EventArgs e)
        {
            btnUK.BackgroundImage = picUK.Image;
            btnAlbania.BackgroundImage = picAlbaniaDim.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            lblCurrency.Text = btnUK.Text + ": ";
            txtRate.Text = "1.31971";
            txtCurrency.Focus();
        }





        private void txtCurrency_Enter(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblEquation.Text = lblEquation.Text + "+ " + txtUSD.Text;
            txtTotalUSD.Text = (
                   Convert.ToDecimal(txtUSD.Text)
                 + Convert.ToDecimal(txtTotalUSD.Text)
                                ).ToString("0.00");
            txtCurrency.Focus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnAlbania.BackgroundImage = picAlbania.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnUK.BackgroundImage = picUKDim.Image;
            lblCurrency.Text = btnAlbania.Text + ": ";
            txtCurrency.Text = "0.00";
            txtRate.Text = "0.00952487";
            txtUSD.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            txtCurrency.Focus();
            lblEquation.Text = default; 
        }

        private void calcUSD(object sender, EventArgs e)
        {
            txtUSD.Text = (
                Convert.ToDecimal(txtRate.Text) 
              * Convert.ToDecimal(txtCurrency.Text)
            ).ToString("0.00");

        }

        private void txtTotalUSD_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


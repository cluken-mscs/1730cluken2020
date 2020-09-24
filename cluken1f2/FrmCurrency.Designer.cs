namespace cluken1f2
{
    partial class FrmCurrency
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
            this.btnAlbania = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAlbania
            // 
            this.btnAlbania.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAlbania.Location = new System.Drawing.Point(12, 12);
            this.btnAlbania.Name = "btnAlbania";
            this.btnAlbania.Size = new System.Drawing.Size(148, 119);
            this.btnAlbania.TabIndex = 8;
            this.btnAlbania.Text = "Albanian Lek";
            this.btnAlbania.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlbania.UseVisualStyleBackColor = true;
            // 
            // FrmCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAlbania);
            this.Name = "FrmCurrency";
            this.Load += new System.EventHandler(this.FrmCurrency_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlbania;
    }
}


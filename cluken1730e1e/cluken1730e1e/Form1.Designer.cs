﻿namespace cluken1730e1e
{
    partial class Form1
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTestOne = new System.Windows.Forms.TextBox();
            this.txtTestTwo = new System.Windows.Forms.TextBox();
            this.txtTestThree = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTestAverage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(233, 29);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(233, 55);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(233, 84);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Test 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Test 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Test 3:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtTestOne
            // 
            this.txtTestOne.Location = new System.Drawing.Point(113, 31);
            this.txtTestOne.Name = "txtTestOne";
            this.txtTestOne.Size = new System.Drawing.Size(68, 20);
            this.txtTestOne.TabIndex = 6;
            this.txtTestOne.Text = "0";
            this.txtTestOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTestTwo
            // 
            this.txtTestTwo.Location = new System.Drawing.Point(113, 57);
            this.txtTestTwo.Name = "txtTestTwo";
            this.txtTestTwo.Size = new System.Drawing.Size(68, 20);
            this.txtTestTwo.TabIndex = 7;
            this.txtTestTwo.Text = "0";
            this.txtTestTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTestThree
            // 
            this.txtTestThree.Location = new System.Drawing.Point(113, 83);
            this.txtTestThree.Name = "txtTestThree";
            this.txtTestThree.Size = new System.Drawing.Size(68, 20);
            this.txtTestThree.TabIndex = 8;
            this.txtTestThree.Text = "0";
            this.txtTestThree.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Average:";
            // 
            // txtTestAverage
            // 
            this.txtTestAverage.Location = new System.Drawing.Point(113, 129);
            this.txtTestAverage.Name = "txtTestAverage";
            this.txtTestAverage.ReadOnly = true;
            this.txtTestAverage.Size = new System.Drawing.Size(68, 20);
            this.txtTestAverage.TabIndex = 12;
            this.txtTestAverage.TabStop = false;
            this.txtTestAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 183);
            this.Controls.Add(this.txtTestAverage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTestThree);
            this.Controls.Add(this.txtTestTwo);
            this.Controls.Add(this.txtTestOne);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTestOne;
        private System.Windows.Forms.TextBox txtTestTwo;
        private System.Windows.Forms.TextBox txtTestThree;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTestAverage;
    }
}


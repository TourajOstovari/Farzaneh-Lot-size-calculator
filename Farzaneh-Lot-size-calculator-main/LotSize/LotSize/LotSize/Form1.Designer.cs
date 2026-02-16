namespace LotSize
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            n_equity = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ICS_FIXRISK = new NumericUpDown();
            label4 = new Label();
            Pipamount = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ICS_PercentRisk = new TextBox();
            label8 = new Label();
            txtPrice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ICS_FIXRISK).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(14, 328);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(107, 51);
            button1.TabIndex = 0;
            button1.Text = "Calculate...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 25);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 1;
            label1.Text = "Money Amount:";
            // 
            // n_equity
            // 
            n_equity.Location = new Point(14, 49);
            n_equity.Margin = new Padding(3, 4, 3, 4);
            n_equity.Name = "n_equity";
            n_equity.Size = new Size(271, 27);
            n_equity.TabIndex = 2;
            n_equity.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 100);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 3;
            label2.Text = "Percent:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 173);
            label3.Name = "label3";
            label3.Size = new Size(170, 20);
            label3.TabIndex = 5;
            label3.Text = "RISK PER PIP (Pip Value):";
            // 
            // ICS_FIXRISK
            // 
            ICS_FIXRISK.Location = new Point(14, 197);
            ICS_FIXRISK.Margin = new Padding(3, 4, 3, 4);
            ICS_FIXRISK.Name = "ICS_FIXRISK";
            ICS_FIXRISK.Size = new Size(272, 27);
            ICS_FIXRISK.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 245);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 7;
            label4.Text = "Pip Amount:";
            // 
            // Pipamount
            // 
            Pipamount.Location = new Point(14, 269);
            Pipamount.Margin = new Padding(3, 4, 3, 4);
            Pipamount.Name = "Pipamount";
            Pipamount.Size = new Size(209, 27);
            Pipamount.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.IndianRed;
            label5.Location = new Point(14, 396);
            label5.Name = "label5";
            label5.Size = new Size(33, 20);
            label5.TabIndex = 9;
            label5.Text = "Lot:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.OrangeRed;
            label6.Location = new Point(30, 439);
            label6.Name = "label6";
            label6.Size = new Size(19, 21);
            label6.TabIndex = 10;
            label6.Text = "0";
            // 
            // label7
            // 
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.IndianRed;
            label7.Location = new Point(2, 496);
            label7.Name = "label7";
            label7.Size = new Size(381, 92);
            label7.TabIndex = 11;
            label7.Text = "Math Formulation designed and developed by Mr. Touraj Ostovari";
            // 
            // ICS_PercentRisk
            // 
            ICS_PercentRisk.Location = new Point(14, 128);
            ICS_PercentRisk.Margin = new Padding(3, 4, 3, 4);
            ICS_PercentRisk.Name = "ICS_PercentRisk";
            ICS_PercentRisk.Size = new Size(271, 27);
            ICS_PercentRisk.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(128, 328);
            label8.Name = "label8";
            label8.Size = new Size(44, 20);
            label8.TabIndex = 13;
            label8.Text = "Price:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(128, 352);
            txtPrice.Margin = new Padding(3, 4, 3, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(157, 27);
            txtPrice.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 600);
            Controls.Add(txtPrice);
            Controls.Add(label8);
            Controls.Add(ICS_PercentRisk);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(Pipamount);
            Controls.Add(label4);
            Controls.Add(ICS_FIXRISK);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(n_equity);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Lot Size";
            ((System.ComponentModel.ISupportInitialize)ICS_FIXRISK).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox n_equity;
        private Label label2;
        private Label label3;
        private NumericUpDown ICS_FIXRISK;
        private Label label4;
        private TextBox Pipamount;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox ICS_PercentRisk;
        private Label label8;
        private TextBox txtPrice;
    }
}

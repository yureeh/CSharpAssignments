
namespace PaymentApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.amountToPayTxt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bankRd = new System.Windows.Forms.RadioButton();
            this.creditRd = new System.Windows.Forms.RadioButton();
            this.cashRd = new System.Windows.Forms.RadioButton();
            this.amountTxt = new System.Windows.Forms.TextBox();
            this.payBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Price to Pay:";
            // 
            // amountToPayTxt
            // 
            this.amountToPayTxt.AutoSize = true;
            this.amountToPayTxt.Location = new System.Drawing.Point(109, 78);
            this.amountToPayTxt.Name = "amountToPayTxt";
            this.amountToPayTxt.Size = new System.Drawing.Size(31, 15);
            this.amountToPayTxt.TabIndex = 0;
            this.amountToPayTxt.Text = "1000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Choose type of payment:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bankRd);
            this.groupBox1.Controls.Add(this.creditRd);
            this.groupBox1.Controls.Add(this.cashRd);
            this.groupBox1.Location = new System.Drawing.Point(78, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // bankRd
            // 
            this.bankRd.AutoSize = true;
            this.bankRd.Location = new System.Drawing.Point(6, 72);
            this.bankRd.Name = "bankRd";
            this.bankRd.Size = new System.Drawing.Size(51, 19);
            this.bankRd.TabIndex = 2;
            this.bankRd.TabStop = true;
            this.bankRd.Text = "Bank";
            this.bankRd.UseVisualStyleBackColor = true;
            // 
            // creditRd
            // 
            this.creditRd.AutoSize = true;
            this.creditRd.Location = new System.Drawing.Point(6, 47);
            this.creditRd.Name = "creditRd";
            this.creditRd.Size = new System.Drawing.Size(85, 19);
            this.creditRd.TabIndex = 1;
            this.creditRd.TabStop = true;
            this.creditRd.Text = "Credit Card";
            this.creditRd.UseVisualStyleBackColor = true;
            // 
            // cashRd
            // 
            this.cashRd.AutoSize = true;
            this.cashRd.Location = new System.Drawing.Point(6, 22);
            this.cashRd.Name = "cashRd";
            this.cashRd.Size = new System.Drawing.Size(51, 19);
            this.cashRd.TabIndex = 0;
            this.cashRd.TabStop = true;
            this.cashRd.Text = "Cash";
            this.cashRd.UseVisualStyleBackColor = true;
            // 
            // amountTxt
            // 
            this.amountTxt.Location = new System.Drawing.Point(51, 231);
            this.amountTxt.Name = "amountTxt";
            this.amountTxt.Size = new System.Drawing.Size(158, 23);
            this.amountTxt.TabIndex = 3;
            this.amountTxt.UseWaitCursor = true;
            // 
            // payBtn
            // 
            this.payBtn.Location = new System.Drawing.Point(94, 260);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(75, 23);
            this.payBtn.TabIndex = 4;
            this.payBtn.Text = "Pay";
            this.payBtn.UseVisualStyleBackColor = true;
            this.payBtn.Click += new System.EventHandler(this.payBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 341);
            this.Controls.Add(this.payBtn);
            this.Controls.Add(this.amountTxt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.amountToPayTxt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Payment App";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label amountToPayTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton bankRd;
        private System.Windows.Forms.RadioButton creditRd;
        private System.Windows.Forms.RadioButton cashRd;
        private System.Windows.Forms.TextBox amountTxt;
        private System.Windows.Forms.Button payBtn;
    }
}


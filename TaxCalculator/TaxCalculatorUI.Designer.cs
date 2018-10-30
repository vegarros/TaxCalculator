namespace TaxCalculator
{
    partial class TaxCalculatorUI
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
            this.label_EnterIncome = new System.Windows.Forms.Label();
            this.textBox_income = new System.Windows.Forms.TextBox();
            this.label_yourTax = new System.Windows.Forms.Label();
            this.button_calculateTax = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_EnterIncome
            // 
            this.label_EnterIncome.AutoSize = true;
            this.label_EnterIncome.Location = new System.Drawing.Point(12, 9);
            this.label_EnterIncome.Name = "label_EnterIncome";
            this.label_EnterIncome.Size = new System.Drawing.Size(128, 16);
            this.label_EnterIncome.TabIndex = 0;
            this.label_EnterIncome.Text = "Enter Income (NOK):";
            // 
            // textBox_income
            // 
            this.textBox_income.Location = new System.Drawing.Point(12, 28);
            this.textBox_income.Name = "textBox_income";
            this.textBox_income.Size = new System.Drawing.Size(336, 22);
            this.textBox_income.TabIndex = 1;
            this.textBox_income.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_income_KeyPress);
            // 
            // label_yourTax
            // 
            this.label_yourTax.AutoSize = true;
            this.label_yourTax.Location = new System.Drawing.Point(12, 91);
            this.label_yourTax.Name = "label_yourTax";
            this.label_yourTax.Size = new System.Drawing.Size(104, 16);
            this.label_yourTax.TabIndex = 2;
            this.label_yourTax.Text = "Your Tax (NOK):";
            // 
            // button_calculateTax
            // 
            this.button_calculateTax.Location = new System.Drawing.Point(12, 56);
            this.button_calculateTax.Name = "button_calculateTax";
            this.button_calculateTax.Size = new System.Drawing.Size(336, 23);
            this.button_calculateTax.TabIndex = 3;
            this.button_calculateTax.Text = "Calculate Tax";
            this.button_calculateTax.UseVisualStyleBackColor = true;
            this.button_calculateTax.Click += new System.EventHandler(this.button_calculateTax_Click);
            // 
            // TaxCalculatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 131);
            this.Controls.Add(this.button_calculateTax);
            this.Controls.Add(this.label_yourTax);
            this.Controls.Add(this.textBox_income);
            this.Controls.Add(this.label_EnterIncome);
            this.Name = "TaxCalculatorUI";
            this.Text = "Tax Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_EnterIncome;
        private System.Windows.Forms.TextBox textBox_income;
        private System.Windows.Forms.Label label_yourTax;
        private System.Windows.Forms.Button button_calculateTax;
    }
}


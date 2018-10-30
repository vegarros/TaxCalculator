using System;
using System.Windows.Forms;

namespace TaxCalculator
{
    public partial class TaxCalculatorUI : Form
    {
        private TaxCalculator taxCalculator;

        public TaxCalculatorUI()
        {
            InitializeComponent();
        }

        private void button_calculateTax_Click(object sender, EventArgs e)
        {
            int income;
            try
            {
                int.TryParse(textBox_income.Text, out income);

                taxCalculator = new TaxCalculator(income);

                label_yourTax.Text = "Your Tax (NOK): " + taxCalculator.GetSocialSecurityTax().ToString();
            }
            catch (Exception ex)
            {
                label_yourTax.Text = "Error: " + ex.Message;
            }
        }

        private void textBox_income_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

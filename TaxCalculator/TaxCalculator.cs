using System;
using System.Windows.Forms;

namespace TaxCalculator
{
    public class TaxCalculator
    {
        private readonly int income = 0;

        private const int EXCEPTION_CARD_LIMIT = 54650;
        private const double SOCIAL_SECURITY_TAX_PERCENTAGE = 0.082;
        private const double SOCIAL_SECURITY_TAX_MAX_PERCENTAGE = 0.25;

        private int taxableIncome;
        private double socialSecurityTax;

        public TaxCalculator(int income)
        {
            if (income > 0)
                this.income = income;

            CalculateTaxableIncome();
            CalculateSocialSecutiryTax();
        }

        private void CalculateTaxableIncome()
        {
            try
            {
                if (income <= EXCEPTION_CARD_LIMIT)
                {
                    taxableIncome =  0;
                } else
                {
                    taxableIncome = income - EXCEPTION_CARD_LIMIT; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculateSocialSecutiryTax()
        {
            try
            {
                double maximumTax = GetMaximumTax();

                if ((income * SOCIAL_SECURITY_TAX_PERCENTAGE) > maximumTax)
                {
                    socialSecurityTax = maximumTax;
                } else
                {
                    socialSecurityTax = income * SOCIAL_SECURITY_TAX_PERCENTAGE;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double GetMaximumTax()
        {
            return taxableIncome * SOCIAL_SECURITY_TAX_MAX_PERCENTAGE;
        }

        public double GetSocialSecurityTax()
        {
            return Math.Round(socialSecurityTax);
        }
    }
}

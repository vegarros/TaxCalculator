using NUnit.Framework;

namespace TaxCalculator.Tests
{
    [TestFixture]
    public class TaxCalculatorUnitTests
    {
        [Test] 
        public void GetSocialSecurityTax_Income_50000()
        {
            int income = 50000;
            TaxCalculator taxCalculator = new TaxCalculator(income);

            double socialSecurityTax = taxCalculator.GetSocialSecurityTax();

            Assert.AreEqual(0, socialSecurityTax);
        }

        [Test]
        public void GetSocialSecurityTax_Income_54000()
        {
            int income = 54000;
            TaxCalculator taxCalculator = new TaxCalculator(income);

            double socialSecurityTax = taxCalculator.GetSocialSecurityTax();

            Assert.AreEqual(0, socialSecurityTax);
        }

        [Test]
        public void GetSocialSecurityTax_Income_60000()
        {
            int income = 60000;
            TaxCalculator taxCalculator = new TaxCalculator(income);

            double socialSecurityTax = taxCalculator.GetSocialSecurityTax();

            Assert.AreEqual(1338, socialSecurityTax);
        }

        [Test]
        public void GetSocialSecurityTax_Income_75000()
        {
            int income = 75000;
            TaxCalculator taxCalculator = new TaxCalculator(income);

            double socialSecurityTax = taxCalculator.GetSocialSecurityTax();

            Assert.AreEqual(5088, socialSecurityTax);
        }

        [Test]
        public void GetSocialSecurityTax_Income_100000()
        {
            int income = 100000;
            TaxCalculator taxCalculator = new TaxCalculator(income);

            double socialSecurityTax = taxCalculator.GetSocialSecurityTax();

            Assert.AreEqual(8200, socialSecurityTax);
        }

        [Test]
        public void GetSocialSecurityTax_NegativeIncome()
        {
            int income = -100000;
            TaxCalculator taxCalculator = new TaxCalculator(income);

            double socialSecurityTax = taxCalculator.GetSocialSecurityTax();

            Assert.AreEqual(0, socialSecurityTax);
        }
    }
}

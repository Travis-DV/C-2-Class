namespace FutureValue
{
    public partial class frmFutureValue : Form
    {
        public frmFutureValue()
        {
            InitializeComponent();
        }

        private int investmentmultiplier = 12;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal Investment = Convert.ToDecimal(txtMonthlyInvestment.Text) * investmentmultiplier;
            decimal yearlyInterestRate = Convert.ToDecimal(txtInterestRate.Text);
            int years = Convert.ToInt32(txtYears.Text);

            int months = years * 12;
            decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;

            decimal futureValue = CalculateFutureValue(months, Investment, monthlyInterestRate);

            txtFutureValue.Text = futureValue.ToString("c");
            txtMonthlyInvestment.Focus();
        }

        private decimal CalculateFutureValue(int months, decimal Investment, decimal monthlyInterestRate)
        {
            decimal futureValue = 0m;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + Investment)
                            * (1 + monthlyInterestRate);
            }
            return futureValue;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearFutureValue(object sender, EventArgs e)
        {
            txtFutureValue.Text = "";
        }

        private void frmFutureValue_DoubleClick(object sender, EventArgs e)
        {
            txtFutureValue.Text = "";
            txtInterestRate.Text = "";
            txtMonthlyInvestment.Text = "";
            txtYears.Text = "";
        }

        private void txtInterestRate_DoubleClick(object sender, EventArgs e)
        {
            txtInterestRate.Text = "11.5";
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            investmentmultiplier = investmentmultiplier == 1 ? 12 : 1;
            label1.Text = investmentmultiplier == 1 ? "Yearly Investment:" : "Monthly Investment:";
        }
    }
}
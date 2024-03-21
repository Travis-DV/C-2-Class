namespace CustomerMaintenance
{
    public partial class frmAddCustomer : Form
    {
        public frmAddCustomer()
        {
            InitializeComponent();
        }

        private Customer customer = null!;

        public Customer GetNewCustomer()
        {
            this.ShowDialog();
            return customer;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                customer = rbWholesale.Checked ? new WholesaleCustomer(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtCompanyOrPhone.Text) : new RetailCustomer(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtCompanyOrPhone.Text);
                this.Close();
            }
        }

        private bool IsValidData()
        {
            
            bool success = true;
            string errorMessage = "";

            errorMessage += Validator.IsPresent(txtFirstName.Text, "First Name");
            errorMessage += Validator.IsPresent(txtLastName.Text, "Last Name");
            errorMessage += Validator.IsValidEmail(txtEmail.Text, "Email");

            errorMessage += rbWholesale.Checked ? Validator.IsPresent(txtEmail.Text, "Company Name") : Validator.IsPresent(txtEmail.Text, "Phone Number");

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbWholesale_CheckedChanged(object sender, EventArgs e)
        {
            lblCompanyOrPhone.Text = rbWholesale.Checked ? "Company" : "Home Phone";
        }
    }
}

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

            if (!IsValidData())
            {
                return;
            }
            if (RB_B2B.Checked)
            {
                customer = new Customer_B2B(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtCompanyOrPhone.Text);
                this.Close();
            }
            else if (RB_B2C.Checked)
            {
                customer = new Customer_B2C(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtCompanyOrPhone.Text);
                this.Close();
            }
            else if (RB_C2C.Checked)
            {
                customer = new Customer_C2C(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtCompanyOrPhone.Text);
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

            errorMessage += RB_B2B.Checked ? Validator.IsPresent(txtEmail.Text, "Company Name") : Validator.IsPresent(txtEmail.Text, "Phone Number");

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

        private void RadialButton_CheckedChanged(object sender, EventArgs e)
        {
            lblCompanyOrPhone.Text = RB_B2B.Checked ? "Company" : "Home Phone";
        }

    }
}

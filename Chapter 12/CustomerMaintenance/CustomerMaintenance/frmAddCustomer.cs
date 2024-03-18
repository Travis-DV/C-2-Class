using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerMaintenance
{
    public partial class frmAddCustomer : Form
    {

        frmCustomer customerform;

        public frmAddCustomer(frmCustomer customerform)
        {
            InitializeComponent();
            this.customerform = customerform;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!Validator.IsPresent(txtFirstName.Text))
            {
                txtFirstName.Text = "Please input a name";
                return;
            }
            if (!Validator.IsPresent(txtLastName.Text))
            {
                txtLastName.Text = "Please input a name";
                return;
            }
            if (!Validator.IsPresent(txtEmail.Text))
            {
                txtEmail.Text = "Please input an email";
                return;
            }
            if (!Validator.IsPresent(txtPhoneNumber.Text))
            {
                txtPhoneNumber.Text = "Please input a phone number";
                return;
            }
            if (!Validator.IsValidEmail(txtEmail.Text)) 
            { 
                txtEmail.Text = "Please input a valid Email"; 
                return;
            }
            if (!Validator.IsValidPhoneNumber(txtPhoneNumber.Text)) 
            { 
                txtPhoneNumber.Text = "Please input a valid Phone Number"; 
                return;
            }
            Customer c = new Customer(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtEmail.Text);
            customerform.AddCustomer(c);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtClicked(object sender, EventArgs e)
        {
            TextBox TBsender = sender as TextBox;
            if (TBsender.Text.Contains("Please"))
            {
                TBsender.Text = "";
            }
        }
    }
}

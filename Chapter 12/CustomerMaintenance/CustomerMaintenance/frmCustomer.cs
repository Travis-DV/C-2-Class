using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CustomerMaintenance
{
    public partial class frmCustomer : Form
    {

        private List<Customer> Customers;

        public frmCustomer()
        {
            InitializeComponent();
            Customers = CustomerDB.GetCustomers();
            foreach (Customer c in Customers)
            {
                this.lstCustomers.Items.Add(c.ToString());
            }
        }

        public void AddCustomer(Customer c)
        {
            this.Customers.Add(c);
            this.lstCustomers.Items.Add(c.ToString());
            CustomerDB.SaveCustomers(this.Customers);
        }

        private void GetNewCustomer(object sender, EventArgs e)
        {
            frmAddCustomer CustomerAdd = new frmAddCustomer(this);
            CustomerAdd.ShowDialog();
        }

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(Customers[lstCustomers.SelectedIndex].ToStringLong(), "Custemer - " + Customers[lstCustomers.SelectedIndex].ToString());
            }
            catch { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to delete:\n{Customers[lstCustomers.SelectedIndex].ToStringLong()}", "Deletion Confermation", MessageBoxButtons.YesNo);

            bool isConfirmed = result == DialogResult.Yes;

            if (isConfirmed)
            {
                this.Customers.RemoveAt(lstCustomers.SelectedIndex);
                lstCustomers.Items.RemoveAt(lstCustomers.SelectedIndex);
                lstCustomers.ClearSelected();
                CustomerDB.SaveCustomers(this.Customers);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
using System.Collections.Generic;

namespace CloneCustomer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Customer customer = null!;

        private void Form1_Load(object sender, EventArgs e)
        {
            customer = new("Travis", "Findley", "tfindley2@my.stlcc.edu");
            lblCustomer.Text = customer.GetDisplayText();
        }

        private void btnExit_Click(object sender, EventArgs e) => this.Close();

        private CustomList<IDisplayable> MakeCopiesForDisplay(ICloneable clone, int amount)
        {

            CustomList<IDisplayable> List = new();

            if (amount < 1)
            {
                return List;
            }

            for (int i = 0; i < amount; i++)
            {
                IDisplayable displayable = (IDisplayable)clone.Clone();

                List.Add(displayable);
            }

            return List;
        }

        private List<IDisplayable> MakeCopiesForDisplaOldy(ICloneable clone, int amount)
        {

            List<IDisplayable> List = new();

            if (amount < 1)
            {
                return List;
            }

            for (int i = 0; i < amount; i++)
            {
                IDisplayable displayable = (IDisplayable)clone.Clone();

                List.Add(displayable);
            }

            return List;
        }

        private void btnClone_Click(object sender, EventArgs e)
        {
            string ErrorMessage = Validator.IsInt32(txtCopies.Text, "Copies");
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                MessageBox.Show(ErrorMessage, "Entry Error");
                return;
            }
            int Count = Convert.ToInt16(txtCopies.Text);
            CustomList<IDisplayable> copies = MakeCopiesForDisplay(customer, Count);

            lstCustomers.Items.Clear();
            foreach (IDisplayable copy in copies)
            {
                lstCustomers.Items.Add(copy.GetDisplayText());
            }
        }

        private static void Show(CustomList<IDisplayable> list)
        {
            foreach (IDisplayable display in list)
            {
                MessageBox.Show(display.GetDisplayText());
            }
            MessageBox.Show(list.Count.ToString());
        }

        private static void BetterShow(CustomList<IDisplayable> list)
        {
            string message = "";

            foreach (IDisplayable display in list)
            {
                message += display.GetDisplayText() + "\n";
            }
            MessageBox.Show(message, list.Count.ToString() + " Messages");
        }

        private void ThisIsAllUseless(Customer customer)
        {
            if (!(int.TryParse(txtCopies.Text, out int amount) && amount > 0))
            {
                MessageBox.Show("Please give a number above 0", "Entry Error");
                return;
            }

            lstCustomers.Items.Clear();
            for (int i = 0; i < amount; i++)
            {
                //Without interfaces this could be even better
                //If there was no interface .Clone() could return a customer type so I wouldn't have to change it
                Customer Clone = (Customer)customer.Clone();
                lstCustomers.Items.Add(Clone.GetDisplayText());
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (!(int.TryParse(txtCopies.Text, out int amount) && amount > 0))
            {
                MessageBox.Show("Please give a number above 0", "Entry Error");
                return;
            }

            Show(MakeCopiesForDisplay(customer, amount));
        }

        private void btnBetterShow_Click(object sender, EventArgs e)
        {
            if (!(int.TryParse(txtCopies.Text, out int amount) && amount > 0))
            {
                MessageBox.Show("Please give a number above 0", "Entry Error");
                return;
            }

            BetterShow(MakeCopiesForDisplay(customer, amount));
        }
    }
}
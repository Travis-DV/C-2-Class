using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderOptionsMaintenance.Models;

namespace OrderOptionsMaintenance
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private OrderOptionList orderItems = new();
        MMABooksDataAccess data = new();

        private void frmMain_Load(object sender, EventArgs e)
        {
            orderItems.Changed += new OrderOptionList.ChangeHandler(HandleChange);
            orderItems = data.GetOrderOptionsAll();
            FillItemListBox();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HandleChange(OrderOptionList options)
        {
            FillItemListBox();
        }

        private void FillItemListBox()
        {
            OrderOption option;
            lstOrderOptions.Items.Clear();

            //STEP 11 CODE GOES HERE 
            for (int i = 0; i < orderItems.Count; i++) 
            {
                option = orderItems[i];
                lstOrderOptions.Items.Add(option.GetDisplayText());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstOrderOptions.SelectedIndex;

            if (i == -1)
            {
                MessageBox.Show("Please select an item to delete.", "No item selected");
            }
            else
            {
                OrderOption option = orderItems[i];

                string message = $"Are you sure you want to delete {option.GetDisplayText()}?";
                DialogResult result =
                    MessageBox.Show(message, "Confirm Delete",
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    //STEP 12 CODE GOES HERE
                    orderItems -= option;
                    MMABooksDataAccess data = new();
                    data.DeleteOrderOptions(option);

                }

                FillItemListBox();
            }
        }
    }
}

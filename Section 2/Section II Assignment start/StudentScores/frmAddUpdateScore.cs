using System.Text;

namespace StudentScores
{
    public partial class frmAddUpdateScore : Form
    {
        public frmAddUpdateScore()
        {
            InitializeComponent();
        }

        private void frmAddUpdateScore_Load(object sender, EventArgs e)
        {
            if (Text == "Update Score")
            {
                btnAddUpdate.Text = "&Update";
                txtScore.Text = Tag?.ToString();
            }
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            if (Validator.IsValidScore(txtScore.Text, "Score"))
            {
                Tag = Convert.ToInt32(txtScore.Text);
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
        //These are the original validation functions, but these don't belong here.  These should be in 
        //the Validator class.  Feel free to copy these as a starting point, but you'll need to make
        //changes to them.

            private bool IsValidScore()
        {
            bool success = true;

            StringBuilder sb = new();
            sb.Append(IsPresent(txtScore.Text, "Score"));
            sb.Append(IsInt32(txtScore.Text, "Score"));
            sb.Append(IsWithinRange(txtScore.Text, "Score", 0, 100));
            string errorMsg = sb.ToString();

            if (!String.IsNullOrEmpty(errorMsg))
            {
                success = false;
                MessageBox.Show(errorMsg, "Entry Error");
            }
            return success;
        }

        private string IsPresent(string value, string name)
        {
            string errorMsg = "";
            if (String.IsNullOrEmpty(value))
            {
                errorMsg = $"{name} is a required field.\n";
            }
            return errorMsg;
        }

        private string IsInt32(string value, string name)
        {
            string errorMsg = "";
            if (!Int32.TryParse(value, out _))
            {
                errorMsg = $"{name} must be a valid integer.\n";
            }
            return errorMsg;
        }

        private string IsWithinRange(string value, string name, decimal min, decimal max)
        {
            string errorMsg = "";
            if (Decimal.TryParse(value, out decimal number))
            {
                if (number < min || number > max)
                {
                    errorMsg = $"{name} must be between {min} and {max}.\n";
                }
            }
            return errorMsg;
        }
    */

    }
}
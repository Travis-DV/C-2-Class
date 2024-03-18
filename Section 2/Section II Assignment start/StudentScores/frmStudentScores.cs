namespace StudentScores
{
    public partial class frmStudentScores : Form
    {
        public frmStudentScores()
        {
            InitializeComponent();
        }

        public List<string> studentScores = new();

        private void frmStudentScores_Load(object sender, EventArgs e)
        {
            studentScores.Add("Joel Murach|97|91|83");
            studentScores.Add("Doug Lowe|99|93|97");
            studentScores.Add("Anne Boehm|100|100|100");
            LoadStudentListBox();
        }

        private void LoadStudentListBox(int selectedIndex = 0)
        {
            lstStudents.Items.Clear();

            foreach (string s in studentScores)
            {
                lstStudents.Items.Add(s);
            }

            if (lstStudents.Items.Count > 0)
            {
                lstStudents.SelectedIndex = selectedIndex;
            }
            else
            {
                ClearLabels();
            }

            lstStudents.Focus();
        }

        private void ClearLabels()
        {
            lblScoreCount.Text = "";
            lblAverage.Text = "";
            lblScoreTotal.Text = "";
        }

        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstStudents.SelectedIndex != -1)
            {
                string student = studentScores[lstStudents.SelectedIndex].ToString();
                string[] scores = student.Split('|');

                int total = 0;
                for (int i = 1; i < scores.Length; i++)
                {
                    total += Convert.ToInt32(scores[i]);
                }

                int count = scores.Length - 1;

                int average = 0;
                if (total > 0)
                {
                    average = total / count;
                }

                lblScoreTotal.Text = total.ToString();
                lblScoreCount.Text = count.ToString();
                lblAverage.Text = average.ToString();
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Form addForm = new frmAddNewStudent();
            DialogResult result = addForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                studentScores.Add(addForm.Tag?.ToString()!);
                int lastIndex = studentScores.Count - 1;
                LoadStudentListBox(lastIndex);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (studentScores.Count > 0)
            {
                int selectedIndex = lstStudents.SelectedIndex;
                string student = studentScores[selectedIndex].ToString();

                Form updateForm = new frmUpdateStudent();
                updateForm.Tag = student;

                DialogResult result = updateForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    studentScores.RemoveAt(selectedIndex);
                    studentScores.Insert(selectedIndex, updateForm.Tag?.ToString()!);

                    LoadStudentListBox(selectedIndex);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (studentScores.Count > 0)
            {
                studentScores.RemoveAt(lstStudents.SelectedIndex);
                LoadStudentListBox();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
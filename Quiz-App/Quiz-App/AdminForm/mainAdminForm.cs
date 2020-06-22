using System;
using System.Windows.Forms;

namespace Quiz_App.AdminForm
{
    public partial class mainAdminForm : Form
    {
        public mainAdminForm()
        {
            InitializeComponent();
        }
        // Close the Application
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Minimize the Application 
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Form Change Add Question Button Clicked
        private void AddQuesBtn_Click(object sender, EventArgs e)
        {
            AdminSubForms.AdminForm_AddQuestion form = new AdminSubForms.AdminForm_AddQuestion();
            this.Hide();
            form.Show();
        }

        // Form Change Delete Question Button Clicked

        private void delquesBtn_Click(object sender, EventArgs e)
        {
            AdminSubForms.AdminForm_DeleteQuestion form = new AdminSubForms.AdminForm_DeleteQuestion();
            this.Hide();
            form.Show();
        }

        private void ViewquesBtn_Click(object sender, EventArgs e)

        {
            AdminSubForms.AdminForm_ViewQuestion form = new AdminSubForms.AdminForm_ViewQuestion();
            this.Hide();
            form.Show();
        }

        private void UpdateQuestion_Click(object sender, EventArgs e)
        {

            AdminSubForms.AdminForm_UpdateQuestion form = new AdminSubForms.AdminForm_UpdateQuestion();
            this.Hide();
            form.Show();

        }

        private void signoutBtn_Click(object sender, EventArgs e)
        {
            
            LoginForm form = new LoginForm();
            this.Hide();
            form.Show();
        }
    }
}

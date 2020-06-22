using System;
using System.Windows.Forms;

namespace Quiz_App.GameForm
{
    public partial class mainGameForm : Form
    {
        public static string username; // save username in variable to store result in DB
        public mainGameForm()
        {
            InitializeComponent();
        }

        // overload contructor
        public mainGameForm(string user)
        {
            InitializeComponent();
            username = user;
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

        // Back to Login Page
        private void signoutBtn_Click(object sender, EventArgs e)
        {
            username = "";
            LoginForm form = new LoginForm();
            this.Hide();
            form.Show();
        }

        // navigate to play game form
        private void PlayGameBtn_Click(object sender, EventArgs e)
        {
            GameSubForms.GameForm_PlayGame form = new GameSubForms.GameForm_PlayGame();
            this.Hide();
            form.Show();
        }

        // navigate to Option form
        private void OptionGameBtn_Click(object sender, EventArgs e)
        {
            GameSubForms.GameForm_OptionGamForm form = new GameSubForms.GameForm_OptionGamForm();
            this.Hide();
            form.Show();
        }

        private void ViewResutlBtn_Click(object sender, EventArgs e)
        {
            GameSubForms.GameForm_ResultGame form = new GameSubForms.GameForm_ResultGame();
            this.Hide();
            form.Show();
        }
    }
}

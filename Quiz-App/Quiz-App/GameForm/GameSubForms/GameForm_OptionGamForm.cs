using System;
using System.Windows.Forms;

namespace Quiz_App.GameForm.GameSubForms
{
    public partial class GameForm_OptionGamForm : Form
    {
        private static int catagoryindex = 1;
        public GameForm_OptionGamForm()
        {
            InitializeComponent();
            catagoryCombo.SelectedIndex = catagoryindex;
            errorMessageLabel.Hide();
            errorMessageLabel.Text = "";
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
        // Navigate to Game Home Page when Back Button Clicked
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainGameForm form = new mainGameForm();
            form.Show();
        }

        // return the combobox value
        public string getCatagory()
        {
            if (catagoryCombo.SelectedIndex == 1)
                return "cricket";
            return "football";

        }

        // Set Catagory for User
        // Either Cricket
        // Either Football
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (catagoryCombo.SelectedIndex==1)
                catagoryindex =1;
            if (catagoryCombo.SelectedIndex == 2)
                catagoryindex =2;
            if (catagoryCombo.SelectedIndex == 0)
            {
                errorMessageLabel.Text = "Please Select Catagory";
                errorMessageLabel.Show();
                return;
            }

            // Naigate to Main Game Home From
            this.Hide();
            mainGameForm form = new mainGameForm();
            form.Show();
        }
    }
}

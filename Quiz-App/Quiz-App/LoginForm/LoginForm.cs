using System;
using System.Windows.Forms;

namespace Quiz_App
{
    public partial class LoginForm : Form
    {
        MySQL_Data_Base.MySqlDB mysql; // object of MySQL database
        public LoginForm()
        {
            InitializeComponent();
            errorMessageLabel.Hide();
            errorMessageLabel.Text = "";
            mysql = new MySQL_Data_Base.MySqlDB();

        }

        // Close the Application ==> picturbox cross click
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Minimize the Application ==> picturbox cross click
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        /************USERNAME TEXT BOX FUNCTIONS************/
        // Mouse Enter Function for userName Text Box ==> Empty TextBox on mouse enter
        private void usernameTextbox_MouseEnter(object sender, EventArgs e)
        {
            if (usernameTextbox.Text == "Username")
            {
                usernameTextbox.Text = "";
            }
        }
        // Mouse Leave Function for userName Text Box ==> Fill TextBox on mouse Leave
        // if text == ""
        private void usernameTextbox_MouseLeave(object sender, EventArgs e)
        {
            if (usernameTextbox.Text == "")
            {
                usernameTextbox.Text = "Username";
            }
        }

        private void usernameTextbox_KeyUp(object sender, KeyEventArgs e)
        {
            if (usernameTextbox.Text == "")
            {
                usernameTextbox.Text = "Username";
            }
        }

        private void usernameTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (usernameTextbox.Text == "Username")
            {
                usernameTextbox.Text = "";
            }
        }
        /************PASSWORD TEXT BOX FUNCTIONS************/
        // Mouse Enter Function for Password Text Box ==> Empty TextBox on mouse enter
        private void PasswordTextbox_MouseEnter(object sender, EventArgs e)
        {
            if (PasswordTextbox.Text == "Password")
            {
                PasswordTextbox.Text = "";
                PasswordTextbox.PasswordChar = '*';
            }
        }
        // Mouse Leave Function for Password Text Box ==> Fill TextBox on mouse Leave
        // if text == ""
        private void PasswordTextbox_MouseLeave(object sender, EventArgs e)
        {
            if (PasswordTextbox.Text == "")
            {
                PasswordTextbox.Text = "Password";
                PasswordTextbox.PasswordChar = '\0';
            }
        }

        private void PasswordTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (PasswordTextbox.Text == "Password")
            {

                PasswordTextbox.Text = "";
                PasswordTextbox.PasswordChar = '*';
            }
        }
        private void PasswordTextbox_KeyUp(object sender, KeyEventArgs e)
        {
            if (PasswordTextbox.Text == "")
            {
                PasswordTextbox.Text = "Password";
                PasswordTextbox.PasswordChar = '\0';
            }
        }

        //AdminRadion Button ==> Hide Sign up button when Radio Button checked
        private void AdminRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (AdminRadioButton.Checked)
                SignupButton.Visible = false;
            else
                SignupButton.Visible = true;
        }


        private void LoginBtn_Click(object sender, EventArgs e)
        {
            // if any fild is empty show error
            if (usernameTextbox.Text == "Username" || PasswordTextbox.Text == "Password")
            {
                errorMessageLabel.Text = "Kindly Fill the fields";
                errorMessageLabel.Show();
                return;
            }
            // check the role selected
            if (!(PlayerRadioButton.Checked || AdminRadioButton.Checked))
            {
                errorMessageLabel.Text = "Kindly Chooose the Role";
                errorMessageLabel.Show();
                return;
            }
            // When Player comes 
            // navigate to player form
            if (PlayerRadioButton.Checked)
            {
                // validate user by retrieving data form DB
                if (mysql.isValidUser(usernameTextbox.Text, PasswordTextbox.Text))
                {
                    this.Hide();

                    GameForm.mainGameForm form = new GameForm.mainGameForm(usernameTextbox.Text);
                    form.Show();
                }
                else
                {
                    errorMessageLabel.Text = "Wrong Username or Password";
                    errorMessageLabel.Show();
                    return;
                }
            }

            // When admin comes 
            // navigate to admin form
            if (AdminRadioButton.Checked)
            {
                // validate admin by retrieving data form DB
                if (mysql.isValidAdmin(usernameTextbox.Text, PasswordTextbox.Text))
                {
                    this.Hide();
                    AdminForm.mainAdminForm form = new AdminForm.mainAdminForm();
                    form.Show();
                }
                else
                {
                    errorMessageLabel.Text = "Wrong Username or Password";
                    errorMessageLabel.Show();
                    return;
                }

            }


        }
        // when user click on SignUp Button
        // Navigate to signup Page
        private void SignupButton_Click(object sender, EventArgs e)
        {
            SignupForm.signupForm form = new SignupForm.signupForm();
            this.Hide();
            form.Show();            
        }
    }
}

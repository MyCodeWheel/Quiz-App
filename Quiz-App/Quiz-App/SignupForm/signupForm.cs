using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Quiz_App.SignupForm
{
    public partial class signupForm : Form
    {
        MySQL_Data_Base.MySqlDB mysql;
        public signupForm()
        {
            InitializeComponent();
            mysql = new MySQL_Data_Base.MySqlDB();
            errorMessageLabel.Hide();
            errorMessageLabel.Text = "";
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

        /************Name TEXT BOX FUNCTIONS************/
        private void NameTextBox_MouseEnter(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "Your Name")
            {
                NameTextBox.Text = "";
            }
        }

        private void NameTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "")
            {
                NameTextBox.Text = "Your Name";
            }
        }

        private void NameTextBox_KeyUp(object sender, KeyEventArgs e)
        {

            if (NameTextBox.Text == "")
            {
                NameTextBox.Text = "Your Name";
            }
        }

        private void NameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (NameTextBox.Text == "Your Name")
            {
                NameTextBox.Text = "";
            }
        }


        // SHow Confirmation message to abort operation
        private bool showMessageBox()
        {
            string message = "Do you want to abort this operation?";
            string title = "Close Window";
            MessageBoxButtons btn = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, btn, MessageBoxIcon.Exclamation);
            if (result == DialogResult.No)
            {
                return true;
            }
            return false;
        }

        // When Back Button Click 
        // Ask User Confirmation
        // or mavigate to Login Form
        private void BackBtn_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text != "Your Name" || usernameTextbox.Text != "Username"
                || PasswordTextbox.Text != "Password")
            {
                if (showMessageBox() == true)
                    return;
            }
            this.Hide();
            LoginForm form = new LoginForm();
            form.Show();
        }


        /*******************ERROR PROVIDER FOR USERNAME*******************/
        // Ser error provider if username present in DB
        private void usernameTextbox_Validating(object sender, CancelEventArgs e)
        {
            if (usernameTextbox.Text == "Username")
                return;
            // pass username to DB for validing existance
            if (mysql.isUsernameAvailable(usernameTextbox.Text))
            {
                e.Cancel = true;
                UserNameerrorProvider.SetError(usernameTextbox, "Username already exist in Data Base");
                errorMessageLabel.Text = "Username already exist in Data Base";
                errorMessageLabel.Show();
            }
        }

        // Cancel Error Provider if no error found
        private void usernameTextbox_Validated(object sender, EventArgs e)
        {
            UserNameerrorProvider.SetError(usernameTextbox, null);
            errorMessageLabel.Text = "";
            errorMessageLabel.Show();
        }
        // Reinitailze Form COntrol to defautl format
        private void reinitialize()
        {
            usernameTextbox.Text = "Username";
            NameTextBox.Text = "Your Name";
            PasswordTextbox.Text = "Password";
            errorMessageLabel.Hide();
            errorMessageLabel.Text = "";
        }

        // When user clicks on signup button
        private void SignupButton_Click(object sender, EventArgs e)
        {

            // CHeck if no field is empty 
            if (NameTextBox.Text != "Your Name" && usernameTextbox.Text != "Username"
                && PasswordTextbox.Text != "Password")
            {
                // pass user data to the sql function to insert into DB
                if (mysql.signupUserInsertion(usernameTextbox.Text,PasswordTextbox.Text,NameTextBox.Text)) // if insertion successful
                {
                    // show message box and navigate to login fomr
                    MessageBox.Show("Congratulation!!!Signup Successful Please return to Login page to Continue"
                        , "Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    LoginForm form = new LoginForm();
                    form.Show();

                }
                else
                {
                    // if insertion failed ask user to try again to cancel
                    DialogResult result = MessageBox.Show("Some Error Occured!!! Try Again?"
           , "Signup Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (result == DialogResult.Retry) // in case of try again reinitailize form controls
                    {
                        reinitialize();
                    }
                    else // if no try again then navigate to login form
                    {
                        this.Hide();
                        LoginForm form = new LoginForm();
                        form.Show();
                    }
                }
            }
            else // if fields are not field with user input
            {
                errorMessageLabel.Text = "Kindly Fill all the fields";
                errorMessageLabel.Show();
            }
        }

    }
}

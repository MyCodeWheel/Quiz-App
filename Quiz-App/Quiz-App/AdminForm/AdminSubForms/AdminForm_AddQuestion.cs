using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Quiz_App.AdminForm.AdminSubForms
{
    public partial class AdminForm_AddQuestion : Form
    {
        private const string Pattern = @"^.+\?$"; // Regualer Expression for Question. ? is compulsory
        MySQL_Data_Base.MySqlDB mysql;
        public AdminForm_AddQuestion()
        {
            InitializeComponent();
            errorMessageLabel.Hide();
            errorMessageLabel.Text = "";
            catagoryCombo.SelectedIndex = 0;
            mysql = new MySQL_Data_Base.MySqlDB();
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
        private void BackBtn_Click(object sender, EventArgs e)
        {
            if (QuestionTextbox.Text != "Question" || OpATextBox.Text != "OptionA"
                || OpCTextBox.Text != "OptionC" ||
                OpDTextBox.Text != "OptionD"
                || OpBTextBox.Text != "OptionB"
                || idTextBox.Text != "ID")
            {
                if (showMessageBox() == true)
                    return;
            }
            this.Hide();
            AdminForm.mainAdminForm form = new AdminForm.mainAdminForm();
            form.Show();
        }


        // ==> Mouse hover effect on ID text Box
        // ==> Text disappear if text field is ID
        private void idTextBox_MouseEnter(object sender, EventArgs e)
        {
            if (idTextBox.Text == "ID")
                idTextBox.Text = "";
        }

        // ==> Mouse hover effect on ID text Box
        // ==> Text (ID) Appear if text field is empty
        private void idTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (idTextBox.Text == "")
                idTextBox.Text = "ID";
        }

        // ==> Mouse hover effect on Question text Box
        // ==> Text disappear if text field is Question
        private void QuestionTextbox_MouseEnter(object sender, EventArgs e)
        {
            if (QuestionTextbox.Text == "Question")
                QuestionTextbox.Text = "";
        }

        // ==> Mouse hover effect on Question text Box
        // ==> Text (Question) appear if text field is empty
        private void QuestionTextbox_MouseLeave(object sender, EventArgs e)
        {
            if (QuestionTextbox.Text == "")
                QuestionTextbox.Text = "Question";
        }
        // ==> Mouse hover effect on OptionA text Box
        // ==> Text disappear if text field is OptionA
        private void OpATextBox_MouseEnter(object sender, EventArgs e)
        {
            if (OpATextBox.Text == "OptionA")
                OpATextBox.Text = "";

        }

        // ==> Mouse hover effect on OptionA text Box
        // ==> Text (OptionA) Appear if text field is empty
        private void OpATextBox_MouseLeave(object sender, EventArgs e)
        {
            if (OpATextBox.Text == "")
                OpATextBox.Text = "OptionA";
        }
        // ==> Mouse hover effect on OptionB text Box
        // ==> Text disappear if text field is OptionB
        private void OpBTextBox_MouseEnter(object sender, EventArgs e)
        {
            if (OpBTextBox.Text == "OptionB")
                OpBTextBox.Text = "";
        }
        // ==> Mouse hover effect on OptionB text Box
        // ==> Text (OptionB) Appear if text field is empty
        private void OpBTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (OpBTextBox.Text == "")
                OpBTextBox.Text = "OptionB";
        }

        // ==> Mouse hover effect on OptionC text Box
        // ==> Text disappear if text field is OptionC
        private void OpCTextBox_MouseEnter(object sender, EventArgs e)
        {
            if (OpCTextBox.Text == "OptionC")
                OpCTextBox.Text = "";
        }
        // ==> Mouse hover effect on OptionC text Box
        // ==> Text (OptionC) Appear if text field is empty
        private void OpCTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (OpCTextBox.Text == "")
                OpCTextBox.Text = "OptionC";
        }

        // ==> Mouse hover effect on OptionD text Box
        // ==> Text disappear if text field is OptionD
        private void OpDTextBox_MouseEnter(object sender, EventArgs e)
        {
            if (OpDTextBox.Text == "OptionD")
                OpDTextBox.Text = "";
        }
        // ==> Mouse hover effect on OptionD text Box
        // ==> Text (OptionD) Appear if text field is empty
        private void OpDTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (OpDTextBox.Text == "")
                OpDTextBox.Text = "OptionD";
        }

        // ==> Text (Question) appears when no key is pressed
        // ==> and when text field is empty
        private void QuestionTextbox_KeyUp(object sender, KeyEventArgs e)
        {
            if (QuestionTextbox.Text == "")
                QuestionTextbox.Text = "Question";
        }

        // ==> Text (Question) disappears when key is pressed
        // ==> and when text field is Question
        private void QuestionTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (QuestionTextbox.Text == "Question")
                QuestionTextbox.Text = "";
        }

        // ==> Text (OptionA) appears when no key is pressed
        // ==> and when text field is empty
        private void OpATextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (OpATextBox.Text == "")
                OpATextBox.Text = "OptionA";
        }

        // ==> Text (OptonA) disappears when key is pressed
        // ==> and when text field is OptionA
        private void OpATextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (OpATextBox.Text == "OptionA")
                OpATextBox.Text = "";
        }
        // ==> Text (OptionB) appears when no key is pressed
        // ==> and when text field is empty
        private void OpBTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (OpBTextBox.Text == "")
                OpBTextBox.Text = "OptionB";
        }

        // ==> Text (OptonB) disappears when key is pressed
        // ==> and when text field is OptionB
        private void OpBTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (OpBTextBox.Text == "OptionB")
                OpBTextBox.Text = "";
        }

        // ==> Text (OptionC) appears when no key is pressed
        // ==> and when text field is empty
        private void OpCTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (OpCTextBox.Text == "")
                OpCTextBox.Text = "OptionC";
        }

        // ==> Text (OptonC) disappears when key is pressed
        // ==> and when text field is OptionC
        private void OpCTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (OpCTextBox.Text == "OptionC")
                OpCTextBox.Text = "";
        }

        // ==> Text (OptionD) appears when no key is pressed
        // ==> and when text field is empty
        private void OpDTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (OpDTextBox.Text == "")
                OpDTextBox.Text = "OptionD";
        }

        // ==> Text (OptonD) disappears when key is pressed
        // ==> and when text field is OptionD
        private void OpDTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (OpDTextBox.Text == "OptionD")
                OpDTextBox.Text = "";
        }

        // ==> Text (ID) appears when no key is pressed
        // ==> and when text field is empty
        private void idTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (idTextBox.Text == "")
                idTextBox.Text = "ID";
        }

        // ==> Text (ID) disappears when key is pressed
        // ==> and when text field is ID
        private void idTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (idTextBox.Text == "ID")
                idTextBox.Text = "";
        }

        /***************Error Provider for Question ID text Box***************/
        // ==> set error message if id already exist 
        // ==> or input in anything instead of numbers.
        private void idTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (idTextBox.Text == "ID")
                return;
            int result;
            if (!(int.TryParse(idTextBox.Text, out result)))
            {
                // Cancel the event
                e.Cancel = true;
                // Set the ErrorProvider error with the text to display.
                ErrorIdTextBox.SetError(idTextBox, "Only Numbers are allowed");
                errorMessageLabel.Text = "Only Numbers are allowed";
                errorMessageLabel.Show();

            }
            else if (mysql.validateQuesID(idTextBox.Text) == true)
            {
                e.Cancel = true;
                ErrorIdTextBox.SetError(idTextBox, "Id already exist in DataBase");
                errorMessageLabel.Text = "Id already exist in DataBase";
                errorMessageLabel.Show();
            }

        }

        // ==> If all conditions have been met, 
        // ==> clear the ErrorProvider of errors.
        private void idTextBox_Validated(object sender, EventArgs e)
        {
            ErrorIdTextBox.SetError(idTextBox, null);
            errorMessageLabel.Hide();
            errorMessageLabel.Text = "";
        }

        /***************Error Provider for Question text Box***************/
        // ==> set error message if question already exist
        private void QuestionTextbox_Validating(object sender, CancelEventArgs e)
        {
            if (QuestionTextbox.Text == "Question")
                return;
            if (mysql.validateQues(QuestionTextbox.Text) == true)
            {
                e.Cancel = true;
                errorQuestion.SetError(QuestionTextbox, "Question already exist in DataBase");
                errorMessageLabel.Text = "Question already exist in DataBase";
                errorMessageLabel.Show();
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(QuestionTextbox.Text, Pattern))
            {
                e.Cancel = true;
                errorQuestion.SetError(QuestionTextbox, "? is missing in the end");
                errorMessageLabel.Text = "\'? \' is missing in the end";
                errorMessageLabel.Show();
            }
        }

        // ==> If all conditions have been met, 
        // ==> clear the ErrorProvider of errors.
        private void QuestionTextbox_Validated(object sender, EventArgs e)
        {
            errorQuestion.SetError(QuestionTextbox, null);
            errorMessageLabel.Hide();
            errorMessageLabel.Text = "";
        }

        // ==> Function to return the correct option 
        private string getCorretOption()
        {
            if (ARadioBtn.Checked)
                return OpATextBox.Text;
            else if (BRadioBtn.Checked)
                return OpBTextBox.Text;
            else if (CRadioBtn.Checked)
                return OpCTextBox.Text;
            else
                return OpDTextBox.Text;
        }
        // ==> Operatons occurs when InsertBtn is pressed or clicked
        // ==> Question will store in Database table questions
        private void insetBtn_Click(object sender, EventArgs e)
        {

            // If any text box field is empty show error
            if (idTextBox.Text != "ID" && QuestionTextbox.Text != "Question" && OpATextBox.Text != "OptionA"
                && OpBTextBox.Text != "OptionB" && OpCTextBox.Text != "OptionC"
                && OpDTextBox.Text != "OptionD" && (ARadioBtn.Checked || BRadioBtn.Checked
                || CRadioBtn.Checked || DRadioBtn.Checked))
            {
                // If catagory isn't selected show error
                if (catagoryCombo.SelectedIndex == 0)
                {
                    errorMessageLabel.Text = "Kindly select Catagory";
                    errorMessageLabel.Show();
                    return;
                }

                // else insert all input in database
                if (mysql.insertQuesinDB(idTextBox.Text, QuestionTextbox.Text, OpATextBox.Text, OpBTextBox.Text
                   , OpCTextBox.Text, OpDTextBox.Text, catagoryCombo.Text, getCorretOption()) == true)
                {
                    MessageBox.Show("Congratulation!!!Data Inserted Successfully"
                        , "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    mainAdminForm form = new mainAdminForm();
                    form.Show();
                }
                else
                {
                    // if Data Insertion in database Failed
                    // Message box shown 
                    DialogResult result = MessageBox.Show("Some Error Occured!!! Try Again?"
                      , "Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (result == DialogResult.Retry)
                    {
                        // Format Form if admin try again
                        idTextBox.Text = "ID";
                        QuestionTextbox.Text = "Question";
                        OpATextBox.Text = "OptionA";
                        OpBTextBox.Text = "OptionB";
                        OpCTextBox.Text = "OptionC";
                        OpDTextBox.Text = "OptionD";
                        catagoryCombo.SelectedIndex = 0;
                    }
                    // Back to admin Panel
                    else
                    {
                        this.Hide();
                        mainAdminForm form = new mainAdminForm();
                        form.Show();
                    }
                }
            }
            else
            {
                errorMessageLabel.Text = "Kindly fill all the fields";
                errorMessageLabel.Show();
                return;
            }

        }
    }
}

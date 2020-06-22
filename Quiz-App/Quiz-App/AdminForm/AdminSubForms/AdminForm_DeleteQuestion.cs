using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Quiz_App.AdminForm.AdminSubForms
{
    public partial class AdminForm_DeleteQuestion : Form
    {
         MySQL_Data_Base.MySqlDB mysql;
        DataTable dt;
        private bool flag = false;
        public AdminForm_DeleteQuestion()
        {
            InitializeComponent();
            errorSerchId.Hide();
            errorSerchId.Text = "";
            HideandShow();
            mysql = new MySQL_Data_Base.MySqlDB();
            dt = new DataTable();
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

        // ==> Hide and Show all the labels, textboxes and line panels
        private void HideandShow()
        {
            if (flag)
            {
                QuestionTextbox.Show();
                QuestionPanelLine.Show();
                questionLabel.Show();
                OpATextBox.Show();
                OpAPanelLine.Show();
                opALabel.Show();
                OpBTextBox.Show();
                OpBPanelLine.Show();
                opBLabel.Show();
                OpCTextBox.Show();
                OpCpanelLine.Show();
                opCLabel.Show();
                OpDTextBox.Show();
                OpDpanelLine.Show();
                opDLabel.Show();
                catagorytextBox.Show();
                catagoryPanelLine.Show();
                catagoryLabel.Show();
                removeBtn.Show();
                cancelBtn.Show();
                ARadioBtn.Show();
                BRadioBtn.Show();
                CRadioBtn.Show();
                DRadioBtn.Show();
                corectOptionLabel.Show();

                flag = false;
            }
            else
            {
                QuestionTextbox.Hide();
                QuestionPanelLine.Hide();
                questionLabel.Hide();
                OpATextBox.Hide();
                OpAPanelLine.Hide();
                opALabel.Hide();
                OpBTextBox.Hide();
                OpBPanelLine.Hide();
                opBLabel.Hide();
                OpCTextBox.Hide();
                OpCpanelLine.Hide();
                opCLabel.Hide();
                OpDTextBox.Hide();
                OpDpanelLine.Hide();
                opDLabel.Hide();
                catagorytextBox.Hide();
                catagoryPanelLine.Hide();
                catagoryLabel.Hide();
                removeBtn.Hide();
                cancelBtn.Hide();
                ARadioBtn.Hide();
                BRadioBtn.Hide();
                CRadioBtn.Hide();
                DRadioBtn.Hide();
                corectOptionLabel.Hide();

                flag = true;
            }
        }

        // ==> Reinitailize TextBoxes to it's default values
        private void reInitialize()
        {
            QuestionTextbox.Text = "Question";
            OpATextBox.Text = "OptionA";
            OpBTextBox.Text = "OptionB";
            OpCTextBox.Text = "OptionC";
            OpDTextBox.Text = "OptionD";
            catagorytextBox.Text = "Catagory";
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
            if (errorSerchId.Visible == true || idTextBox.Text == "ID")
            {
                this.Hide();
                mainAdminForm form = new mainAdminForm();
                form.Show();
                return;

            }
            if (QuestionTextbox.Text != "Question" || OpATextBox.Text != "OptionA"
                || OpCTextBox.Text != "OptionC" ||
                OpDTextBox.Text != "OptionD"
                || OpBTextBox.Text != "OptionB"
                || idTextBox.Text != "ID" || catagorytextBox.Text != "Catagory")
            {
                if (showMessageBox() == true)
                    return;
                else
                {
                    this.Hide();
                    mainAdminForm form = new mainAdminForm();
                    form.Show();
                }
            }
              
            
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
                errorSerchId.Text = "Only Numbers are allowed";
                errorSerchId.Show();
            }
        }

        // ==> If all conditions have been met, 
        // ==> clear the ErrorProvider of errors.
        private void idTextBox_Validated(object sender, EventArgs e)
        {
            ErrorIdTextBox.SetError(idTextBox, null);
            errorSerchId.Show();
            errorSerchId.Text = "";
        }


        // ==> Function to execute when search Button will clicked
        private void searchBtn_Click(object sender, EventArgs e)
        {
            // if Id isn't Null or not string
            if (idTextBox.Text != "ID")
            {
                // Valdate if question id is exist in DataBase
                if (mysql.validateQuesID(idTextBox.Text) == true)
                {
                    // If id exist 
                    // Get data of spcific row in Datatable throgh sql function
                    dt = mysql.getQuestionbyID(idTextBox.Text);
                    QuestionTextbox.Text = dt.Rows[0]["questionscol"].ToString();
                    OpATextBox.Text = dt.Rows[0]["opa"].ToString();
                    OpBTextBox.Text = dt.Rows[0]["opb"].ToString();
                    OpCTextBox.Text = dt.Rows[0]["opc"].ToString();
                    OpDTextBox.Text = dt.Rows[0]["opd"].ToString();
                    catagorytextBox.Text = dt.Rows[0]["catagory"].ToString();
                    errorSerchId.Hide();
                    string correctOP = dt.Rows[0]["correctoption"].ToString();
                    // check the correct option and display in Radio Btn
                    if (correctOP == OpATextBox.Text)
                    {
                        ARadioBtn.Checked = true;
                        ARadioBtn.Enabled = true;
                    }
                    else if (correctOP == OpBTextBox.Text)
                    {
                        BRadioBtn.Checked = true;
                        BRadioBtn.Enabled = true;
                    }

                    else if (correctOP == OpCTextBox.Text)
                    {
                        CRadioBtn.Enabled = true;
                        CRadioBtn.Checked = true;
                    }
                    else
                    {
                        DRadioBtn.Checked = true;
                        DRadioBtn.Enabled = true;
                    }
                    // All the textboxes and labels will shown on Form
                    HideandShow();
                    idTextBox.ReadOnly = true;
                    searchBtn.Hide();


                }
                else
                {
                    // if id isn't present in DataBase
                    errorSerchId.Text = "ID not exist in DataBase";
                    errorSerchId.Show();
                }
            }
            else
            {
                // if id textbox is empty
                errorSerchId.Text = "ID never be Empty";
                errorSerchId.Show();
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            // if question id is valid then specified data will be deleted
            if (mysql.removeQuestionbyID(idTextBox.Text) == true)

            {
                MessageBox.Show("Congratulation!!!Data Deleted Successfully"
                    , "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                mainAdminForm form = new mainAdminForm();
                form.Show();
            }
            else
            {
                // if Data Deletation in database Failed
                // Message box shown 
                DialogResult result = MessageBox.Show("Some Error Occured!!! Try Again?"
                  , "Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    HideandShow();
                    reInitialize();
                    idTextBox.Text = "ID";
                    errorSerchId.Text = "";
                    errorSerchId.Hide();
                    return;
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

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (QuestionTextbox.Text != "Question" || OpATextBox.Text != "OptionA"
             || OpCTextBox.Text != "OptionC" ||
             OpDTextBox.Text != "OptionD"
             || OpBTextBox.Text != "OptionB"
             || catagorytextBox.Text != "Catagory")
            {
                if (showMessageBox() == true)
                    return;
            }

            this.Hide();
            mainAdminForm form = new mainAdminForm();
            form.Show();
        }
    }
}

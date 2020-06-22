using System;
using System.Data;
using System.Windows.Forms;

namespace Quiz_App.AdminForm.AdminSubForms
{
    public partial class AdminForm_ViewQuestion : Form
    {
        MySQL_Data_Base.MySqlDB mysql;
        DataTable dt;
        public AdminForm_ViewQuestion()
        {
            InitializeComponent();
            mysql = new MySQL_Data_Base.MySqlDB();
            dt = new DataTable();
        }
    
        // ==> Back to Admin Home Page
        // ==> When Back Button is clicked
        private void BackBtn_Click(object sender, EventArgs e)
        {
            mainAdminForm form = new mainAdminForm();
            this.Hide();
            form.Show();
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
        private void AdminForm_ViewQuestion_Load(object sender, EventArgs e)
        {

            dt = mysql.getQuestionTableData();
            for (int i=0;i<dt.Rows.Count;i++)
            {
                gridviewGunaUI.Rows.Add();
                gridviewGunaUI.Rows[i].Cells[0].Value = dt.Rows[i].ItemArray[0];
                gridviewGunaUI.Rows[i].Cells[1].Value = dt.Rows[i].ItemArray[1];
                gridviewGunaUI.Rows[i].Cells[2].Value = dt.Rows[i].ItemArray[2];
                gridviewGunaUI.Rows[i].Cells[3].Value = dt.Rows[i].ItemArray[3];
                gridviewGunaUI.Rows[i].Cells[4].Value = dt.Rows[i].ItemArray[4];
                gridviewGunaUI.Rows[i].Cells[5].Value = dt.Rows[i].ItemArray[5];
                gridviewGunaUI.Rows[i].Cells[6].Value = dt.Rows[i].ItemArray[7];
                gridviewGunaUI.Rows[i].Cells[7].Value = dt.Rows[i].ItemArray[6];
            }
        }
    }
}

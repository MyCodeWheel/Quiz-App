using System;
using System.Data;
using System.Windows.Forms;

namespace Quiz_App.GameForm.GameSubForms
{
    public partial class GameForm_ResultGame : Form
    {
        MySQL_Data_Base.MySqlDB mysql;
        DataTable dt;
        public GameForm_ResultGame()
        {
            InitializeComponent();
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
        private void BackBtn_Click(object sender, EventArgs e)
        {
            mainGameForm form = new mainGameForm();
            form.Show();
            this.Hide();
        }

        private void GameForm_ResultGame_Load(object sender, EventArgs e)
        {
            dt = mysql.getResultList(mainGameForm.username);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                gridviewGunaUI.Rows.Add();
                gridviewGunaUI.Rows[i].Cells[0].Value = dt.Rows[i].ItemArray[1]; // print datetime
                gridviewGunaUI.Rows[i].Cells[1].Value = dt.Rows[i].ItemArray[2]; // print total score
                gridviewGunaUI.Rows[i].Cells[2].Value = dt.Rows[i].ItemArray[0]; // print totalcorrectAns
            }
        }
    }
}

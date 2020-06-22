using System;
using System.Data;
using System.Windows.Forms;

namespace Quiz_App.GameForm.GameSubForms
{
    public partial class GameForm_PlayGame : Form
    {
        // ==> Global Variables
        // ==> totalCorrectAns == Store the number of correct answers by user
        // ==> totalscore == Store the total score user scored. Every right annwer will cost +5 totalscore
        // ==> totalQues == Store the total number of questions for specific catagory
        // ==> QuestionID == Prints the Number of Question currently Displaying
        // ==> userAns == Store the text of option buttons when click event prform on them
        // ==> catagory == Store the catagory of quesion types.
        // ==> correctAns == Store the correct answer. Retrive Correct Answer From DB

        private int totalCorrectAns, totalscore, timeLeft, totalQues, QuestionID;
        private string userAns, catagory, correctAns;
        private int GuessID; // holding id of question
        
        MySQL_Data_Base.MySqlDB sql; // MySQL object
        GameForm_OptionGamForm obj; // GameOptionFOrm object == used to get catagory of question
        DataTable dt; // DataTable to store all the data 
        
        // ==> Constructor
        public GameForm_PlayGame()
        {
            InitializeComponent();
            sql = new MySQL_Data_Base.MySqlDB();
            obj = new GameForm_OptionGamForm();
            dt = new DataTable();

            // ==> Get catagory of quiz questions
            catagory = obj.getCatagory();

            // ==> get all the questions of specific type from DB and store in Data Table
            dt = sql.getAllQuestionByCatagory(catagory);
            totalQues = dt.Rows.Count; // storte the total number of questions
            
            // ==> Initializer
            userAns = "";
            correctAns = "";
            totalCorrectAns = 0;
            totalscore = 0;
            timeLeft = 15; // for Displaying Time Left 
            QuestionID = 1; 
            
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
        // ==> Form Load FUnction 
        // ==> Call the PlayTheGame Function
        private void GameForm_PlayGame_Load(object sender, EventArgs e)
        {
            TimeLabel.Text = "";
            PlayTheGame();
        }

        // ==> Function to ask user confirmation
        // ==> When user click on Back Button During Game
        private bool showMessageBox()
        {
            string message = "Do you want to Quit the Game?";
            string title = "Close Window";
            MessageBoxButtons btn = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, btn, MessageBoxIcon.Exclamation);
            if (result == DialogResult.No) // if user don't want to quit return true
               return true;
            return false;
        }


        // ==> Navigate to Game Home Page when Back Button Clicked
        private void BackBtn_Click(object sender, EventArgs e)
        {
            // If Game is Started 
            // Ask User Confirmation
            if (QuestionID > 1)
            {
                // Stop the timer
                timer1.Stop();
                // if user want to continue playing
                if (showMessageBox())
                {
                    // start timer and return
                    timer1.Start();
                    return;
                }
            }
            // if user want to quit
            // stop the timer
            // Naviagte to MainGameForm
            timer1.Stop();
            timer1.Enabled = false;
            this.Hide();
            mainGameForm form = new mainGameForm();
            form.Show();        
        }


        // ==> Function to SHow Result of Game in Mssage Box
        private void ShowResult()
        {
            // Format Result
            string result = "You Points: {0}/50\nYour COrrect Answers: {1}/10";
            string msg = string.Format(result, Convert.ToString(totalscore), Convert.ToString(totalCorrectAns));
           // if User score is greater than averger print You Won 
            if (totalscore >= 30)
                MessageBox.Show("Congratulation!!\n"+msg,"Result",MessageBoxButtons.OK,MessageBoxIcon.Information);
            else // if User score is greater than averger print You Lose 
                MessageBox.Show("Oh you lose!!\n" + msg, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ==> Function to store result in DB
        private void UploadResult()
        {
            // Print Result in Messgae Box
            ShowResult();

            // Get Gate and time of Game
            DateTime now = DateTime.Now;

            // Format Date time in yyyy-MM-dd HH:mm:ss Format to store in MySQL DB 
            string datetime = now.ToString("yyyy-MM-dd HH:mm:ss");
            // Get the username of user who is playing ganme
            string username = mainGameForm.username;

            // If Result Store in DB print Confimation msg
            if (sql.uploadQuizResult(totalCorrectAns, datetime, totalscore, username))
                MessageBox.Show("Result Saved in Cloud Successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Error Occured During Uploading Result on Cloud", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // Naigate to Main Game Home From
            this.Hide();
            mainGameForm form = new mainGameForm();
            form.Show();
        }

        // ==> PlayTheGame Function
        // ==> Print Quesitons on Form
        // ==> Start the timer
        private void PlayTheGame()
        {
            // After 10 Questions Print Result and exit Game
            if (QuestionID == 11)
                UploadResult();
            else
            {
                // Start the Timer
                timer1.Enabled = true;
                timer1.Start();

                // Show Question ID on Form
                questionLabel.Text = Convert.ToString(QuestionID) + "/10";
                IDLabel.Text = Convert.ToString(QuestionID);
                
                // Generate Random Number For Question 
                var random = new Random();
                GuessID = random.Next(1, totalQues); // generate guess numbeb

                // Display Specific Question with Option on Form
                QuesLabel.Text = dt.Rows[GuessID]["questionscol"].ToString();
                AopBtn.Text = dt.Rows[GuessID]["opa"].ToString();
                BopBtn.Text = dt.Rows[GuessID]["opb"].ToString();
                CopBtn.Text = dt.Rows[GuessID]["opc"].ToString();
                DopBtn.Text = dt.Rows[GuessID]["opd"].ToString();
            }
        }

          
        // ==> Timer Tick Function
        // ==> Run After every second after timer start
        // ==> compare user answer with correct answer 
        // ==> Increment Score or totalCorrectAns if condition met
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Check if time left and Answer is Correct
            if (timeLeft >= 1 && userAns == correctAns && userAns!="" &&correctAns!="") 
            {
                // increment totalCorrectAns and totalscore
                // Disable timer
                // reinitialize components
                totalCorrectAns++;
                totalscore += 5;
                timer1.Enabled = false;
                timeLeft = 15; // initailize time again
                QuestionID++; // increment Question ID  
                timer1.Stop();
                userAns = "";
                correctAns = "";
                TimeLabel.Text = ""; 
                PlayTheGame();
            }
            // Check if time left and Answer is Correct OR time End or no opton is selected
            else if ((timeLeft >= 1 && userAns != correctAns&&userAns!="" && correctAns != "") ||(timeLeft<=0))
            {
                // Disable timer
                // reinitialize components
                timer1.Enabled = false;
                timeLeft = 15;// initailize time again
                QuestionID++; // increment Question ID  
                timer1.Stop();
                userAns = "";
                correctAns = "";
                TimeLabel.Text = "";
                PlayTheGame();
              
            }
            // Print time and Decrememtn time by 1 
            else
            {
                TimeLabel.Text = Convert.ToString(timeLeft) + " sec";
                timeLeft--;
            }



        }

        // ==> Store userAns and correctAns 
        // ==> When Option Button is clicked
        private void BtnClcik(object sender, EventArgs e)
        {
            // Button Object
            Guna.UI2.WinForms.Guna2GradientButton obj = (Guna.UI2.WinForms.Guna2GradientButton)sender;
            userAns = obj.Text; // store user answer
            correctAns = sql.getCorrectAnswer(GuessID+1); // get correct answer from DB

        }
    }
}

using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
namespace Quiz_App.MySQL_Data_Base
{
    class MySqlDB
    {
        // connection object
        private MySqlConnection connection;
        private MySqlDataAdapter adapter;
        private DataTable dt;
        private MySqlCommand cmd;
        private DataSet ds; // For Validation
        private string server, db, username, password;

        public MySqlDB()
        {
            connectDB();
        }

        // Function to connect Database
        private void connectDB()
        {
            server = "localhost";
            db = "quizapp";
            username = "root";
            password = "root";

            string conn = "SERVER=" + server + ";" + "DATABASE=" + db + ";"
                + "USERNAME=" + username + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(conn);
        }


        // Open Connection Validation Function
        private bool openConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // CLose Connection Validation Function
        private bool closeConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException errMsg)
            {
                MessageBox.Show(errMsg.Message);
            }
            return false;
        }


        // ==> Function to validate admin presence
        // ==> take admin username or password as input and 
        // ==> return true or false after validation
        public bool isValidAdmin(string username, string password)
        {

            string query = "SELECT * FROM `admin` WHERE username=\'" + username + "\' AND password=\'" + password + "\';";
            if (this.openConnection() == true)
            {
                try
                {
                    adapter = new MySqlDataAdapter(query, connection);
                    ds = new DataSet();
                    adapter.Fill(ds);
                    int count = ds.Tables[0].Rows.Count;
                    if (count == 1)
                    {
                        this.closeConnection();
                        return true;

                    }
                }
                catch (Exception ex) when (ex is MySqlException || ex is SystemException)
                {
                    this.closeConnection();
                    return false;
                }
            }
            this.closeConnection();
            return false;
        }

        // ==> Function to validate qurstion id presence
        // ==> take question id as input and return 
        // ==> true if id exist else return false
        public bool validateQuesID(string id)
        {
            string query = "SELECT `questionscol` FROM `questions` WHERE idquestions=\'" + id + "\';";
            if (this.openConnection() == true)
            {
                try
                {
                    adapter = new MySqlDataAdapter(query, connection);
                    ds = new DataSet();
                    adapter.Fill(ds);
                    int count = ds.Tables[0].Rows.Count;
                    if (count == 1)
                    {
                        this.closeConnection();
                        return true;
                    }
                }
                catch (Exception ex) when (ex is MySqlException || ex is SystemException)
                {
                    this.closeConnection();
                    return false;
                }
            }
            this.closeConnection();
            return false;
        }

        // ==> Function to validate qurstion presence
        // ==> take question as input and return 
        // ==> true if question exist else return false
        public bool validateQues(string question)
        {
            string query = "SELECT `questionscol` FROM `questions` WHERE questionscol=\'" + question + "\';";
            if (this.openConnection() == true)
            {
                try
                {
                    adapter = new MySqlDataAdapter(query, connection);
                    ds = new DataSet();
                    adapter.Fill(ds);
                    int count = ds.Tables[0].Rows.Count;
                    if (count == 1)
                    {
                        this.closeConnection();
                        return true;
                    }
                }
                catch (Exception ex) when (ex is MySqlException || ex is SystemException)
                {
                    this.closeConnection();
                    return false;
                }
            }
            this.closeConnection();
            return false;
        }


        // ==> Function to validate qurstion presence except the question which is updating
        // ==> take question as input and return 
        // ==> true if question exist else return false
        public bool validateQuesExceptUpdateQuestion(string question, string id)
        {
            string query = "SELECT * FROM `questions` WHERE NOT idquestions=\'" + id + "\' AND questionscol=\'" + question + "\';";
            if (this.openConnection() == true)
            {
                try
                {
                    adapter = new MySqlDataAdapter(query, connection);
                    ds = new DataSet();
                    adapter.Fill(ds);
                    int count = ds.Tables[0].Rows.Count;
                    if (count == 1)
                    {
                        this.closeConnection();
                        return true;
                    }
                }
                catch (Exception ex) when (ex is MySqlException || ex is SystemException)
                {
                    this.closeConnection();
                    return false;
                }
            }
            this.closeConnection();
            return false;
        }

        public bool insertQuesinDB(string id, string question,
            string opA, string opB,
            string opC, string opD,
            string catagory, string correctOption)
        {
            string query = "INSERT INTO `questions`( " +
                "`idquestions`, " +
                "`questionscol`, " +
                "`opa`, " +
                "`opb`, " +
                "`opc`, " +
                "`opd`, " +
                "`catagory`, " +
                "`correctoption`) VALUES (\'" +
                id + "\',\'" +
                question + "\',\'" +
                opA + "\',\'" +
                opB + "\',\'" +
                opC + "\',\'" +
                opD + "\',\'" +
                catagory + "\',\'" +
                correctOption + "\')";
            if (this.openConnection() == true)
            {
                try
                {
                    cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    this.closeConnection();
                    return true;
                }
                catch (Exception ex) when (ex is MySqlException || ex is SystemException)
                {
                    this.closeConnection();
                    return false;
                }
            }
            this.closeConnection();
            return false;
        }


        public DataTable getQuestionbyID(string id)
        {
            string query = "SELECT * FROM `questions` WHERE idquestions=\'" + id + "\';";
            this.openConnection();
            adapter = new MySqlDataAdapter(query, connection);
            dt = new DataTable();
            adapter.Fill(dt);
            this.closeConnection();
            return dt;

        }
        // ==> Function to return the data from SQL Question Table
        public DataTable getQuestionTableData()
        {
            string query = "SELECT * FROM `quizapp`.`questions`;";
            this.openConnection();
            adapter = new MySqlDataAdapter(query, connection);
            dt = new DataTable();
            adapter.Fill(dt);
            this.closeConnection();
            return dt;

        }


        public bool removeQuestionbyID(string id)
        {
            string query = "DELETE FROM `questions` WHERE idquestions=\'" + id + "\';";
            if (this.openConnection() == true)
            {
                try
                {
                    cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    this.closeConnection();
                    return true;
                }
                catch (Exception ex) when (ex is MySqlException || ex is SystemException)
                {
                    this.closeConnection();
                    return false;
                }
            }
            this.closeConnection();
            return false;
        }

        // Update Question Function
        public bool updateQuestionbyID(string id, string question,
            string opA, string opB,
            string opC, string opD,
            string catagory, string correctOption)
        {
            string query = "UPDATE `questions` SET questionscol=\'" + question + "\',opa=\'" + opA + "\',opb=\'" + opB + "\'," +
                "opc=\'" + opC + "\',opd=\'" + opD + "\',catagory=\'" + catagory + "\',correctoption=\'" + correctOption + "\'" +
                " WHERE idquestions=\'" + id + "\';";

            if (this.openConnection() == true)
            {
                try
                {
                    cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    this.closeConnection();
                    return true;
                }
                catch (Exception ex) when (ex is MySqlException || ex is SystemException)
                {
                    this.closeConnection();
                    return false;
                }
            }
            this.closeConnection();
            return false;
        }


        /************User Data Base Functions************/
        // ==> Function to validate admin presence
        // ==> take admin username or password as input and 
        // ==> return true or false after validation
        public bool isValidUser(string username, string password)
        {

            string query = "SELECT * FROM `user` WHERE username=\'" + username + "\' AND password=\'" + password + "\';";
            if (this.openConnection() == true)
            {
                try
                {
                    adapter = new MySqlDataAdapter(query, connection);
                    ds = new DataSet();
                    adapter.Fill(ds);
                    int count = ds.Tables[0].Rows.Count;
                    if (count == 1)
                    {
                        this.closeConnection();
                        return true;

                    }
                }
                catch (Exception ex) when (ex is MySqlException || ex is SystemException)
                {
                    this.closeConnection();
                    return false;
                }
            }
            this.closeConnection();
            return false;
        }

        // ==> Function to insert signup data into DB
        public bool signupUserInsertion(string username,string password,string name)
        {
            string query = "INSERT INTO `user`( " +
             "`username`, " +
             "`password`, " +
             "`name`) VALUES (\'" +
             username + "\',\'" +
             password + "\',\'" +
             name +"\')";

            if (this.openConnection() == true)
            {
                try
                {
                    cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    this.closeConnection();
                    return true;
                }
                catch (Exception ex) when (ex is MySqlException || ex is SystemException)
                {
                    this.closeConnection();
                    return false;
                }
            }
            this.closeConnection();
            return false;
        }
        
        // ==> Function to Validate Username presence in  Data Base
        public bool isUsernameAvailable(string username)
        {
            string query = "SELECT `username` FROM `user` WHERE username=\'" + username + "\';";
            if (this.openConnection() == true)
            {
                try
                {
                    adapter = new MySqlDataAdapter(query, connection);
                    ds = new DataSet();
                    adapter.Fill(ds);
                    int count = ds.Tables[0].Rows.Count;
                    if (count == 1)
                    {
                        this.closeConnection();
                        return true;
                    }
                }
                catch (Exception ex) when (ex is MySqlException || ex is SystemException)
                {
                    this.closeConnection();
                    return false;
                }
            }
            this.closeConnection();
            return false;

        }
   
        // ==> Function to return all the data from question table
        // ==> From Specific Catagory
        public DataTable getAllQuestionByCatagory(string catagory)
        {
            string query = "SELECT * FROM `questions` WHERE catagory=\'"+catagory+"\';";
            openConnection();
            adapter = new MySqlDataAdapter(query, connection);
            dt = new DataTable();
            adapter.Fill(dt);
            closeConnection();
            return dt;
        }
        // ==> Function to return correct answer
        public string getCorrectAnswer(int id)
        {
            string query = "SELECT `correctoption` FROM `questions` WHERE idquestions=\'"+Convert.ToString(id)+"\';";
            openConnection();
            adapter = new MySqlDataAdapter(query, connection);
            dt = new DataTable();
            adapter.Fill(dt);
            closeConnection();
            return dt.Rows[0]["correctoption"].ToString();
        
        }

        // ==> Function to upload quiz Result in DB
        public bool uploadQuizResult(int ans,string date,int score,string user)
        {
            string query = "INSERT INTO `quizapp`.`result` ( `correctanswers`, `datetime`, `totalscore`,`username`) VALUES ('"+Convert.ToString(ans)+"\', '"+date+"\', '"+Convert.ToString(score)+"\','"+user+"\');";

            if (this.openConnection())
            {
                try
                {
                    cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    this.closeConnection();
                    return true;
                }
                catch (Exception ex) when (ex is MySqlException || ex is SystemException)
                {
                    MessageBox.Show(ex.Message);
                    this.closeConnection();
                    return false;
                }
            }
            this.closeConnection();
            return false;
        }

        // ==> Function to return the list of Result for specfic user
        public DataTable getResultList(string user)
        {
            string query = "SELECT * FROM `quizapp`.`result`  WHERE `username`=\'" + user + "\';";
            this.openConnection();
            adapter = new MySqlDataAdapter(query, connection);
            dt = new DataTable();
            adapter.Fill(dt);
            this.closeConnection();
            return dt;

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace Trivia_Games
{
    class TriviaDataLayer
    {
        private OleDbConnection conn;
        private OleDbCommand comm;
        private OleDbDataReader userReader;
        private OleDbDataReader questionReader;

        public TriviaDataLayer()
        {
                string connString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Trivia Games.accdb";
                conn = new OleDbConnection(connString);
        }

        public List<string> getCombinedScore(User u)
        {
            conn.Open();

            List<String> CombinedScore = new List<String>();

            string selectCombinedScore = "Select CorrectAnswersTotal, QuestionsTotal from users WHERE UserID = ?";

            comm = new OleDbCommand(selectCombinedScore, conn);

            OleDbParameter idParam = new OleDbParameter("UserID", u.UserID);

            comm.Parameters.Add(idParam);

            userReader = comm.ExecuteReader(CommandBehavior.CloseConnection);

            userReader.Read();

            CombinedScore.Add(userReader[0].ToString());

            CombinedScore.Add(userReader[1].ToString());

            userReader.Close();

            conn.Close();

            return CombinedScore;

        }

        public void UpdateUserResults(User u, int NbMaxOfQuestions)
        {
            conn.Open();
            string updateUser = "UPDATE Users SET " +
                                   "CorrectAnswersTotal = CorrectAnswersTotal + ?, " +
                                   "QuestionsTotal = QuestionsTotal + ?" +
                                   "WHERE UserID = ?";

            comm = new OleDbCommand(updateUser, conn);

            OleDbParameter catParam = new OleDbParameter("CorrectAnswersTotal", u.CorrectAnswersNumber);
            OleDbParameter qtParam = new OleDbParameter("QuestionsTotal", NbMaxOfQuestions);
            OleDbParameter idParam = new OleDbParameter("UserID", u.UserID);

            comm.Parameters.Add(catParam);
            comm.Parameters.Add(qtParam);
            comm.Parameters.Add(idParam);

            comm.ExecuteNonQuery();
            conn.Close();

        }

        public void UnflagAllQuestions()
        {
            conn.Open();

            string updateUser = "UPDATE QUESTIONS SET " +
                                   "AlreadyUsed = 0 ";

            comm = new OleDbCommand(updateUser, conn);

            comm.ExecuteNonQuery();
          
            conn.Close();
        }

        public void FlagQuestionRecord(Question_Answers qa)
        {
            conn.Open();
            string updateUser = "UPDATE QUESTIONS SET " +
                                   "AlreadyUsed = 1 " +
                                   "WHERE questionID = ?";

            comm = new OleDbCommand(updateUser, conn);

            OleDbParameter QuestionIDParam = new OleDbParameter("questionID", qa.QuestionID);

            comm.Parameters.Add(QuestionIDParam);
            
            comm.ExecuteNonQuery();
            conn.Close();

        }

        public List<Question_Answers> getQuestionsList()
        {
            conn.Open();

            List<Question_Answers> allQuestions = new List<Question_Answers>();

            string selectQuestions = "SELECT * from QUESTIONS where alreadyused = 0 order by QuestionID";

            comm = new OleDbCommand(selectQuestions, conn);

            questionReader = comm.ExecuteReader(CommandBehavior.CloseConnection);

            while (questionReader.Read())
            {
                string id = questionReader["QuestionID"].ToString();
                string question = questionReader["Question"].ToString();
                string answer1 = questionReader["Answer1"].ToString();
                string answer2 = questionReader["Answer2"].ToString();
                string answer3 = questionReader["Answer3"].ToString();
                string answer4 = questionReader["Answer4"].ToString();
                string correctAnswer = questionReader["CorrectAnswer"].ToString();

                Question_Answers questionAndAnswers = new Question_Answers(id, question, answer1, answer2, 
                                                                            answer3, answer4, correctAnswer);
                allQuestions.Add(questionAndAnswers);
            }

            if (allQuestions.Count == 0)
            {
                string updateUser = "UPDATE QUESTIONS SET " +
                                   "AlreadyUsed = 0 ";

                comm = new OleDbCommand(updateUser, conn);

                comm.ExecuteNonQuery();

                selectQuestions = "SELECT * from QUESTIONS where alreadyused = 0 order by QuestionID";

                comm = new OleDbCommand(selectQuestions, conn);

                questionReader = comm.ExecuteReader(CommandBehavior.CloseConnection);

                while (questionReader.Read())
                {
                    string id = questionReader["QuestionID"].ToString();
                    string question = questionReader["Question"].ToString();
                    string answer1 = questionReader["Answer1"].ToString();
                    string answer2 = questionReader["Answer2"].ToString();
                    string answer3 = questionReader["Answer3"].ToString();
                    string answer4 = questionReader["Answer4"].ToString();
                    string correctAnswer = questionReader["CorrectAnswer"].ToString();

                    Question_Answers questionAndAnswers = new Question_Answers(id, question, answer1, answer2,
                                                                                answer3, answer4, correctAnswer);
                    allQuestions.Add(questionAndAnswers);
                }
            }

            questionReader.Close();

            return allQuestions;

        }

        public List<User> getUsersList()
        {
            try
            {
                conn.Open();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Unable to open the database connection", "Alert Message");
            }

            List<User> allUsers = new List<User>();

            string selectUsers = "SELECT * from USERS order by userID";

            comm = new OleDbCommand(selectUsers, conn);

            userReader = comm.ExecuteReader(CommandBehavior.CloseConnection);
            
            while(userReader.Read())
            {
                string id = userReader["UserID"].ToString();
                string fname = userReader["FirstName"].ToString();
                string lname = userReader["LastName"].ToString();
                string picName = userReader["Picture"].ToString();

                User user = new User(id, fname, lname, picName);
                allUsers.Add(user);
            }

            userReader.Close();

            return allUsers;

        }

        public void AddNewUser(User u)
        {
            conn.Open();

            string insertUser = "INSERT INTO USERS (FirstName, LastName, Picture, CorrectAnswersTotal, QuestionsTotal) VALUES (?,?,?,0,0)";

            comm = new OleDbCommand(insertUser, conn);

            OleDbParameter fnameParameter = new OleDbParameter("FirstName", u.UserFirstName);
            OleDbParameter lnameParameter = new OleDbParameter("LastName", u.UserLastName);
            OleDbParameter picParameter = new OleDbParameter("Picture", u.PicUser);

            comm.Parameters.Add(fnameParameter);
            comm.Parameters.Add(lnameParameter);
            comm.Parameters.Add(picParameter);
            comm.ExecuteNonQuery();

        }

        public string getNewRecordID()
        {
            string newID = "";

            string selectNewID = "Select @@Identity from users";
            //string selectNewID = "Select max(userid) from users";
            comm = new OleDbCommand(selectNewID, conn);

            userReader = comm.ExecuteReader(CommandBehavior.CloseConnection);

            userReader.Read();

            newID = userReader[0].ToString();

            userReader.Close();

            return newID;

        }


        public void editUserRecord(User u)
        {
            conn.Open();
            string updateUser = "UPDATE Users SET " +
                                   "FirstName = ?, " +
                                   "LastName = ?, " +
                                   "Picture = ?" +
                                   "WHERE UserID = ?";

            comm = new OleDbCommand(updateUser, conn);

            OleDbParameter fnameParam = new OleDbParameter("FirstName", u.UserFirstName);
            OleDbParameter lnameParam = new OleDbParameter("LastName", u.UserLastName);
            OleDbParameter picParam = new OleDbParameter("Picture", u.PicUser);
            OleDbParameter idParam = new OleDbParameter("UserID", u.UserID);

            comm.Parameters.Add(fnameParam);
            comm.Parameters.Add(lnameParam);
            comm.Parameters.Add(picParam);
            comm.Parameters.Add(idParam);

            comm.ExecuteNonQuery();
            conn.Close();

        }

        public void deleteUser(User u)
        {
            conn.Open();

            string deleteUser = "DELETE FROM users WHERE userID=?";

            comm = new OleDbCommand(deleteUser, conn);

            OleDbParameter paramID = new OleDbParameter("UserID", u.UserID);

            comm.Parameters.Add(paramID);

            comm.ExecuteNonQuery();

            conn.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trivia_Games
{
    public partial class Trivia_Questions : Form
    {
        int NbMaxOfQuestions;

        TriviaDataLayer dataHandler = new TriviaDataLayer();

        List<User> playersList = new List<User>();

        UserCurrentPoints CurrentPlayer;
        List<UserCurrentPoints> CurrentPlayerList = new List<UserCurrentPoints>();

        int numberOfPlayers, currentPlayer = 1;

        List<Question_Answers> questionsList = new List<Question_Answers>();
        int Nquestions = 0, NbQuestions = 1, indexQuestion = 1;

        public Trivia_Questions()
        {
            InitializeComponent();
        }

        public Trivia_Questions(List<User> pList, int nbPlayers, int nbQuestions)
        {
            playersList = pList;
            numberOfPlayers = nbPlayers;
            NbMaxOfQuestions = nbQuestions;
            InitializeComponent();
        }

        private void Trivia_Questions_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon("pies.ico");
            BackgroundImage = Image.FromFile("Trivia-Background3.png");

            for (int i = 0; i < numberOfPlayers; i++)
            {
                CurrentPlayer = new UserCurrentPoints(playersList[i].UserID
                                                            , playersList[i].UserFirstName
                                                            , playersList[i].UserLastName
                                                            , 0);

                CurrentPlayerList.Add(CurrentPlayer);
            }

            lblPlayer.Text = "Player " + currentPlayer + ": " + playersList[currentPlayer - 1].UserFirstName + " " 
                             + playersList[currentPlayer - 1].UserLastName;
            lblNbquestion.Text = "Question " + NbQuestions + ":";

            if (playersList[currentPlayer - 1].PicUser != "")
                picPlayer.Image = Image.FromFile(playersList[currentPlayer - 1].PicUser);
            else
                picPlayer.Image = Image.FromFile("no-image.jpg");

            questionsList = dataHandler.getQuestionsList();

            lblQuestion.Text = questionsList[Nquestions].Question;

            lblAnswer1.Text = questionsList[Nquestions].Answer1;
            lblAnswer2.Text = questionsList[Nquestions].Answer2;
            lblAnswer3.Text = questionsList[Nquestions].Answer3;
            lblAnswer4.Text = questionsList[Nquestions].Answer4;

            dataHandler.FlagQuestionRecord(questionsList[Nquestions]);

            radioButton1.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            radioButton2.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            radioButton3.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            radioButton4.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);

            btnNextQuestion.Enabled = false;
            btnResult.Enabled = false;

            lblPlayer.Font = new Font(lblQuestion.Font.Name, 8, FontStyle.Bold);
            lblPlayer.BackColor = Color.Transparent;
            lblPlayer.ForeColor = Color.Red;

            lblQuestion.Font = new Font(lblQuestion.Font.Name, 8, FontStyle.Bold);
            lblQuestion.BackColor = Color.Transparent;
            lblQuestion.ForeColor = Color.Red;

            lblAnswer1.Font = new Font(lblQuestion.Font.Name, 8, FontStyle.Bold);
            lblAnswer1.BackColor = Color.Transparent;
            lblAnswer1.ForeColor = Color.Red;

            lblAnswer2.Font = new Font(lblQuestion.Font.Name, 8, FontStyle.Bold);
            lblAnswer2.BackColor = Color.Transparent;
            lblAnswer2.ForeColor = Color.Red;

            lblAnswer3.Font = new Font(lblQuestion.Font.Name, 8, FontStyle.Bold);
            lblAnswer3.BackColor = Color.Transparent;
            lblAnswer3.ForeColor = Color.Red;

            lblAnswer4.Font = new Font(lblQuestion.Font.Name, 8, FontStyle.Bold);
            lblAnswer4.BackColor = Color.Transparent;
            lblAnswer4.ForeColor = Color.Red;

            lblResult.Font = new Font(lblQuestion.Font.Name, 8, FontStyle.Bold);
            lblResult.BackColor = Color.Transparent;
            lblResult.ForeColor = Color.Red;

            lblNbquestion.Font = new Font(lblQuestion.Font.Name, 8, FontStyle.Bold);
            lblNbquestion.BackColor = Color.Transparent;
            lblNbquestion.ForeColor = Color.Red;

            panel1.BackColor = Color.Transparent;

        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (NbQuestions <= NbMaxOfQuestions * numberOfPlayers)
            {
          
                int correctAnswer = int.Parse(questionsList[Nquestions].CorrectAnswer);

                if (NbQuestions < NbMaxOfQuestions * numberOfPlayers)
                    btnNextQuestion.Enabled = true;
                else
                {
                    btnNextQuestion.Enabled = false;
                    btnResult.Enabled = true;
                }

                if (radioButton1.Checked)
                {
                    radioButton1.AutoCheck = true;
                    radioButton2.AutoCheck = false;
                    radioButton3.AutoCheck = false;
                    radioButton4.AutoCheck = false;

                    if (correctAnswer == 1)
                    {
                        lblResult.Text = "CORRECT !!!";
                        playersList[currentPlayer - 1].CorrectAnswersNumber++;
                        CurrentPlayerList[currentPlayer - 1].NumberOfCorrectAnswers1++;
                    }
                    else
                        switch (correctAnswer)
                        {
                            case 2:
                                lblResult.Text = "Incorrect!!! The Correct response is " + questionsList[Nquestions].Answer2;
                                break;
                            case 3:
                                lblResult.Text = "Incorrect!!! The Correct response is " + questionsList[Nquestions].Answer3;
                                break;
                            case 4:
                                lblResult.Text = "Incorrect!!! The Correct response is " + questionsList[Nquestions].Answer4;
                                break;
                        }
                }
                else if (radioButton2.Checked)
                {
                    radioButton1.AutoCheck = false;
                    radioButton2.AutoCheck = true;
                    radioButton3.AutoCheck = false;
                    radioButton4.AutoCheck = false;

                    if (correctAnswer == 2)
                    {
                        lblResult.Text = "CORRECT !!!";
                        playersList[currentPlayer - 1].CorrectAnswersNumber++;
                        CurrentPlayerList[currentPlayer - 1].NumberOfCorrectAnswers1++;
                    }
                    else
                        switch (correctAnswer)
                        {
                            case 1:
                                lblResult.Text = "Incorrect!!! The Correct response is " + questionsList[Nquestions].Answer1;
                                break;
                            case 3:
                                lblResult.Text = "Incorrect!!! The Correct response is " + questionsList[Nquestions].Answer3;
                                break;
                            case 4:
                                lblResult.Text = "Incorrect!!! The Correct response is " + questionsList[Nquestions].Answer4;
                                break;
                        }
                }
                else if (radioButton3.Checked)
                {
                    radioButton1.AutoCheck = false;
                    radioButton2.AutoCheck = false;
                    radioButton3.AutoCheck = true;
                    radioButton4.AutoCheck = false;

                    if (correctAnswer == 3)
                    {
                        lblResult.Text = "CORRECT !!!";
                        playersList[currentPlayer - 1].CorrectAnswersNumber++;
                        CurrentPlayerList[currentPlayer - 1].NumberOfCorrectAnswers1++;
                    }
                    else
                        switch (correctAnswer)
                        {
                            case 1:
                                lblResult.Text = "Incorrect!!! The Correct response is " + questionsList[Nquestions].Answer1;
                                break;
                            case 2:
                                lblResult.Text = "Incorrect!!! The Correct response is " + questionsList[Nquestions].Answer2;
                                break;
                            case 4:
                                lblResult.Text = "Incorrect!!! The Correct response is " + questionsList[Nquestions].Answer4;
                                break;
                        }
                }
                else if (radioButton4.Checked)
                {
                    radioButton1.AutoCheck = false;
                    radioButton2.AutoCheck = false;
                    radioButton3.AutoCheck = false;
                    radioButton4.AutoCheck = true;

                    if (correctAnswer == 4)
                    {
                        lblResult.Text = "CORRECT !!!";
                        playersList[currentPlayer - 1].CorrectAnswersNumber++;
                        CurrentPlayerList[currentPlayer - 1].NumberOfCorrectAnswers1++;
                    }
                    else
                        switch (correctAnswer)
                        {
                            case 1:
                                lblResult.Text = "Incorrect!!! The Correct response is " + questionsList[Nquestions].Answer1;
                                break;
                            case 2:
                                lblResult.Text = "Incorrect!!! The Correct response is " + questionsList[Nquestions].Answer2;
                                break;
                            case 3:
                                lblResult.Text = "Incorrect!!! The Correct response is " + questionsList[Nquestions].Answer3;
                                break;
                        }
                }
            }
            else
            {
                btnNextQuestion.Enabled = false;
                btnResult.Enabled = true;
            }
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
                currentPlayer++;

                if (numberOfPlayers < currentPlayer)
                    currentPlayer = 1;

                if (playersList[currentPlayer - 1].PicUser != "" && playersList[currentPlayer - 1].PicUser != null)
                    picPlayer.Image = Image.FromFile(playersList[currentPlayer - 1].PicUser);
                else
                    picPlayer.Image = Image.FromFile("no-image.jpg");

                lblPlayer.Text = "Player " + currentPlayer + ": " + playersList[currentPlayer - 1].UserFirstName + " " + playersList[currentPlayer - 1].UserLastName;

                radioButton1.AutoCheck = true;
                radioButton2.AutoCheck = true;
                radioButton3.AutoCheck = true;
                radioButton4.AutoCheck = true;

                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;

                lblResult.Text = "";
                btnNextQuestion.Enabled = false;

                if (Nquestions == questionsList.Count - 1)
                {
                    Nquestions = 0;
                    dataHandler.UnflagAllQuestions();
                    questionsList = dataHandler.getQuestionsList();
                    NbQuestions++;
                }
                else
                {
                    Nquestions++;
                    NbQuestions++;
                }

                if (lblPlayer.Text.Substring(0,8) == "Player 1")
                { 
                   lblNbquestion.Text = "Question " + ++indexQuestion + ":";
                }

                lblQuestion.Text = questionsList[Nquestions].Question;

                lblAnswer1.Text = questionsList[Nquestions].Answer1;
                lblAnswer2.Text = questionsList[Nquestions].Answer2;
                lblAnswer3.Text = questionsList[Nquestions].Answer3;
                lblAnswer4.Text = questionsList[Nquestions].Answer4;

                dataHandler.FlagQuestionRecord(questionsList[Nquestions]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.OpenForms["SelectUsers"].Show();
            this.Close();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            for (int iPlayer = 0; iPlayer < numberOfPlayers; iPlayer++)
            {
                playersList[iPlayer].NumberOfQuestions = playersList[iPlayer].NumberOfQuestions
                                                                    + NbMaxOfQuestions;
                dataHandler.UpdateUserResults(playersList[iPlayer], NbMaxOfQuestions);
            }


            Results frm = new Results(playersList, numberOfPlayers, CurrentPlayerList, NbMaxOfQuestions);
            frm.Show();
            this.Hide();
        }
    }
}

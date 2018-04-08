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
    public partial class Results : Form
    {
        TriviaDataLayer dataHandler = new TriviaDataLayer();

        List<User> playersList = new List<User>();
        List<UserCurrentPoints> CurrentPList = new List<UserCurrentPoints>();

        int numberOfPlayers, currentPlayer = 1;
        int nbOfQuestions;
        int dRate;


        public Results()
        {
            InitializeComponent();
        }

        public Results(List<User> plist, int nbPlayers, List<UserCurrentPoints> CurrentPlayerList, int NbMaxOfQuestions)
        {
            playersList = plist;
            numberOfPlayers = nbPlayers;
            CurrentPList = CurrentPlayerList;
            nbOfQuestions = NbMaxOfQuestions;
            InitializeComponent();
        }

        private void Results_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon("pies.ico");
            BackgroundImage = Image.FromFile("Trivia-Background4.jpg");

            lblPlayer.Font = new Font(lblPlayer.Font.Name, 8, FontStyle.Bold);
            lblPlayer.BackColor = Color.Transparent;
            lblPlayer.ForeColor = Color.Black;

            lblSessionResults.Font = new Font(lblPlayer.Font.Name, 8, FontStyle.Bold);
            lblSessionResults.BackColor = Color.Transparent;
            lblSessionResults.ForeColor = Color.Black;

            lblSessionTotalQuestions.Font = new Font(lblPlayer.Font.Name, 8, FontStyle.Bold);
            lblSessionTotalQuestions.BackColor = Color.Transparent;
            lblSessionTotalQuestions.ForeColor = Color.Black;

            lblSessionRate.Font = new Font(lblPlayer.Font.Name, 8, FontStyle.Bold);
            lblSessionRate.BackColor = Color.Transparent;
            lblSessionRate.ForeColor = Color.Black;

            lblPrevGameResults.Font = new Font(lblPlayer.Font.Name, 8, FontStyle.Bold);
            lblPrevGameResults.BackColor = Color.Transparent;
            lblPrevGameResults.ForeColor = Color.Black;

            lblPrevGameTotalQuestions.Font = new Font(lblPlayer.Font.Name, 8, FontStyle.Bold);
            lblPrevGameTotalQuestions.BackColor = Color.Transparent;
            lblPrevGameTotalQuestions.ForeColor = Color.Black;

            lblPrevGameRate.Font = new Font(lblPlayer.Font.Name, 8, FontStyle.Bold);
            lblPrevGameRate.BackColor = Color.Transparent;
            lblPrevGameRate.ForeColor = Color.Black;

            lblCombinedResults.Font = new Font(lblPlayer.Font.Name, 8, FontStyle.Bold);
            lblCombinedResults.BackColor = Color.Transparent;
            lblCombinedResults.ForeColor = Color.Black;

            lblCombinedTotalQuestions.Font = new Font(lblPlayer.Font.Name, 8, FontStyle.Bold);
            lblCombinedTotalQuestions.BackColor = Color.Transparent;
            lblCombinedTotalQuestions.ForeColor = Color.Black;

            lblCombinedRate.Font = new Font(lblPlayer.Font.Name, 8, FontStyle.Bold);
            lblCombinedRate.BackColor = Color.Transparent;
            lblCombinedRate.ForeColor = Color.Black;

            grpGameScore.Font = new Font(lblPlayer.Font.Name, 8, FontStyle.Bold);
            grpGameScore.BackColor = Color.Transparent;
            grpGameScore.ForeColor = Color.Red;

            grpSessionScore.Font = new Font(lblPlayer.Font.Name, 8, FontStyle.Bold);
            grpSessionScore.BackColor = Color.Transparent;
            grpSessionScore.ForeColor = Color.Red;

            grpCombinedScore.Font = new Font(lblPlayer.Font.Name, 8, FontStyle.Bold);
            grpCombinedScore.BackColor = Color.Transparent;
            grpCombinedScore.ForeColor = Color.Red;

            UpdateDisplay();

            if (numberOfPlayers > 1)
            {
                btnNextPlayer.Enabled = true;
                btnPrevPlayer.Enabled = true;
            }
            else
            {
                btnNextPlayer.Enabled = false;
                btnPrevPlayer.Enabled = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.OpenForms["SelectUsers"].Show();
            this.Close();
        }

        private void btnNextPlayer_Click(object sender, EventArgs e)
        {
            btnPrevPlayer.Enabled = true;

            currentPlayer++;

            if (currentPlayer > numberOfPlayers)
                currentPlayer = 1;           

            UpdateDisplay();
        }

        private void btnPrevPlayer_Click(object sender, EventArgs e)
        {
            btnNextPlayer.Enabled = true;

            currentPlayer--;

            if (currentPlayer <= 0)
                currentPlayer = numberOfPlayers;

            UpdateDisplay();
        }

        public void UpdateDisplay()
        {

            lblPlayer.Text = "Player " + currentPlayer + ": " + playersList[currentPlayer - 1].UserFirstName + " " + playersList[currentPlayer - 1].UserLastName;

            /******************************************************************************/
            // Last Game

            dRate = (int)(((decimal)CurrentPList[currentPlayer - 1].NumberOfCorrectAnswers1
                           / (decimal)nbOfQuestions) * 100);

            lblPrevGameResults.Text = "Correct Answers: " + (CurrentPList[currentPlayer - 1].NumberOfCorrectAnswers1).ToString();

            lblPrevGameTotalQuestions.Text = "Total of Questions: " + nbOfQuestions.ToString();

            lblPrevGameRate.Text = "Rate: " + dRate.ToString() + "%"; 

            /******************************************************************************/
            // Current Session

            dRate = (int)(((decimal)playersList[currentPlayer - 1].CorrectAnswersNumber
                            / (decimal)playersList[currentPlayer - 1].NumberOfQuestions) * 100);

            lblSessionResults.Text = "Correct Answers: " + playersList[currentPlayer - 1].CorrectAnswersNumber.ToString();

            lblSessionRate.Text = "Rate: " + dRate.ToString() + "%"; 

            lblSessionTotalQuestions.Text = "Total of Questions: " + playersList[currentPlayer - 1].NumberOfQuestions;

            /******************************************************************************/
            // Total Results 

            List<String> CombinedScore = new List<String>();

            CombinedScore = dataHandler.getCombinedScore(playersList[currentPlayer - 1]);

            dRate = (int)((decimal.Parse(CombinedScore[0]) / decimal.Parse(CombinedScore[1])) * 100);

            lblCombinedResults.Text = "Correct Answers: " + CombinedScore[0].ToString();

            lblCombinedTotalQuestions.Text = "Total of Questions: " + CombinedScore[1].ToString();

            lblCombinedRate.Text = "Rate: " + dRate.ToString() + "%";

            /******************************************************************************/

            if (playersList[currentPlayer - 1].PicUser != "")
                picPlayer.Image = Image.FromFile(playersList[currentPlayer - 1].PicUser);
            else
                picPlayer.Image = Image.FromFile("no-image.jpg");

        }

       
    }
}

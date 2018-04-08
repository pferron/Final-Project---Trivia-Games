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
    public partial class SelectUsers : Form
    {
        List<User> allUsersList = new List<User>();
        List<User> selectedUsersList = new List<User>();

        public SelectUsers()
        {
            InitializeComponent();
        }

        public SelectUsers(List<User> userList)
        {
            allUsersList = userList;
            InitializeComponent();
        }

      
        private void SelectUsers_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon("pies.ico");
            BackgroundImage = Image.FromFile("Trivia-Background2.jpg");

            lblPlayer.Font = new Font(lblPlayer.Font.Name, 8, FontStyle.Bold);
            lblPlayer.BackColor = Color.Transparent;
            lblPlayer.ForeColor = Color.Red;

            lblNbQuestions.Font = new Font(lblPlayer.Font.Name, 8, FontStyle.Bold);
            lblNbQuestions.BackColor = Color.Transparent;
            lblNbQuestions.ForeColor = Color.Red;

            lblAllUsers.Font = new Font(lblAllUsers.Font.Name, 8, FontStyle.Bold);
            lblAllUsers.BackColor = Color.Transparent;
            lblAllUsers.ForeColor = Color.Red;

            lblSelectedUsers.Font = new Font(lblSelectedUsers.Font.Name, 8, FontStyle.Bold);
            lblSelectedUsers.BackColor = Color.Transparent;
            lblSelectedUsers.ForeColor = Color.Red;

            foreach (User u in allUsersList)
                listAllUsers.Items.Add(u.UserFirstName + " " + u.UserLastName);
        }

        private void btnSelectUser_Click(object sender, EventArgs e)
        {
            if (listAllUsers.SelectedItems.Count != 0)
            {
                string selectedUser = listAllUsers.SelectedItem.ToString();

                int allUsersindex = listAllUsers.FindString(selectedUser);
                int selectedUsersIndex = listSelectedUsers.FindString(selectedUser);

                if (selectedUsersIndex != -1)
                    MessageBox.Show("This user has already being selected", "Alert Message");
                else
                {
                    listSelectedUsers.Items.Add(selectedUser);
                    selectedUsersList.Add(allUsersList[allUsersindex]);
                }
            }
            else
                MessageBox.Show("Please, select a user in the all users list", "Alert Message");
        }

        private void btnUnselectUser_Click(object sender, EventArgs e)
        {
            if (listSelectedUsers.SelectedItems.Count != 0)
            {
                string unselectedUser = listSelectedUsers.SelectedItem.ToString();
                int unselectedUsersIndex = listSelectedUsers.FindString(unselectedUser);

                listSelectedUsers.Items.Remove(unselectedUser);
                selectedUsersList.RemoveAt(unselectedUsersIndex);
            }
            else
                MessageBox.Show("Please, select a user in the selected users list", "Alert Message");
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (selectedUsersList.Count != 0)
            {
                if (txtNbQuestions.Text != "")
                {
                    try
                    {
                        int nbQuestions = int.Parse(txtNbQuestions.Text);
                        Trivia_Questions frm = new Trivia_Questions(selectedUsersList, selectedUsersList.Count, nbQuestions);
                        frm.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Please, enter a number", "Alert Message");
                    }
                }
                else
                {
                    MessageBox.Show("Please, enter number of questions", "Alert Message");
                }
            }
            else
            {
                MessageBox.Show("Please, include at least one user in the selected users list", "Alert Message");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form1"].Show();
            this.Close();
        }
    }
}

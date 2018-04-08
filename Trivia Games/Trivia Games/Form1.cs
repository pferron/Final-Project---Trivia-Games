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
    public partial class Form1 : Form
    {
        TriviaDataLayer dataHandler = new TriviaDataLayer();
        List<User> usersList = new List<User>();

        Boolean addingNew;

        User currentUser, userSave;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon("pies.ico");
            BackgroundImage = Image.FromFile("Trivia-Background1.jpg");
            Disable_Save_Cancel_Controls();
            usersList = dataHandler.getUsersList();
            userBindingSource.DataSource = usersList;
        }

        public void Disable_Save_Cancel_Controls()
        {
            userIDTextBox.ReadOnly = true;
            userFirstNameTextBox.ReadOnly = true;
            userLastNameTextBox.ReadOnly = true;

            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnAddPic.Enabled = false;

            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnFirst.Enabled = true;
            btnLast.Enabled = true;
            btnPrev.Enabled = true;
            btnNext.Enabled = true;
            btnStart.Enabled = true;
        }

        public void Enable_Save_Cancel_Controls()
        {
            userFirstNameTextBox.ReadOnly = false;
            userLastNameTextBox.ReadOnly = false;

            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnAddPic.Enabled = true;

            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnFirst.Enabled = false;
            btnLast.Enabled = false;
            btnPrev.Enabled = false;
            btnNext.Enabled = false;
            btnStart.Enabled = false;

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            userBindingSource.MoveFirst();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            userBindingSource.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            userBindingSource.MoveNext();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            userBindingSource.MoveLast();
        }

        private void userBindingSource_CurrentChanged_1(object sender, EventArgs e)
        {
            currentUser = (User) userBindingSource.Current;

            if (currentUser != null)
            {
                if (currentUser.PicUser != null && currentUser.PicUser != "")
                    picUserPictureBox.Image = Image.FromFile(currentUser.PicUser.ToString());
                else
                    picUserPictureBox.Image = Image.FromFile("no-image.jpg");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Enable_Save_Cancel_Controls();
            User blankUser = new User();
            usersList.Add(blankUser);
            userBindingSource.MoveLast();

            picUserPictureBox.Image = Image.FromFile("no-image.jpg");

            addingNew = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (addingNew)
            {
                currentUser.UserFirstName = userFirstNameTextBox.Text;
                currentUser.UserLastName = userLastNameTextBox.Text;
                currentUser.UserID = userIDTextBox.Text;

                string[] splitstrings  = openFileDialog1.FileName.Split('\\');
                string picname = splitstrings[splitstrings.Count() - 1];
                currentUser.PicUser = picname;

                userBindingSource.MovePrevious();
                userBindingSource.MoveNext();

                if (currentUser.PicUser == null)
                    currentUser.PicUser = "";

                dataHandler.AddNewUser(currentUser);

                userIDTextBox.Text = dataHandler.getNewRecordID();
                

                addingNew = false;
            }
            else
            {
                currentUser.UserFirstName = userFirstNameTextBox.Text;
                currentUser.UserLastName = userLastNameTextBox.Text;
                currentUser.UserID = userIDTextBox.Text;

                string[] splitstrings = openFileDialog1.FileName.Split('\\');
                string picname = splitstrings[splitstrings.Count() - 1];
                currentUser.PicUser = picname;

                userBindingSource.MovePrevious();
                userBindingSource.MoveNext();

                if (currentUser.PicUser == null)
                    currentUser.PicUser = "";

                dataHandler.editUserRecord(currentUser);
            }

            userBindingSource.EndEdit();
            Disable_Save_Cancel_Controls();
            addingNew = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Enable_Save_Cancel_Controls();
            userSave = new User(userIDTextBox.Text, userFirstNameTextBox.Text, userLastNameTextBox.Text); 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (addingNew)
            {
                usersList.RemoveAt(usersList.Count - 1);
                userBindingSource.MovePrevious();

            }
            else
            {
                userIDTextBox.Text = userSave.UserID;
                userFirstNameTextBox.Text = userSave.UserFirstName;
                userLastNameTextBox.Text = userSave.UserLastName;
            }

            Disable_Save_Cancel_Controls();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure?",
                                              "Confirm Delete",
                                              MessageBoxButtons.YesNoCancel);

            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                dataHandler.deleteUser(currentUser);
                userBindingSource.RemoveCurrent();
            }
        }

        private void btnAddPic_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != null && openFileDialog1.FileName != "")
                picUserPictureBox.Image = Image.FromFile(openFileDialog1.FileName);

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            SelectUsers frm = new SelectUsers(usersList);
            frm.Show();
            this.Hide();
        }
    }
}

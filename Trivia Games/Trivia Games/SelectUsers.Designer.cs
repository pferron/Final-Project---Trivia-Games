namespace Trivia_Games
{
    partial class SelectUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelectUser = new System.Windows.Forms.Button();
            this.btnUnselectUser = new System.Windows.Forms.Button();
            this.lblAllUsers = new System.Windows.Forms.Label();
            this.lblSelectedUsers = new System.Windows.Forms.Label();
            this.listAllUsers = new System.Windows.Forms.ListBox();
            this.listSelectedUsers = new System.Windows.Forms.ListBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblNbQuestions = new System.Windows.Forms.Label();
            this.txtNbQuestions = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSelectUser
            // 
            this.btnSelectUser.Location = new System.Drawing.Point(251, 139);
            this.btnSelectUser.Name = "btnSelectUser";
            this.btnSelectUser.Size = new System.Drawing.Size(49, 23);
            this.btnSelectUser.TabIndex = 2;
            this.btnSelectUser.Text = ">>";
            this.btnSelectUser.UseVisualStyleBackColor = true;
            this.btnSelectUser.Click += new System.EventHandler(this.btnSelectUser_Click);
            // 
            // btnUnselectUser
            // 
            this.btnUnselectUser.Location = new System.Drawing.Point(251, 181);
            this.btnUnselectUser.Name = "btnUnselectUser";
            this.btnUnselectUser.Size = new System.Drawing.Size(49, 23);
            this.btnUnselectUser.TabIndex = 3;
            this.btnUnselectUser.Text = "<<";
            this.btnUnselectUser.UseVisualStyleBackColor = true;
            this.btnUnselectUser.Click += new System.EventHandler(this.btnUnselectUser_Click);
            // 
            // lblAllUsers
            // 
            this.lblAllUsers.AutoSize = true;
            this.lblAllUsers.Location = new System.Drawing.Point(56, 50);
            this.lblAllUsers.Name = "lblAllUsers";
            this.lblAllUsers.Size = new System.Drawing.Size(54, 13);
            this.lblAllUsers.TabIndex = 4;
            this.lblAllUsers.Text = "All Users :";
            // 
            // lblSelectedUsers
            // 
            this.lblSelectedUsers.Location = new System.Drawing.Point(338, 84);
            this.lblSelectedUsers.Name = "lblSelectedUsers";
            this.lblSelectedUsers.Size = new System.Drawing.Size(104, 17);
            this.lblSelectedUsers.TabIndex = 5;
            this.lblSelectedUsers.Text = "Selected Users :";
            // 
            // listAllUsers
            // 
            this.listAllUsers.FormattingEnabled = true;
            this.listAllUsers.Location = new System.Drawing.Point(59, 66);
            this.listAllUsers.Name = "listAllUsers";
            this.listAllUsers.Size = new System.Drawing.Size(148, 186);
            this.listAllUsers.TabIndex = 6;
            // 
            // listSelectedUsers
            // 
            this.listSelectedUsers.FormattingEnabled = true;
            this.listSelectedUsers.Location = new System.Drawing.Point(341, 104);
            this.listSelectedUsers.Name = "listSelectedUsers";
            this.listSelectedUsers.Size = new System.Drawing.Size(148, 134);
            this.listSelectedUsers.TabIndex = 7;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(178, 338);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 38);
            this.btnPlay.TabIndex = 8;
            this.btnPlay.Text = "Play !!!";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(305, 338);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 38);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Close";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblPlayer
            // 
            this.lblPlayer.Location = new System.Drawing.Point(216, 30);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(147, 23);
            this.lblPlayer.TabIndex = 10;
            this.lblPlayer.Text = "Please, select Players.";
            // 
            // lblNbQuestions
            // 
            this.lblNbQuestions.Location = new System.Drawing.Point(131, 301);
            this.lblNbQuestions.Name = "lblNbQuestions";
            this.lblNbQuestions.Size = new System.Drawing.Size(211, 23);
            this.lblNbQuestions.TabIndex = 11;
            this.lblNbQuestions.Text = "Enter Numbers of Questions:";
            // 
            // txtNbQuestions
            // 
            this.txtNbQuestions.Location = new System.Drawing.Point(305, 298);
            this.txtNbQuestions.Name = "txtNbQuestions";
            this.txtNbQuestions.Size = new System.Drawing.Size(48, 20);
            this.txtNbQuestions.TabIndex = 12;
            // 
            // SelectUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(569, 397);
            this.Controls.Add(this.txtNbQuestions);
            this.Controls.Add(this.lblNbQuestions);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.listSelectedUsers);
            this.Controls.Add(this.listAllUsers);
            this.Controls.Add(this.lblSelectedUsers);
            this.Controls.Add(this.lblAllUsers);
            this.Controls.Add(this.btnUnselectUser);
            this.Controls.Add(this.btnSelectUser);
            this.Name = "SelectUsers";
            this.Text = "Users Selection";
            this.Load += new System.EventHandler(this.SelectUsers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectUser;
        private System.Windows.Forms.Button btnUnselectUser;
        private System.Windows.Forms.Label lblAllUsers;
        private System.Windows.Forms.Label lblSelectedUsers;
        private System.Windows.Forms.ListBox listAllUsers;
        private System.Windows.Forms.ListBox listSelectedUsers;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblNbQuestions;
        private System.Windows.Forms.TextBox txtNbQuestions;
    }
}
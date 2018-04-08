namespace Trivia_Games
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label userFirstNameLabel;
            System.Windows.Forms.Label userIDLabel;
            System.Windows.Forms.Label userLastNameLabel;
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.picUserPictureBox = new System.Windows.Forms.PictureBox();
            this.userFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.userLastNameTextBox = new System.Windows.Forms.TextBox();
            this.btnAddPic = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            userFirstNameLabel = new System.Windows.Forms.Label();
            userIDLabel = new System.Windows.Forms.Label();
            userLastNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picUserPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // userFirstNameLabel
            // 
            userFirstNameLabel.AutoSize = true;
            userFirstNameLabel.Location = new System.Drawing.Point(65, 215);
            userFirstNameLabel.Name = "userFirstNameLabel";
            userFirstNameLabel.Size = new System.Drawing.Size(60, 13);
            userFirstNameLabel.TabIndex = 19;
            userFirstNameLabel.Text = "First Name:";
            // 
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.Location = new System.Drawing.Point(65, 189);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new System.Drawing.Size(46, 13);
            userIDLabel.TabIndex = 21;
            userIDLabel.Text = "User ID:";
            // 
            // userLastNameLabel
            // 
            userLastNameLabel.AutoSize = true;
            userLastNameLabel.Location = new System.Drawing.Point(65, 241);
            userLastNameLabel.Name = "userLastNameLabel";
            userLastNameLabel.Size = new System.Drawing.Size(61, 13);
            userLastNameLabel.TabIndex = 23;
            userLastNameLabel.Text = "Last Name:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(328, 173);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(66, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(412, 173);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(66, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(79, 278);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(40, 23);
            this.btnFirst.TabIndex = 8;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(125, 278);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(40, 23);
            this.btnPrev.TabIndex = 9;
            this.btnPrev.Text = "<<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(171, 278);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(40, 23);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(217, 278);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(40, 23);
            this.btnLast.TabIndex = 11;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(328, 206);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(412, 206);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(66, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(370, 235);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(66, 23);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(352, 270);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(101, 35);
            this.btnStart.TabIndex = 17;
            this.btnStart.Text = "Start Trivia";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // picUserPictureBox
            // 
            this.picUserPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "PicUser", true));
            this.picUserPictureBox.Location = new System.Drawing.Point(68, 28);
            this.picUserPictureBox.Name = "picUserPictureBox";
            this.picUserPictureBox.Size = new System.Drawing.Size(126, 124);
            this.picUserPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUserPictureBox.TabIndex = 18;
            this.picUserPictureBox.TabStop = false;
            // 
            // userFirstNameTextBox
            // 
            this.userFirstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "UserFirstName", true));
            this.userFirstNameTextBox.Location = new System.Drawing.Point(157, 212);
            this.userFirstNameTextBox.Name = "userFirstNameTextBox";
            this.userFirstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.userFirstNameTextBox.TabIndex = 20;
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "UserID", true));
            this.userIDTextBox.Location = new System.Drawing.Point(157, 186);
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.userIDTextBox.TabIndex = 22;
            // 
            // userLastNameTextBox
            // 
            this.userLastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "UserLastName", true));
            this.userLastNameTextBox.Location = new System.Drawing.Point(157, 238);
            this.userLastNameTextBox.Name = "userLastNameTextBox";
            this.userLastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.userLastNameTextBox.TabIndex = 24;
            // 
            // btnAddPic
            // 
            this.btnAddPic.Location = new System.Drawing.Point(361, 56);
            this.btnAddPic.Name = "btnAddPic";
            this.btnAddPic.Size = new System.Drawing.Size(92, 52);
            this.btnAddPic.TabIndex = 25;
            this.btnAddPic.Text = "Add or Update Picture";
            this.btnAddPic.UseVisualStyleBackColor = true;
            this.btnAddPic.Click += new System.EventHandler(this.btnAddPic_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Trivia_Games.User);
            this.userBindingSource.CurrentChanged += new System.EventHandler(this.userBindingSource_CurrentChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(544, 350);
            this.Controls.Add(this.btnAddPic);
            this.Controls.Add(this.picUserPictureBox);
            this.Controls.Add(userFirstNameLabel);
            this.Controls.Add(this.userFirstNameTextBox);
            this.Controls.Add(userIDLabel);
            this.Controls.Add(this.userIDTextBox);
            this.Controls.Add(userLastNameLabel);
            this.Controls.Add(this.userLastNameTextBox);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Name = "Form1";
            this.Text = "Trivia Games - List of Users";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picUserPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox picUserPictureBox;
        private System.Windows.Forms.TextBox userFirstNameTextBox;
        private System.Windows.Forms.TextBox userIDTextBox;
        private System.Windows.Forms.TextBox userLastNameTextBox;
        private System.Windows.Forms.Button btnAddPic;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}


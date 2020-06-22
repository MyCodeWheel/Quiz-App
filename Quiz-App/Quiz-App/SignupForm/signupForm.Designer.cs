namespace Quiz_App.SignupForm
{
    partial class signupForm
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
            this.UserNameerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.TopHeaderPanel = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.QuizLogoLabel = new System.Windows.Forms.Label();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.SignupButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BackBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.namePanelLine = new System.Windows.Forms.Panel();
            this.NamePicturBox = new System.Windows.Forms.PictureBox();
            this.HeaderPanelLine = new System.Windows.Forms.Panel();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.PasswordPanelLine = new System.Windows.Forms.Panel();
            this.passwordLogo = new System.Windows.Forms.PictureBox();
            this.usernamePanelLine = new System.Windows.Forms.Panel();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.userLogo = new System.Windows.Forms.PictureBox();
            this.SignupLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UserNameerrorProvider)).BeginInit();
            this.TopHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NamePicturBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // UserNameerrorProvider
            // 
            this.UserNameerrorProvider.ContainerControl = this;
            // 
            // TopHeaderPanel
            // 
            this.TopHeaderPanel.Controls.Add(this.minimizeButton);
            this.TopHeaderPanel.Controls.Add(this.exitButton);
            this.TopHeaderPanel.Controls.Add(this.QuizLogoLabel);
            this.TopHeaderPanel.Controls.Add(this.LogoPictureBox);
            this.TopHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.TopHeaderPanel.Name = "TopHeaderPanel";
            this.TopHeaderPanel.Size = new System.Drawing.Size(500, 35);
            this.TopHeaderPanel.TabIndex = 15;
            // 
            // minimizeButton
            // 
            this.minimizeButton.Image = global::Quiz_App.Properties.Resources.Minimized;
            this.minimizeButton.Location = new System.Drawing.Point(445, 1);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(23, 28);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeButton.TabIndex = 3;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Image = global::Quiz_App.Properties.Resources.cross;
            this.exitButton.Location = new System.Drawing.Point(474, 1);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(23, 28);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitButton.TabIndex = 2;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // QuizLogoLabel
            // 
            this.QuizLogoLabel.AutoSize = true;
            this.QuizLogoLabel.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuizLogoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(241)))), ((int)(((byte)(237)))));
            this.QuizLogoLabel.Location = new System.Drawing.Point(35, 6);
            this.QuizLogoLabel.Name = "QuizLogoLabel";
            this.QuizLogoLabel.Size = new System.Drawing.Size(112, 27);
            this.QuizLogoLabel.TabIndex = 1;
            this.QuizLogoLabel.Text = "QUIZ-APP";
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = global::Quiz_App.Properties.Resources.quiz_icon;
            this.LogoPictureBox.Location = new System.Drawing.Point(2, 0);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(41, 35);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPictureBox.TabIndex = 0;
            this.LogoPictureBox.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.SignupButton);
            this.mainPanel.Controls.Add(this.BackBtn);
            this.mainPanel.Controls.Add(this.usernameTextbox);
            this.mainPanel.Controls.Add(this.namePanelLine);
            this.mainPanel.Controls.Add(this.NamePicturBox);
            this.mainPanel.Controls.Add(this.HeaderPanelLine);
            this.mainPanel.Controls.Add(this.NameTextBox);
            this.mainPanel.Controls.Add(this.errorMessageLabel);
            this.mainPanel.Controls.Add(this.PasswordPanelLine);
            this.mainPanel.Controls.Add(this.passwordLogo);
            this.mainPanel.Controls.Add(this.usernamePanelLine);
            this.mainPanel.Controls.Add(this.PasswordTextbox);
            this.mainPanel.Controls.Add(this.userLogo);
            this.mainPanel.Controls.Add(this.SignupLabel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 35);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(500, 630);
            this.mainPanel.TabIndex = 16;
            // 
            // SignupButton
            // 
            this.SignupButton.BorderRadius = 14;
            this.SignupButton.BorderThickness = 2;
            this.SignupButton.CheckedState.Parent = this.SignupButton;
            this.SignupButton.CustomBorderColor = System.Drawing.Color.Black;
            this.SignupButton.CustomBorderThickness = new System.Windows.Forms.Padding(3);
            this.SignupButton.CustomImages.Parent = this.SignupButton;
            this.SignupButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(115)))), ((int)(((byte)(63)))));
            this.SignupButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(177)))));
            this.SignupButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupButton.ForeColor = System.Drawing.Color.White;
            this.SignupButton.HoverState.BorderColor = System.Drawing.Color.White;
            this.SignupButton.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.SignupButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(177)))));
            this.SignupButton.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(115)))), ((int)(((byte)(63)))));
            this.SignupButton.HoverState.ForeColor = System.Drawing.Color.White;
            this.SignupButton.HoverState.Parent = this.SignupButton;
            this.SignupButton.Location = new System.Drawing.Point(101, 428);
            this.SignupButton.Name = "SignupButton";
            this.SignupButton.ShadowDecoration.Parent = this.SignupButton;
            this.SignupButton.Size = new System.Drawing.Size(257, 40);
            this.SignupButton.TabIndex = 186;
            this.SignupButton.Text = "Signup";
            this.SignupButton.Click += new System.EventHandler(this.SignupButton_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BorderRadius = 5;
            this.BackBtn.BorderThickness = 2;
            this.BackBtn.CheckedState.Parent = this.BackBtn;
            this.BackBtn.CustomBorderColor = System.Drawing.Color.Black;
            this.BackBtn.CustomBorderThickness = new System.Windows.Forms.Padding(3);
            this.BackBtn.CustomImages.Parent = this.BackBtn;
            this.BackBtn.FillColor = System.Drawing.Color.DarkOliveGreen;
            this.BackBtn.FillColor2 = System.Drawing.Color.MidnightBlue;
            this.BackBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.HoverState.BorderColor = System.Drawing.Color.White;
            this.BackBtn.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.BackBtn.HoverState.FillColor = System.Drawing.Color.MidnightBlue;
            this.BackBtn.HoverState.FillColor2 = System.Drawing.Color.DarkOliveGreen;
            this.BackBtn.HoverState.ForeColor = System.Drawing.Color.MistyRose;
            this.BackBtn.HoverState.Parent = this.BackBtn;
            this.BackBtn.Location = new System.Drawing.Point(9, 11);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.ShadowDecoration.Parent = this.BackBtn;
            this.BackBtn.Size = new System.Drawing.Size(75, 33);
            this.BackBtn.TabIndex = 185;
            this.BackBtn.Text = "BACK";
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.usernameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextbox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(241)))), ((int)(((byte)(237)))));
            this.usernameTextbox.Location = new System.Drawing.Point(103, 245);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(329, 22);
            this.usernameTextbox.TabIndex = 184;
            this.usernameTextbox.Text = "Username";
            this.usernameTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usernameTextbox_KeyDown);
            this.usernameTextbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.usernameTextbox_KeyUp);
            this.usernameTextbox.MouseEnter += new System.EventHandler(this.usernameTextbox_MouseEnter);
            this.usernameTextbox.MouseLeave += new System.EventHandler(this.usernameTextbox_MouseLeave);
            this.usernameTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.usernameTextbox_Validating);
            this.usernameTextbox.Validated += new System.EventHandler(this.usernameTextbox_Validated);
            // 
            // namePanelLine
            // 
            this.namePanelLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.namePanelLine.Location = new System.Drawing.Point(52, 189);
            this.namePanelLine.Name = "namePanelLine";
            this.namePanelLine.Size = new System.Drawing.Size(380, 1);
            this.namePanelLine.TabIndex = 180;
            // 
            // NamePicturBox
            // 
            this.NamePicturBox.Image = global::Quiz_App.Properties.Resources.Username;
            this.NamePicturBox.Location = new System.Drawing.Point(50, 156);
            this.NamePicturBox.Name = "NamePicturBox";
            this.NamePicturBox.Size = new System.Drawing.Size(45, 28);
            this.NamePicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NamePicturBox.TabIndex = 178;
            this.NamePicturBox.TabStop = false;
            // 
            // HeaderPanelLine
            // 
            this.HeaderPanelLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeaderPanelLine.Location = new System.Drawing.Point(0, 6);
            this.HeaderPanelLine.Name = "HeaderPanelLine";
            this.HeaderPanelLine.Size = new System.Drawing.Size(500, 2);
            this.HeaderPanelLine.TabIndex = 182;
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameTextBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(241)))), ((int)(((byte)(237)))));
            this.NameTextBox.Location = new System.Drawing.Point(101, 161);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(329, 22);
            this.NameTextBox.TabIndex = 176;
            this.NameTextBox.Text = "Your Name";
            this.NameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NameTextBox_KeyDown);
            this.NameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NameTextBox_KeyUp);
            this.NameTextBox.MouseEnter += new System.EventHandler(this.NameTextBox_MouseEnter);
            this.NameTextBox.MouseLeave += new System.EventHandler(this.NameTextBox_MouseLeave);
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.AutoSize = true;
            this.errorMessageLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.errorMessageLabel.Location = new System.Drawing.Point(48, 384);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(63, 20);
            this.errorMessageLabel.TabIndex = 183;
            this.errorMessageLabel.Text = "Message";
            // 
            // PasswordPanelLine
            // 
            this.PasswordPanelLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordPanelLine.Location = new System.Drawing.Point(52, 354);
            this.PasswordPanelLine.Name = "PasswordPanelLine";
            this.PasswordPanelLine.Size = new System.Drawing.Size(380, 1);
            this.PasswordPanelLine.TabIndex = 181;
            // 
            // passwordLogo
            // 
            this.passwordLogo.Image = global::Quiz_App.Properties.Resources.password;
            this.passwordLogo.Location = new System.Drawing.Point(52, 321);
            this.passwordLogo.Name = "passwordLogo";
            this.passwordLogo.Size = new System.Drawing.Size(45, 28);
            this.passwordLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passwordLogo.TabIndex = 179;
            this.passwordLogo.TabStop = false;
            // 
            // usernamePanelLine
            // 
            this.usernamePanelLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernamePanelLine.Location = new System.Drawing.Point(52, 271);
            this.usernamePanelLine.Name = "usernamePanelLine";
            this.usernamePanelLine.Size = new System.Drawing.Size(380, 1);
            this.usernamePanelLine.TabIndex = 175;
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PasswordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextbox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(241)))), ((int)(((byte)(237)))));
            this.PasswordTextbox.Location = new System.Drawing.Point(103, 324);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(329, 22);
            this.PasswordTextbox.TabIndex = 177;
            this.PasswordTextbox.Text = "Password";
            this.PasswordTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordTextbox_KeyDown);
            this.PasswordTextbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PasswordTextbox_KeyUp);
            this.PasswordTextbox.MouseEnter += new System.EventHandler(this.PasswordTextbox_MouseEnter);
            this.PasswordTextbox.MouseLeave += new System.EventHandler(this.PasswordTextbox_MouseLeave);
            // 
            // userLogo
            // 
            this.userLogo.Image = global::Quiz_App.Properties.Resources.Username;
            this.userLogo.Location = new System.Drawing.Point(52, 234);
            this.userLogo.Name = "userLogo";
            this.userLogo.Size = new System.Drawing.Size(45, 28);
            this.userLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userLogo.TabIndex = 174;
            this.userLogo.TabStop = false;
            // 
            // SignupLabel
            // 
            this.SignupLabel.AutoSize = true;
            this.SignupLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(241)))), ((int)(((byte)(237)))));
            this.SignupLabel.Location = new System.Drawing.Point(192, 84);
            this.SignupLabel.Name = "SignupLabel";
            this.SignupLabel.Size = new System.Drawing.Size(81, 24);
            this.SignupLabel.TabIndex = 173;
            this.SignupLabel.Text = "Signup";
            // 
            // signupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(500, 665);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.TopHeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "signupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "signupForm";
            ((System.ComponentModel.ISupportInitialize)(this.UserNameerrorProvider)).EndInit();
            this.TopHeaderPanel.ResumeLayout(false);
            this.TopHeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NamePicturBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider UserNameerrorProvider;
        public System.Windows.Forms.Panel TopHeaderPanel;
        private System.Windows.Forms.PictureBox minimizeButton;
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.Label QuizLogoLabel;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Panel mainPanel;
        private Guna.UI2.WinForms.Guna2GradientButton SignupButton;
        private Guna.UI2.WinForms.Guna2GradientButton BackBtn;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.Panel namePanelLine;
        private System.Windows.Forms.PictureBox NamePicturBox;
        private System.Windows.Forms.Panel HeaderPanelLine;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label errorMessageLabel;
        private System.Windows.Forms.Panel PasswordPanelLine;
        private System.Windows.Forms.PictureBox passwordLogo;
        private System.Windows.Forms.Panel usernamePanelLine;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.PictureBox userLogo;
        private System.Windows.Forms.Label SignupLabel;
    }
}
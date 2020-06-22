namespace Quiz_App
{
    partial class LoginForm
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
            this.TopHeaderPanel = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.QuizLogoLabel = new System.Windows.Forms.Label();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.SignupButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.LoginBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.HeaderPanelLine = new System.Windows.Forms.Panel();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.RolePanel = new System.Windows.Forms.Panel();
            this.AdminRadioButton = new System.Windows.Forms.RadioButton();
            this.PlayerRadioButton = new System.Windows.Forms.RadioButton();
            this.RoleSelectLabel = new System.Windows.Forms.Label();
            this.PasswordPanelLine = new System.Windows.Forms.Panel();
            this.passwordLogo = new System.Windows.Forms.PictureBox();
            this.usernamePanelLine = new System.Windows.Forms.Panel();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.userLogo = new System.Windows.Forms.PictureBox();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.orLabel = new System.Windows.Forms.Label();
            this.SignupLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.TopHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.RolePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLogo)).BeginInit();
            this.SuspendLayout();
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
            this.TopHeaderPanel.TabIndex = 14;
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
            this.mainPanel.Controls.Add(this.LoginBtn);
            this.mainPanel.Controls.Add(this.HeaderPanelLine);
            this.mainPanel.Controls.Add(this.errorMessageLabel);
            this.mainPanel.Controls.Add(this.RolePanel);
            this.mainPanel.Controls.Add(this.PasswordPanelLine);
            this.mainPanel.Controls.Add(this.passwordLogo);
            this.mainPanel.Controls.Add(this.usernamePanelLine);
            this.mainPanel.Controls.Add(this.PasswordTextbox);
            this.mainPanel.Controls.Add(this.userLogo);
            this.mainPanel.Controls.Add(this.usernameTextbox);
            this.mainPanel.Controls.Add(this.orLabel);
            this.mainPanel.Controls.Add(this.SignupLabel);
            this.mainPanel.Controls.Add(this.LoginLabel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 35);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(500, 630);
            this.mainPanel.TabIndex = 15;
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
            this.SignupButton.Location = new System.Drawing.Point(113, 483);
            this.SignupButton.Name = "SignupButton";
            this.SignupButton.ShadowDecoration.Parent = this.SignupButton;
            this.SignupButton.Size = new System.Drawing.Size(257, 40);
            this.SignupButton.TabIndex = 26;
            this.SignupButton.Text = "Signup";
            this.SignupButton.Click += new System.EventHandler(this.SignupButton_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BorderRadius = 14;
            this.LoginBtn.BorderThickness = 2;
            this.LoginBtn.CheckedState.Parent = this.LoginBtn;
            this.LoginBtn.CustomBorderColor = System.Drawing.Color.Black;
            this.LoginBtn.CustomBorderThickness = new System.Windows.Forms.Padding(3);
            this.LoginBtn.CustomImages.Parent = this.LoginBtn;
            this.LoginBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(177)))));
            this.LoginBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(115)))), ((int)(((byte)(63)))));
            this.LoginBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.HoverState.BorderColor = System.Drawing.Color.White;
            this.LoginBtn.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.LoginBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(115)))), ((int)(((byte)(63)))));
            this.LoginBtn.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(177)))));
            this.LoginBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.HoverState.Parent = this.LoginBtn;
            this.LoginBtn.Location = new System.Drawing.Point(113, 413);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.ShadowDecoration.Parent = this.LoginBtn;
            this.LoginBtn.Size = new System.Drawing.Size(257, 40);
            this.LoginBtn.TabIndex = 25;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // HeaderPanelLine
            // 
            this.HeaderPanelLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeaderPanelLine.Location = new System.Drawing.Point(3, 9);
            this.HeaderPanelLine.Name = "HeaderPanelLine";
            this.HeaderPanelLine.Size = new System.Drawing.Size(550, 2);
            this.HeaderPanelLine.TabIndex = 22;
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.AutoSize = true;
            this.errorMessageLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.errorMessageLabel.Location = new System.Drawing.Point(48, 377);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(63, 20);
            this.errorMessageLabel.TabIndex = 24;
            this.errorMessageLabel.Text = "Message";
            // 
            // RolePanel
            // 
            this.RolePanel.Controls.Add(this.AdminRadioButton);
            this.RolePanel.Controls.Add(this.PlayerRadioButton);
            this.RolePanel.Controls.Add(this.RoleSelectLabel);
            this.RolePanel.Location = new System.Drawing.Point(52, 313);
            this.RolePanel.Name = "RolePanel";
            this.RolePanel.Size = new System.Drawing.Size(380, 38);
            this.RolePanel.TabIndex = 23;
            // 
            // AdminRadioButton
            // 
            this.AdminRadioButton.AutoSize = true;
            this.AdminRadioButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(241)))), ((int)(((byte)(237)))));
            this.AdminRadioButton.Location = new System.Drawing.Point(250, 9);
            this.AdminRadioButton.Name = "AdminRadioButton";
            this.AdminRadioButton.Size = new System.Drawing.Size(68, 24);
            this.AdminRadioButton.TabIndex = 12;
            this.AdminRadioButton.TabStop = true;
            this.AdminRadioButton.Text = "Admin";
            this.AdminRadioButton.UseVisualStyleBackColor = true;
            this.AdminRadioButton.CheckedChanged += new System.EventHandler(this.AdminRadioButton_CheckedChanged);
            // 
            // PlayerRadioButton
            // 
            this.PlayerRadioButton.AutoSize = true;
            this.PlayerRadioButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(241)))), ((int)(((byte)(237)))));
            this.PlayerRadioButton.Location = new System.Drawing.Point(166, 9);
            this.PlayerRadioButton.Name = "PlayerRadioButton";
            this.PlayerRadioButton.Size = new System.Drawing.Size(66, 24);
            this.PlayerRadioButton.TabIndex = 11;
            this.PlayerRadioButton.TabStop = true;
            this.PlayerRadioButton.Text = "Player";
            this.PlayerRadioButton.UseVisualStyleBackColor = true;
            this.PlayerRadioButton.CheckedChanged += new System.EventHandler(this.AdminRadioButton_CheckedChanged);
            // 
            // RoleSelectLabel
            // 
            this.RoleSelectLabel.AutoSize = true;
            this.RoleSelectLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleSelectLabel.ForeColor = System.Drawing.Color.Red;
            this.RoleSelectLabel.Location = new System.Drawing.Point(-4, 8);
            this.RoleSelectLabel.Name = "RoleSelectLabel";
            this.RoleSelectLabel.Size = new System.Drawing.Size(133, 23);
            this.RoleSelectLabel.TabIndex = 10;
            this.RoleSelectLabel.Text = "Select your role:";
            // 
            // PasswordPanelLine
            // 
            this.PasswordPanelLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordPanelLine.Location = new System.Drawing.Point(52, 270);
            this.PasswordPanelLine.Name = "PasswordPanelLine";
            this.PasswordPanelLine.Size = new System.Drawing.Size(380, 1);
            this.PasswordPanelLine.TabIndex = 21;
            // 
            // passwordLogo
            // 
            this.passwordLogo.Image = global::Quiz_App.Properties.Resources.password;
            this.passwordLogo.Location = new System.Drawing.Point(52, 240);
            this.passwordLogo.Name = "passwordLogo";
            this.passwordLogo.Size = new System.Drawing.Size(45, 28);
            this.passwordLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passwordLogo.TabIndex = 20;
            this.passwordLogo.TabStop = false;
            // 
            // usernamePanelLine
            // 
            this.usernamePanelLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernamePanelLine.Location = new System.Drawing.Point(52, 180);
            this.usernamePanelLine.Name = "usernamePanelLine";
            this.usernamePanelLine.Size = new System.Drawing.Size(380, 1);
            this.usernamePanelLine.TabIndex = 18;
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PasswordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextbox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(241)))), ((int)(((byte)(237)))));
            this.PasswordTextbox.Location = new System.Drawing.Point(103, 240);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(329, 22);
            this.PasswordTextbox.TabIndex = 19;
            this.PasswordTextbox.Text = "Password";
            this.PasswordTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordTextbox_KeyDown);
            this.PasswordTextbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PasswordTextbox_KeyUp);
            this.PasswordTextbox.MouseEnter += new System.EventHandler(this.PasswordTextbox_MouseEnter);
            this.PasswordTextbox.MouseLeave += new System.EventHandler(this.PasswordTextbox_MouseLeave);
            // 
            // userLogo
            // 
            this.userLogo.Image = global::Quiz_App.Properties.Resources.Username;
            this.userLogo.Location = new System.Drawing.Point(52, 146);
            this.userLogo.Name = "userLogo";
            this.userLogo.Size = new System.Drawing.Size(45, 28);
            this.userLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userLogo.TabIndex = 17;
            this.userLogo.TabStop = false;
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.usernameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextbox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(241)))), ((int)(((byte)(237)))));
            this.usernameTextbox.Location = new System.Drawing.Point(103, 150);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(329, 22);
            this.usernameTextbox.TabIndex = 16;
            this.usernameTextbox.Text = "Username";
            this.usernameTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usernameTextbox_KeyDown);
            this.usernameTextbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.usernameTextbox_KeyUp);
            this.usernameTextbox.MouseEnter += new System.EventHandler(this.usernameTextbox_MouseEnter);
            this.usernameTextbox.MouseLeave += new System.EventHandler(this.usernameTextbox_MouseLeave);
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.orLabel.Location = new System.Drawing.Point(219, 66);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(22, 20);
            this.orLabel.TabIndex = 15;
            this.orLabel.Text = "or";
            // 
            // SignupLabel
            // 
            this.SignupLabel.AutoSize = true;
            this.SignupLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(241)))), ((int)(((byte)(237)))));
            this.SignupLabel.Location = new System.Drawing.Point(248, 61);
            this.SignupLabel.Name = "SignupLabel";
            this.SignupLabel.Size = new System.Drawing.Size(76, 22);
            this.SignupLabel.TabIndex = 14;
            this.SignupLabel.Text = "Signup";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(241)))), ((int)(((byte)(237)))));
            this.LoginLabel.Location = new System.Drawing.Point(149, 61);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(63, 22);
            this.LoginLabel.TabIndex = 13;
            this.LoginLabel.Text = "Login";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(500, 665);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.TopHeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.TopHeaderPanel.ResumeLayout(false);
            this.TopHeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.RolePanel.ResumeLayout(false);
            this.RolePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel TopHeaderPanel;
        private System.Windows.Forms.PictureBox minimizeButton;
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.Label QuizLogoLabel;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Panel mainPanel;
        private Guna.UI2.WinForms.Guna2GradientButton SignupButton;
        private Guna.UI2.WinForms.Guna2GradientButton LoginBtn;
        private System.Windows.Forms.Panel HeaderPanelLine;
        private System.Windows.Forms.Label errorMessageLabel;
        private System.Windows.Forms.Panel RolePanel;
        private System.Windows.Forms.RadioButton AdminRadioButton;
        private System.Windows.Forms.RadioButton PlayerRadioButton;
        private System.Windows.Forms.Label RoleSelectLabel;
        private System.Windows.Forms.Panel PasswordPanelLine;
        private System.Windows.Forms.PictureBox passwordLogo;
        private System.Windows.Forms.Panel usernamePanelLine;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.PictureBox userLogo;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.Label orLabel;
        private System.Windows.Forms.Label SignupLabel;
        private System.Windows.Forms.Label LoginLabel;
    }
}
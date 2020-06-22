namespace Quiz_App.AdminForm
{
    partial class mainAdminForm
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
            this.QuizLogoLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.signoutbtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.UpdateQuestion = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ViewquesBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.delquesBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.AddQuesBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.HeaderPanelLine = new System.Windows.Forms.Panel();
            this.SelectOptionLabel = new System.Windows.Forms.Label();
            this.welcomeAdminLabel = new System.Windows.Forms.Label();
            this.TopHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopHeaderPanel
            // 
            this.TopHeaderPanel.Controls.Add(this.minimizeButton);
            this.TopHeaderPanel.Controls.Add(this.QuizLogoLabel);
            this.TopHeaderPanel.Controls.Add(this.exitButton);
            this.TopHeaderPanel.Controls.Add(this.LogoPictureBox);
            this.TopHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.TopHeaderPanel.Name = "TopHeaderPanel";
            this.TopHeaderPanel.Size = new System.Drawing.Size(500, 35);
            this.TopHeaderPanel.TabIndex = 0;
            // 
            // minimizeButton
            // 
            this.minimizeButton.Image = global::Quiz_App.Properties.Resources.Minimized;
            this.minimizeButton.Location = new System.Drawing.Point(436, 1);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(23, 28);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeButton.TabIndex = 7;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // QuizLogoLabel
            // 
            this.QuizLogoLabel.AutoSize = true;
            this.QuizLogoLabel.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuizLogoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(241)))), ((int)(((byte)(237)))));
            this.QuizLogoLabel.Location = new System.Drawing.Point(37, 7);
            this.QuizLogoLabel.Name = "QuizLogoLabel";
            this.QuizLogoLabel.Size = new System.Drawing.Size(112, 27);
            this.QuizLogoLabel.TabIndex = 5;
            this.QuizLogoLabel.Text = "QUIZ-APP";
            // 
            // exitButton
            // 
            this.exitButton.Image = global::Quiz_App.Properties.Resources.cross;
            this.exitButton.Location = new System.Drawing.Point(465, 1);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(23, 28);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitButton.TabIndex = 6;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = global::Quiz_App.Properties.Resources.quiz_icon;
            this.LogoPictureBox.Location = new System.Drawing.Point(4, 3);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(41, 35);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPictureBox.TabIndex = 4;
            this.LogoPictureBox.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.signoutbtn);
            this.mainPanel.Controls.Add(this.UpdateQuestion);
            this.mainPanel.Controls.Add(this.ViewquesBtn);
            this.mainPanel.Controls.Add(this.delquesBtn);
            this.mainPanel.Controls.Add(this.AddQuesBtn);
            this.mainPanel.Controls.Add(this.HeaderPanelLine);
            this.mainPanel.Controls.Add(this.SelectOptionLabel);
            this.mainPanel.Controls.Add(this.welcomeAdminLabel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 35);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(500, 630);
            this.mainPanel.TabIndex = 1;
            // 
            // signoutbtn
            // 
            this.signoutbtn.BorderRadius = 10;
            this.signoutbtn.BorderThickness = 1;
            this.signoutbtn.CheckedState.Parent = this.signoutbtn;
            this.signoutbtn.CustomBorderColor = System.Drawing.Color.Black;
            this.signoutbtn.CustomBorderThickness = new System.Windows.Forms.Padding(3);
            this.signoutbtn.CustomImages.Parent = this.signoutbtn;
            this.signoutbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(177)))));
            this.signoutbtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.signoutbtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signoutbtn.ForeColor = System.Drawing.Color.White;
            this.signoutbtn.HoverState.BorderColor = System.Drawing.Color.White;
            this.signoutbtn.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.signoutbtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.signoutbtn.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(177)))));
            this.signoutbtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.signoutbtn.HoverState.Parent = this.signoutbtn;
            this.signoutbtn.Location = new System.Drawing.Point(164, 502);
            this.signoutbtn.Name = "signoutbtn";
            this.signoutbtn.ShadowDecoration.Parent = this.signoutbtn;
            this.signoutbtn.Size = new System.Drawing.Size(153, 37);
            this.signoutbtn.TabIndex = 48;
            this.signoutbtn.Text = "SIGNOUT";
            this.signoutbtn.Click += new System.EventHandler(this.signoutBtn_Click);
            // 
            // UpdateQuestion
            // 
            this.UpdateQuestion.BorderRadius = 10;
            this.UpdateQuestion.BorderThickness = 1;
            this.UpdateQuestion.CheckedState.Parent = this.UpdateQuestion;
            this.UpdateQuestion.CustomBorderColor = System.Drawing.Color.Black;
            this.UpdateQuestion.CustomBorderThickness = new System.Windows.Forms.Padding(3);
            this.UpdateQuestion.CustomImages.Parent = this.UpdateQuestion;
            this.UpdateQuestion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(2)))), ((int)(((byte)(120)))));
            this.UpdateQuestion.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(10)))));
            this.UpdateQuestion.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateQuestion.ForeColor = System.Drawing.Color.White;
            this.UpdateQuestion.HoverState.BorderColor = System.Drawing.Color.White;
            this.UpdateQuestion.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.UpdateQuestion.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(10)))));
            this.UpdateQuestion.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(2)))), ((int)(((byte)(120)))));
            this.UpdateQuestion.HoverState.ForeColor = System.Drawing.Color.White;
            this.UpdateQuestion.HoverState.Parent = this.UpdateQuestion;
            this.UpdateQuestion.Location = new System.Drawing.Point(79, 423);
            this.UpdateQuestion.Name = "UpdateQuestion";
            this.UpdateQuestion.ShadowDecoration.Parent = this.UpdateQuestion;
            this.UpdateQuestion.Size = new System.Drawing.Size(321, 40);
            this.UpdateQuestion.TabIndex = 47;
            this.UpdateQuestion.Text = "UPDATE QUESTION";
            this.UpdateQuestion.Click += new System.EventHandler(this.UpdateQuestion_Click);
            // 
            // ViewquesBtn
            // 
            this.ViewquesBtn.BorderRadius = 10;
            this.ViewquesBtn.BorderThickness = 1;
            this.ViewquesBtn.CheckedState.Parent = this.ViewquesBtn;
            this.ViewquesBtn.CustomBorderColor = System.Drawing.Color.Black;
            this.ViewquesBtn.CustomBorderThickness = new System.Windows.Forms.Padding(3);
            this.ViewquesBtn.CustomImages.Parent = this.ViewquesBtn;
            this.ViewquesBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(10)))));
            this.ViewquesBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(2)))), ((int)(((byte)(120)))));
            this.ViewquesBtn.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewquesBtn.ForeColor = System.Drawing.Color.White;
            this.ViewquesBtn.HoverState.BorderColor = System.Drawing.Color.White;
            this.ViewquesBtn.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.ViewquesBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(2)))), ((int)(((byte)(120)))));
            this.ViewquesBtn.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(10)))));
            this.ViewquesBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.ViewquesBtn.HoverState.Parent = this.ViewquesBtn;
            this.ViewquesBtn.Location = new System.Drawing.Point(79, 346);
            this.ViewquesBtn.Name = "ViewquesBtn";
            this.ViewquesBtn.ShadowDecoration.Parent = this.ViewquesBtn;
            this.ViewquesBtn.Size = new System.Drawing.Size(321, 40);
            this.ViewquesBtn.TabIndex = 46;
            this.ViewquesBtn.Text = "VIEW LIST OF QUESTION";
            this.ViewquesBtn.Click += new System.EventHandler(this.ViewquesBtn_Click);
            // 
            // delquesBtn
            // 
            this.delquesBtn.BorderRadius = 10;
            this.delquesBtn.BorderThickness = 1;
            this.delquesBtn.CheckedState.Parent = this.delquesBtn;
            this.delquesBtn.CustomBorderColor = System.Drawing.Color.Black;
            this.delquesBtn.CustomBorderThickness = new System.Windows.Forms.Padding(3);
            this.delquesBtn.CustomImages.Parent = this.delquesBtn;
            this.delquesBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(2)))), ((int)(((byte)(120)))));
            this.delquesBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(10)))));
            this.delquesBtn.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delquesBtn.ForeColor = System.Drawing.Color.White;
            this.delquesBtn.HoverState.BorderColor = System.Drawing.Color.White;
            this.delquesBtn.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.delquesBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(10)))));
            this.delquesBtn.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(2)))), ((int)(((byte)(120)))));
            this.delquesBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.delquesBtn.HoverState.Parent = this.delquesBtn;
            this.delquesBtn.Location = new System.Drawing.Point(79, 269);
            this.delquesBtn.Name = "delquesBtn";
            this.delquesBtn.ShadowDecoration.Parent = this.delquesBtn;
            this.delquesBtn.Size = new System.Drawing.Size(321, 40);
            this.delquesBtn.TabIndex = 45;
            this.delquesBtn.Text = "DELETE QUESTION";
            this.delquesBtn.Click += new System.EventHandler(this.delquesBtn_Click);
            // 
            // AddQuesBtn
            // 
            this.AddQuesBtn.BorderRadius = 10;
            this.AddQuesBtn.BorderThickness = 1;
            this.AddQuesBtn.CheckedState.Parent = this.AddQuesBtn;
            this.AddQuesBtn.CustomBorderColor = System.Drawing.Color.Black;
            this.AddQuesBtn.CustomBorderThickness = new System.Windows.Forms.Padding(3);
            this.AddQuesBtn.CustomImages.Parent = this.AddQuesBtn;
            this.AddQuesBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(10)))));
            this.AddQuesBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(2)))), ((int)(((byte)(120)))));
            this.AddQuesBtn.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddQuesBtn.ForeColor = System.Drawing.Color.White;
            this.AddQuesBtn.HoverState.BorderColor = System.Drawing.Color.White;
            this.AddQuesBtn.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.AddQuesBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(2)))), ((int)(((byte)(120)))));
            this.AddQuesBtn.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(10)))));
            this.AddQuesBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.AddQuesBtn.HoverState.Parent = this.AddQuesBtn;
            this.AddQuesBtn.Location = new System.Drawing.Point(79, 192);
            this.AddQuesBtn.Name = "AddQuesBtn";
            this.AddQuesBtn.ShadowDecoration.Parent = this.AddQuesBtn;
            this.AddQuesBtn.Size = new System.Drawing.Size(321, 40);
            this.AddQuesBtn.TabIndex = 44;
            this.AddQuesBtn.Text = "ADD NEW QUESTION";
            this.AddQuesBtn.Click += new System.EventHandler(this.AddQuesBtn_Click);
            // 
            // HeaderPanelLine
            // 
            this.HeaderPanelLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeaderPanelLine.Location = new System.Drawing.Point(4, 9);
            this.HeaderPanelLine.Name = "HeaderPanelLine";
            this.HeaderPanelLine.Size = new System.Drawing.Size(550, 2);
            this.HeaderPanelLine.TabIndex = 43;
            // 
            // SelectOptionLabel
            // 
            this.SelectOptionLabel.AutoSize = true;
            this.SelectOptionLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectOptionLabel.ForeColor = System.Drawing.Color.Red;
            this.SelectOptionLabel.Location = new System.Drawing.Point(91, 123);
            this.SelectOptionLabel.Name = "SelectOptionLabel";
            this.SelectOptionLabel.Size = new System.Drawing.Size(297, 32);
            this.SelectOptionLabel.TabIndex = 42;
            this.SelectOptionLabel.Text = "Select your operation";
            // 
            // welcomeAdminLabel
            // 
            this.welcomeAdminLabel.AutoSize = true;
            this.welcomeAdminLabel.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeAdminLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(241)))), ((int)(((byte)(237)))));
            this.welcomeAdminLabel.Location = new System.Drawing.Point(63, 61);
            this.welcomeAdminLabel.Name = "welcomeAdminLabel";
            this.welcomeAdminLabel.Size = new System.Drawing.Size(354, 34);
            this.welcomeAdminLabel.TabIndex = 41;
            this.welcomeAdminLabel.Text = "Welcome to Admin Form";
            // 
            // mainAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(500, 665);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.TopHeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainAdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainAdminForm";
            this.TopHeaderPanel.ResumeLayout(false);
            this.TopHeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopHeaderPanel;
        private System.Windows.Forms.PictureBox minimizeButton;
        private System.Windows.Forms.Label QuizLogoLabel;
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private Guna.UI2.WinForms.Guna2GradientButton signoutbtn;
        private Guna.UI2.WinForms.Guna2GradientButton UpdateQuestion;
        private Guna.UI2.WinForms.Guna2GradientButton ViewquesBtn;
        private Guna.UI2.WinForms.Guna2GradientButton delquesBtn;
        private Guna.UI2.WinForms.Guna2GradientButton AddQuesBtn;
        private System.Windows.Forms.Panel HeaderPanelLine;
        private System.Windows.Forms.Label SelectOptionLabel;
        private System.Windows.Forms.Label welcomeAdminLabel;
        private System.Windows.Forms.Panel mainPanel;
    }
}
namespace Quiz_App.GameForm.GameSubForms
{
    partial class GameForm_PlayGame
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TopHeaderPanel = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.QuizLogoLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.QuesLabel = new System.Windows.Forms.RichTextBox();
            this.questionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DopBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BopBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.BackBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.CopBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.AopBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.HeaderPanelLine = new System.Windows.Forms.Panel();
            this.welcomeGameLabel = new System.Windows.Forms.Label();
            this.TopHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.TopHeaderPanel.TabIndex = 3;
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
            this.mainPanel.Controls.Add(this.QuesLabel);
            this.mainPanel.Controls.Add(this.questionLabel);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.DopBtn);
            this.mainPanel.Controls.Add(this.BopBtn);
            this.mainPanel.Controls.Add(this.TimeLabel);
            this.mainPanel.Controls.Add(this.IDLabel);
            this.mainPanel.Controls.Add(this.BackBtn);
            this.mainPanel.Controls.Add(this.CopBtn);
            this.mainPanel.Controls.Add(this.AopBtn);
            this.mainPanel.Controls.Add(this.HeaderPanelLine);
            this.mainPanel.Controls.Add(this.welcomeGameLabel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 35);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(500, 630);
            this.mainPanel.TabIndex = 6;
            // 
            // QuesLabel
            // 
            this.QuesLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.QuesLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuesLabel.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.QuesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(241)))), ((int)(((byte)(237)))));
            this.QuesLabel.Location = new System.Drawing.Point(80, 256);
            this.QuesLabel.Name = "QuesLabel";
            this.QuesLabel.Size = new System.Drawing.Size(390, 71);
            this.QuesLabel.TabIndex = 185;
            this.QuesLabel.Text = "";
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.ForeColor = System.Drawing.Color.Red;
            this.questionLabel.Location = new System.Drawing.Point(214, 158);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(51, 29);
            this.questionLabel.TabIndex = 184;
            this.questionLabel.Text = "1/10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(103, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 183;
            this.label1.Text = "Question:";
            // 
            // DopBtn
            // 
            this.DopBtn.BorderRadius = 10;
            this.DopBtn.BorderThickness = 1;
            this.DopBtn.CheckedState.Parent = this.DopBtn;
            this.DopBtn.CustomBorderColor = System.Drawing.Color.Black;
            this.DopBtn.CustomBorderThickness = new System.Windows.Forms.Padding(3);
            this.DopBtn.CustomImages.Parent = this.DopBtn;
            this.DopBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(2)))), ((int)(((byte)(120)))));
            this.DopBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(10)))));
            this.DopBtn.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DopBtn.ForeColor = System.Drawing.Color.White;
            this.DopBtn.HoverState.BorderColor = System.Drawing.Color.White;
            this.DopBtn.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.DopBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(10)))));
            this.DopBtn.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(2)))), ((int)(((byte)(120)))));
            this.DopBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.DopBtn.HoverState.Parent = this.DopBtn;
            this.DopBtn.Location = new System.Drawing.Point(293, 457);
            this.DopBtn.Name = "DopBtn";
            this.DopBtn.ShadowDecoration.Parent = this.DopBtn;
            this.DopBtn.Size = new System.Drawing.Size(132, 40);
            this.DopBtn.TabIndex = 182;
            this.DopBtn.Text = "D";
            this.DopBtn.Click += new System.EventHandler(this.BtnClcik);
            // 
            // BopBtn
            // 
            this.BopBtn.BorderRadius = 10;
            this.BopBtn.BorderThickness = 1;
            this.BopBtn.CheckedState.Parent = this.BopBtn;
            this.BopBtn.CustomBorderColor = System.Drawing.Color.Black;
            this.BopBtn.CustomBorderThickness = new System.Windows.Forms.Padding(3);
            this.BopBtn.CustomImages.Parent = this.BopBtn;
            this.BopBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(10)))));
            this.BopBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(2)))), ((int)(((byte)(120)))));
            this.BopBtn.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BopBtn.ForeColor = System.Drawing.Color.White;
            this.BopBtn.HoverState.BorderColor = System.Drawing.Color.White;
            this.BopBtn.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.BopBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(2)))), ((int)(((byte)(120)))));
            this.BopBtn.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(10)))));
            this.BopBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.BopBtn.HoverState.Parent = this.BopBtn;
            this.BopBtn.Location = new System.Drawing.Point(293, 355);
            this.BopBtn.Name = "BopBtn";
            this.BopBtn.ShadowDecoration.Parent = this.BopBtn;
            this.BopBtn.Size = new System.Drawing.Size(132, 40);
            this.BopBtn.TabIndex = 181;
            this.BopBtn.Text = "B";
            this.BopBtn.Click += new System.EventHandler(this.BtnClcik);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.Color.Red;
            this.TimeLabel.Location = new System.Drawing.Point(309, 158);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(59, 29);
            this.TimeLabel.TabIndex = 180;
            this.TimeLabel.Text = "TIME";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.ForeColor = System.Drawing.Color.Red;
            this.IDLabel.Location = new System.Drawing.Point(29, 256);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(32, 29);
            this.IDLabel.TabIndex = 174;
            this.IDLabel.Text = "ID";
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
            this.BackBtn.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.HoverState.BorderColor = System.Drawing.Color.White;
            this.BackBtn.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.BackBtn.HoverState.FillColor = System.Drawing.Color.MidnightBlue;
            this.BackBtn.HoverState.FillColor2 = System.Drawing.Color.DarkOliveGreen;
            this.BackBtn.HoverState.ForeColor = System.Drawing.Color.MistyRose;
            this.BackBtn.HoverState.Parent = this.BackBtn;
            this.BackBtn.Location = new System.Drawing.Point(6, 19);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.ShadowDecoration.Parent = this.BackBtn;
            this.BackBtn.Size = new System.Drawing.Size(68, 28);
            this.BackBtn.TabIndex = 173;
            this.BackBtn.Text = "BACK";
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // CopBtn
            // 
            this.CopBtn.BorderRadius = 10;
            this.CopBtn.BorderThickness = 1;
            this.CopBtn.CheckedState.Parent = this.CopBtn;
            this.CopBtn.CustomBorderColor = System.Drawing.Color.Black;
            this.CopBtn.CustomBorderThickness = new System.Windows.Forms.Padding(3);
            this.CopBtn.CustomImages.Parent = this.CopBtn;
            this.CopBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(2)))), ((int)(((byte)(120)))));
            this.CopBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(10)))));
            this.CopBtn.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopBtn.ForeColor = System.Drawing.Color.White;
            this.CopBtn.HoverState.BorderColor = System.Drawing.Color.White;
            this.CopBtn.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.CopBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(10)))));
            this.CopBtn.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(2)))), ((int)(((byte)(120)))));
            this.CopBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.CopBtn.HoverState.Parent = this.CopBtn;
            this.CopBtn.Location = new System.Drawing.Point(41, 457);
            this.CopBtn.Name = "CopBtn";
            this.CopBtn.ShadowDecoration.Parent = this.CopBtn;
            this.CopBtn.Size = new System.Drawing.Size(132, 40);
            this.CopBtn.TabIndex = 45;
            this.CopBtn.Text = "C";
            this.CopBtn.Click += new System.EventHandler(this.BtnClcik);
            // 
            // AopBtn
            // 
            this.AopBtn.BorderRadius = 10;
            this.AopBtn.BorderThickness = 1;
            this.AopBtn.CheckedState.Parent = this.AopBtn;
            this.AopBtn.CustomBorderColor = System.Drawing.Color.Black;
            this.AopBtn.CustomBorderThickness = new System.Windows.Forms.Padding(3);
            this.AopBtn.CustomImages.Parent = this.AopBtn;
            this.AopBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(10)))));
            this.AopBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(2)))), ((int)(((byte)(120)))));
            this.AopBtn.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AopBtn.ForeColor = System.Drawing.Color.White;
            this.AopBtn.HoverState.BorderColor = System.Drawing.Color.White;
            this.AopBtn.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.AopBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(2)))), ((int)(((byte)(120)))));
            this.AopBtn.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(10)))));
            this.AopBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.AopBtn.HoverState.Parent = this.AopBtn;
            this.AopBtn.Location = new System.Drawing.Point(41, 355);
            this.AopBtn.Name = "AopBtn";
            this.AopBtn.ShadowDecoration.Parent = this.AopBtn;
            this.AopBtn.Size = new System.Drawing.Size(132, 40);
            this.AopBtn.TabIndex = 44;
            this.AopBtn.Text = "A";
            this.AopBtn.Click += new System.EventHandler(this.BtnClcik);
            // 
            // HeaderPanelLine
            // 
            this.HeaderPanelLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeaderPanelLine.Location = new System.Drawing.Point(4, 9);
            this.HeaderPanelLine.Name = "HeaderPanelLine";
            this.HeaderPanelLine.Size = new System.Drawing.Size(500, 2);
            this.HeaderPanelLine.TabIndex = 43;
            // 
            // welcomeGameLabel
            // 
            this.welcomeGameLabel.AutoSize = true;
            this.welcomeGameLabel.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeGameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(241)))), ((int)(((byte)(237)))));
            this.welcomeGameLabel.Location = new System.Drawing.Point(74, 57);
            this.welcomeGameLabel.Name = "welcomeGameLabel";
            this.welcomeGameLabel.Size = new System.Drawing.Size(326, 34);
            this.welcomeGameLabel.TabIndex = 41;
            this.welcomeGameLabel.Text = "Welcome to the Game ";
            // 
            // GameForm_PlayGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(500, 665);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.TopHeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameForm_PlayGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameForm_PlayGame";
            this.Load += new System.EventHandler(this.GameForm_PlayGame_Load);
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel TopHeaderPanel;
        private System.Windows.Forms.PictureBox minimizeButton;
        private System.Windows.Forms.Label QuizLogoLabel;
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.RichTextBox QuesLabel;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton DopBtn;
        private Guna.UI2.WinForms.Guna2GradientButton BopBtn;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label IDLabel;
        private Guna.UI2.WinForms.Guna2GradientButton BackBtn;
        private Guna.UI2.WinForms.Guna2GradientButton CopBtn;
        private Guna.UI2.WinForms.Guna2GradientButton AopBtn;
        private System.Windows.Forms.Panel HeaderPanelLine;
        private System.Windows.Forms.Label welcomeGameLabel;
    }
}
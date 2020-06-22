namespace Quiz_App.GameForm.GameSubForms
{
    partial class GameForm_OptionGamForm
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
            this.catatgoryLabel = new System.Windows.Forms.Label();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.catagoryCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.saveBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BackBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.HeaderPanelLine = new System.Windows.Forms.Panel();
            this.welcomeGameLabel = new System.Windows.Forms.Label();
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
            this.mainPanel.Controls.Add(this.catatgoryLabel);
            this.mainPanel.Controls.Add(this.errorMessageLabel);
            this.mainPanel.Controls.Add(this.catagoryCombo);
            this.mainPanel.Controls.Add(this.saveBtn);
            this.mainPanel.Controls.Add(this.BackBtn);
            this.mainPanel.Controls.Add(this.HeaderPanelLine);
            this.mainPanel.Controls.Add(this.welcomeGameLabel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 35);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(500, 630);
            this.mainPanel.TabIndex = 7;
            // 
            // catatgoryLabel
            // 
            this.catatgoryLabel.AutoSize = true;
            this.catatgoryLabel.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catatgoryLabel.ForeColor = System.Drawing.Color.Red;
            this.catatgoryLabel.Location = new System.Drawing.Point(113, 155);
            this.catatgoryLabel.Name = "catatgoryLabel";
            this.catatgoryLabel.Size = new System.Drawing.Size(236, 31);
            this.catatgoryLabel.TabIndex = 185;
            this.catatgoryLabel.Text = "SELECT CATAGORY";
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.AutoSize = true;
            this.errorMessageLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.errorMessageLabel.Location = new System.Drawing.Point(37, 299);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(63, 20);
            this.errorMessageLabel.TabIndex = 184;
            this.errorMessageLabel.Text = "Message";
            // 
            // catagoryCombo
            // 
            this.catagoryCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.catagoryCombo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(241)))), ((int)(((byte)(237)))));
            this.catagoryCombo.BorderRadius = 6;
            this.catagoryCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.catagoryCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.catagoryCombo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.catagoryCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.catagoryCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.catagoryCombo.FocusedState.Parent = this.catagoryCombo;
            this.catagoryCombo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catagoryCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(241)))), ((int)(((byte)(237)))));
            this.catagoryCombo.FormattingEnabled = true;
            this.catagoryCombo.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.catagoryCombo.HoverState.Parent = this.catagoryCombo;
            this.catagoryCombo.ItemHeight = 30;
            this.catagoryCombo.Items.AddRange(new object[] {
            "Select Catagory",
            "Cricket",
            "Football"});
            this.catagoryCombo.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.catagoryCombo.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(241)))), ((int)(((byte)(237)))));
            this.catagoryCombo.ItemsAppearance.Parent = this.catagoryCombo;
            this.catagoryCombo.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(44)))), ((int)(((byte)(209)))));
            this.catagoryCombo.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.catagoryCombo.Location = new System.Drawing.Point(41, 233);
            this.catagoryCombo.Name = "catagoryCombo";
            this.catagoryCombo.ShadowDecoration.Parent = this.catagoryCombo;
            this.catagoryCombo.Size = new System.Drawing.Size(380, 36);
            this.catagoryCombo.TabIndex = 183;
            // 
            // saveBtn
            // 
            this.saveBtn.BorderRadius = 10;
            this.saveBtn.BorderThickness = 1;
            this.saveBtn.CheckedState.Parent = this.saveBtn;
            this.saveBtn.CustomBorderColor = System.Drawing.Color.Black;
            this.saveBtn.CustomBorderThickness = new System.Windows.Forms.Padding(3);
            this.saveBtn.CustomImages.Parent = this.saveBtn;
            this.saveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(2)))), ((int)(((byte)(120)))));
            this.saveBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(10)))));
            this.saveBtn.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.HoverState.BorderColor = System.Drawing.Color.White;
            this.saveBtn.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.saveBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(82)))), ((int)(((byte)(10)))));
            this.saveBtn.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(2)))), ((int)(((byte)(120)))));
            this.saveBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.saveBtn.HoverState.Parent = this.saveBtn;
            this.saveBtn.Location = new System.Drawing.Point(166, 345);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.ShadowDecoration.Parent = this.saveBtn;
            this.saveBtn.Size = new System.Drawing.Size(132, 40);
            this.saveBtn.TabIndex = 182;
            this.saveBtn.Text = "SAVE";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
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
            this.welcomeGameLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeGameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(241)))), ((int)(((byte)(237)))));
            this.welcomeGameLabel.Location = new System.Drawing.Point(36, 75);
            this.welcomeGameLabel.Name = "welcomeGameLabel";
            this.welcomeGameLabel.Size = new System.Drawing.Size(416, 29);
            this.welcomeGameLabel.TabIndex = 41;
            this.welcomeGameLabel.Text = "Welcome to the Game Option Form";
            // 
            // GameForm_OptionGamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(500, 665);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.TopHeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameForm_OptionGamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameForm_OptionGamForm";
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
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label catatgoryLabel;
        private System.Windows.Forms.Label errorMessageLabel;
        private Guna.UI2.WinForms.Guna2ComboBox catagoryCombo;
        private Guna.UI2.WinForms.Guna2GradientButton saveBtn;
        private Guna.UI2.WinForms.Guna2GradientButton BackBtn;
        private System.Windows.Forms.Panel HeaderPanelLine;
        private System.Windows.Forms.Label welcomeGameLabel;
    }
}
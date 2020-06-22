namespace Quiz_App.AdminForm.AdminSubForms
{
    partial class AdminForm_ViewQuestion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.QuizLogoLabel = new System.Windows.Forms.Label();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.gridviewGunaUI = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OptionA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OptionB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OptionC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OptionD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Catagory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ListQuestionLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewGunaUI)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.minimizeButton);
            this.panel1.Controls.Add(this.QuizLogoLabel);
            this.panel1.Controls.Add(this.LogoPictureBox);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 35);
            this.panel1.TabIndex = 0;
            // 
            // minimizeButton
            // 
            this.minimizeButton.Image = global::Quiz_App.Properties.Resources.Minimized;
            this.minimizeButton.Location = new System.Drawing.Point(1045, 1);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(23, 28);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeButton.TabIndex = 174;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // QuizLogoLabel
            // 
            this.QuizLogoLabel.AutoSize = true;
            this.QuizLogoLabel.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuizLogoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(241)))), ((int)(((byte)(237)))));
            this.QuizLogoLabel.Location = new System.Drawing.Point(34, 5);
            this.QuizLogoLabel.Name = "QuizLogoLabel";
            this.QuizLogoLabel.Size = new System.Drawing.Size(112, 27);
            this.QuizLogoLabel.TabIndex = 172;
            this.QuizLogoLabel.Text = "QUIZ-APP";
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = global::Quiz_App.Properties.Resources.quiz_icon;
            this.LogoPictureBox.Location = new System.Drawing.Point(1, 1);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(41, 35);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPictureBox.TabIndex = 171;
            this.LogoPictureBox.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.Image = global::Quiz_App.Properties.Resources.cross;
            this.exitButton.Location = new System.Drawing.Point(1074, 1);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(23, 28);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitButton.TabIndex = 173;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.gridviewGunaUI);
            this.mainPanel.Controls.Add(this.BackBtn);
            this.mainPanel.Controls.Add(this.panel2);
            this.mainPanel.Controls.Add(this.ListQuestionLabel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 35);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1100, 665);
            this.mainPanel.TabIndex = 1;
            // 
            // gridviewGunaUI
            // 
            this.gridviewGunaUI.AllowUserToAddRows = false;
            this.gridviewGunaUI.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.gridviewGunaUI.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridviewGunaUI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridviewGunaUI.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridviewGunaUI.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.gridviewGunaUI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridviewGunaUI.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridviewGunaUI.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridviewGunaUI.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridviewGunaUI.ColumnHeadersHeight = 21;
            this.gridviewGunaUI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Question,
            this.OptionA,
            this.OptionB,
            this.OptionC,
            this.OptionD,
            this.Answer,
            this.Catagory});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridviewGunaUI.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridviewGunaUI.EnableHeadersVisualStyles = false;
            this.gridviewGunaUI.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.gridviewGunaUI.Location = new System.Drawing.Point(12, 123);
            this.gridviewGunaUI.Name = "gridviewGunaUI";
            this.gridviewGunaUI.ReadOnly = true;
            this.gridviewGunaUI.RowHeadersVisible = false;
            this.gridviewGunaUI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridviewGunaUI.Size = new System.Drawing.Size(1076, 508);
            this.gridviewGunaUI.TabIndex = 170;
            this.gridviewGunaUI.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Teal;
            this.gridviewGunaUI.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.gridviewGunaUI.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridviewGunaUI.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridviewGunaUI.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridviewGunaUI.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridviewGunaUI.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.gridviewGunaUI.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.gridviewGunaUI.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.gridviewGunaUI.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridviewGunaUI.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridviewGunaUI.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridviewGunaUI.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridviewGunaUI.ThemeStyle.HeaderStyle.Height = 21;
            this.gridviewGunaUI.ThemeStyle.ReadOnly = true;
            this.gridviewGunaUI.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.gridviewGunaUI.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridviewGunaUI.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridviewGunaUI.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridviewGunaUI.ThemeStyle.RowsStyle.Height = 22;
            this.gridviewGunaUI.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            this.gridviewGunaUI.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.FillWeight = 20F;
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 30;
            // 
            // Question
            // 
            this.Question.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Question.FillWeight = 200F;
            this.Question.Frozen = true;
            this.Question.HeaderText = "Question";
            this.Question.Name = "Question";
            this.Question.ReadOnly = true;
            this.Question.Width = 400;
            // 
            // OptionA
            // 
            this.OptionA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.OptionA.FillWeight = 60F;
            this.OptionA.Frozen = true;
            this.OptionA.HeaderText = "OptionA";
            this.OptionA.Name = "OptionA";
            this.OptionA.ReadOnly = true;
            this.OptionA.Width = 115;
            // 
            // OptionB
            // 
            this.OptionB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.OptionB.FillWeight = 60F;
            this.OptionB.Frozen = true;
            this.OptionB.HeaderText = "OptionB";
            this.OptionB.Name = "OptionB";
            this.OptionB.ReadOnly = true;
            this.OptionB.Width = 115;
            // 
            // OptionC
            // 
            this.OptionC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.OptionC.FillWeight = 60F;
            this.OptionC.Frozen = true;
            this.OptionC.HeaderText = "OptionC";
            this.OptionC.Name = "OptionC";
            this.OptionC.ReadOnly = true;
            this.OptionC.Width = 115;
            // 
            // OptionD
            // 
            this.OptionD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.OptionD.FillWeight = 60F;
            this.OptionD.Frozen = true;
            this.OptionD.HeaderText = "OptionD";
            this.OptionD.Name = "OptionD";
            this.OptionD.ReadOnly = true;
            this.OptionD.Width = 115;
            // 
            // Answer
            // 
            this.Answer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Answer.FillWeight = 60F;
            this.Answer.Frozen = true;
            this.Answer.HeaderText = "Answer";
            this.Answer.Name = "Answer";
            this.Answer.ReadOnly = true;
            this.Answer.Width = 115;
            // 
            // Catagory
            // 
            this.Catagory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Catagory.FillWeight = 40F;
            this.Catagory.Frozen = true;
            this.Catagory.HeaderText = "Catagory";
            this.Catagory.Name = "Catagory";
            this.Catagory.ReadOnly = true;
            this.Catagory.Width = 70;
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
            this.BackBtn.Location = new System.Drawing.Point(12, 18);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.ShadowDecoration.Parent = this.BackBtn;
            this.BackBtn.Size = new System.Drawing.Size(68, 28);
            this.BackBtn.TabIndex = 169;
            this.BackBtn.Text = "BACK";
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(3, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1100, 2);
            this.panel2.TabIndex = 168;
            // 
            // ListQuestionLabel
            // 
            this.ListQuestionLabel.AutoSize = true;
            this.ListQuestionLabel.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListQuestionLabel.ForeColor = System.Drawing.Color.Red;
            this.ListQuestionLabel.Location = new System.Drawing.Point(432, 64);
            this.ListQuestionLabel.Name = "ListQuestionLabel";
            this.ListQuestionLabel.Size = new System.Drawing.Size(237, 31);
            this.ListQuestionLabel.TabIndex = 167;
            this.ListQuestionLabel.Text = "LIST OF QUESTIONS";
            // 
            // AdminForm_ViewQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm_ViewQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm_ViewQuestion";
            this.Load += new System.EventHandler(this.AdminForm_ViewQuestion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewGunaUI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel mainPanel;
        private Guna.UI2.WinForms.Guna2GradientButton BackBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ListQuestionLabel;
        private System.Windows.Forms.PictureBox minimizeButton;
        private System.Windows.Forms.Label QuizLogoLabel;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.PictureBox exitButton;
        private Guna.UI2.WinForms.Guna2DataGridView gridviewGunaUI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Question;
        private System.Windows.Forms.DataGridViewTextBoxColumn OptionA;
        private System.Windows.Forms.DataGridViewTextBoxColumn OptionB;
        private System.Windows.Forms.DataGridViewTextBoxColumn OptionC;
        private System.Windows.Forms.DataGridViewTextBoxColumn OptionD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Catagory;
    }
}
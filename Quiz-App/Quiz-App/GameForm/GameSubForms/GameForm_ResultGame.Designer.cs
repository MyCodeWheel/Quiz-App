namespace Quiz_App.GameForm.GameSubForms
{
    partial class GameForm_ResultGame
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TopHeaderPanel = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.QuizLogoLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.gridviewGunaUI = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correctAns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.HeaderPanelLine = new System.Windows.Forms.Panel();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.TopHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewGunaUI)).BeginInit();
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
            this.mainPanel.Controls.Add(this.gridviewGunaUI);
            this.mainPanel.Controls.Add(this.BackBtn);
            this.mainPanel.Controls.Add(this.HeaderPanelLine);
            this.mainPanel.Controls.Add(this.ResultLabel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 35);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(500, 630);
            this.mainPanel.TabIndex = 6;
            // 
            // gridviewGunaUI
            // 
            this.gridviewGunaUI.AllowUserToAddRows = false;
            this.gridviewGunaUI.AllowUserToDeleteRows = false;
            this.gridviewGunaUI.AllowUserToResizeColumns = false;
            this.gridviewGunaUI.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.gridviewGunaUI.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridviewGunaUI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridviewGunaUI.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.gridviewGunaUI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridviewGunaUI.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridviewGunaUI.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridviewGunaUI.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridviewGunaUI.ColumnHeadersHeight = 40;
            this.gridviewGunaUI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Datetime,
            this.totalScore,
            this.correctAns});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(212)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(111)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridviewGunaUI.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridviewGunaUI.EnableHeadersVisualStyles = false;
            this.gridviewGunaUI.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(188)))), ((int)(((byte)(231)))));
            this.gridviewGunaUI.Location = new System.Drawing.Point(27, 144);
            this.gridviewGunaUI.Name = "gridviewGunaUI";
            this.gridviewGunaUI.RowHeadersVisible = false;
            this.gridviewGunaUI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridviewGunaUI.Size = new System.Drawing.Size(442, 457);
            this.gridviewGunaUI.TabIndex = 175;
            this.gridviewGunaUI.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Purple;
            this.gridviewGunaUI.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(191)))), ((int)(((byte)(231)))));
            this.gridviewGunaUI.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridviewGunaUI.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridviewGunaUI.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridviewGunaUI.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridviewGunaUI.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.gridviewGunaUI.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(188)))), ((int)(((byte)(231)))));
            this.gridviewGunaUI.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.gridviewGunaUI.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridviewGunaUI.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridviewGunaUI.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridviewGunaUI.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridviewGunaUI.ThemeStyle.HeaderStyle.Height = 40;
            this.gridviewGunaUI.ThemeStyle.ReadOnly = false;
            this.gridviewGunaUI.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(212)))), ((int)(((byte)(239)))));
            this.gridviewGunaUI.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridviewGunaUI.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridviewGunaUI.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridviewGunaUI.ThemeStyle.RowsStyle.Height = 22;
            this.gridviewGunaUI.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(111)))), ((int)(((byte)(202)))));
            this.gridviewGunaUI.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Datetime
            // 
            this.Datetime.FillWeight = 130F;
            this.Datetime.HeaderText = "Date and TIme";
            this.Datetime.Name = "Datetime";
            this.Datetime.ReadOnly = true;
            // 
            // totalScore
            // 
            this.totalScore.FillWeight = 70F;
            this.totalScore.HeaderText = "Total Score (total 50)";
            this.totalScore.Name = "totalScore";
            this.totalScore.ReadOnly = true;
            // 
            // correctAns
            // 
            this.correctAns.FillWeight = 90F;
            this.correctAns.HeaderText = "Correct Answers (total 10)";
            this.correctAns.Name = "correctAns";
            this.correctAns.ReadOnly = true;
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
            this.BackBtn.Location = new System.Drawing.Point(12, 19);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.ShadowDecoration.Parent = this.BackBtn;
            this.BackBtn.Size = new System.Drawing.Size(68, 28);
            this.BackBtn.TabIndex = 174;
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
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(241)))), ((int)(((byte)(237)))));
            this.ResultLabel.Location = new System.Drawing.Point(21, 71);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(448, 34);
            this.ResultLabel.TabIndex = 41;
            this.ResultLabel.Text = "Result of Your Previous Games";
            // 
            // GameForm_ResultGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(500, 665);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.TopHeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameForm_ResultGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameForm_ResultGame";
            this.Load += new System.EventHandler(this.GameForm_ResultGame_Load);
            this.TopHeaderPanel.ResumeLayout(false);
            this.TopHeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewGunaUI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopHeaderPanel;
        private System.Windows.Forms.PictureBox minimizeButton;
        private System.Windows.Forms.Label QuizLogoLabel;
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Panel mainPanel;
        private Guna.UI2.WinForms.Guna2DataGridView gridviewGunaUI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn correctAns;
        private Guna.UI2.WinForms.Guna2GradientButton BackBtn;
        private System.Windows.Forms.Panel HeaderPanelLine;
        private System.Windows.Forms.Label ResultLabel;
    }
}
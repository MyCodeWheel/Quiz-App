namespace Quiz_App.AdminForm.AdminSubForms
{
    partial class AdminForm_AddQuestion
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
            this.errorQuestion = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorIdTextBox = new System.Windows.Forms.ErrorProvider(this.components);
            this.TopHeaderPanel = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.QuizLogoLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.insetBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.DRadioBtn = new Guna.UI2.WinForms.Guna2RadioButton();
            this.CRadioBtn = new Guna.UI2.WinForms.Guna2RadioButton();
            this.BRadioBtn = new Guna.UI2.WinForms.Guna2RadioButton();
            this.ARadioBtn = new Guna.UI2.WinForms.Guna2RadioButton();
            this.corectOptionLabel = new System.Windows.Forms.Label();
            this.BackBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.catagoryCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.idTextBoxPanelLine = new System.Windows.Forms.Panel();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.OpDpanelLine = new System.Windows.Forms.Panel();
            this.OpBPanelLine = new System.Windows.Forms.Panel();
            this.OpDTextBox = new System.Windows.Forms.TextBox();
            this.OpBTextBox = new System.Windows.Forms.TextBox();
            this.OpCpanelLine = new System.Windows.Forms.Panel();
            this.OpCTextBox = new System.Windows.Forms.TextBox();
            this.OpAPanelLine = new System.Windows.Forms.Panel();
            this.OpATextBox = new System.Windows.Forms.TextBox();
            this.QuestionPanelLine = new System.Windows.Forms.Panel();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.QuestionTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorQuestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIdTextBox)).BeginInit();
            this.TopHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorQuestion
            // 
            this.errorQuestion.ContainerControl = this;
            // 
            // ErrorIdTextBox
            // 
            this.ErrorIdTextBox.ContainerControl = this;
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
            this.TopHeaderPanel.TabIndex = 1;
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
            this.mainPanel.Controls.Add(this.insetBtn);
            this.mainPanel.Controls.Add(this.DRadioBtn);
            this.mainPanel.Controls.Add(this.CRadioBtn);
            this.mainPanel.Controls.Add(this.BRadioBtn);
            this.mainPanel.Controls.Add(this.ARadioBtn);
            this.mainPanel.Controls.Add(this.corectOptionLabel);
            this.mainPanel.Controls.Add(this.BackBtn);
            this.mainPanel.Controls.Add(this.catagoryCombo);
            this.mainPanel.Controls.Add(this.idTextBoxPanelLine);
            this.mainPanel.Controls.Add(this.idTextBox);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.errorMessageLabel);
            this.mainPanel.Controls.Add(this.OpDpanelLine);
            this.mainPanel.Controls.Add(this.OpBPanelLine);
            this.mainPanel.Controls.Add(this.OpDTextBox);
            this.mainPanel.Controls.Add(this.OpBTextBox);
            this.mainPanel.Controls.Add(this.OpCpanelLine);
            this.mainPanel.Controls.Add(this.OpCTextBox);
            this.mainPanel.Controls.Add(this.OpAPanelLine);
            this.mainPanel.Controls.Add(this.OpATextBox);
            this.mainPanel.Controls.Add(this.QuestionPanelLine);
            this.mainPanel.Controls.Add(this.LoginLabel);
            this.mainPanel.Controls.Add(this.QuestionTextbox);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 35);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(500, 630);
            this.mainPanel.TabIndex = 6;
            // 
            // insetBtn
            // 
            this.insetBtn.BorderRadius = 5;
            this.insetBtn.BorderThickness = 2;
            this.insetBtn.CheckedState.Parent = this.insetBtn;
            this.insetBtn.CustomBorderColor = System.Drawing.Color.Black;
            this.insetBtn.CustomBorderThickness = new System.Windows.Forms.Padding(3);
            this.insetBtn.CustomImages.Parent = this.insetBtn;
            this.insetBtn.FillColor = System.Drawing.Color.DarkOliveGreen;
            this.insetBtn.FillColor2 = System.Drawing.Color.MidnightBlue;
            this.insetBtn.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insetBtn.ForeColor = System.Drawing.Color.White;
            this.insetBtn.HoverState.BorderColor = System.Drawing.Color.White;
            this.insetBtn.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.insetBtn.HoverState.FillColor = System.Drawing.Color.MidnightBlue;
            this.insetBtn.HoverState.FillColor2 = System.Drawing.Color.DarkOliveGreen;
            this.insetBtn.HoverState.ForeColor = System.Drawing.Color.MistyRose;
            this.insetBtn.HoverState.Parent = this.insetBtn;
            this.insetBtn.Location = new System.Drawing.Point(157, 532);
            this.insetBtn.Name = "insetBtn";
            this.insetBtn.ShadowDecoration.Parent = this.insetBtn;
            this.insetBtn.Size = new System.Drawing.Size(147, 32);
            this.insetBtn.TabIndex = 160;
            this.insetBtn.Text = "INSERT";
            this.insetBtn.Click += new System.EventHandler(this.insetBtn_Click);
            // 
            // DRadioBtn
            // 
            this.DRadioBtn.AutoSize = true;
            this.DRadioBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DRadioBtn.CheckedState.BorderThickness = 0;
            this.DRadioBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DRadioBtn.CheckedState.InnerColor = System.Drawing.Color.White;
            this.DRadioBtn.CheckedState.InnerOffset = -4;
            this.DRadioBtn.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DRadioBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(241)))), ((int)(((byte)(237)))));
            this.DRadioBtn.Location = new System.Drawing.Point(380, 381);
            this.DRadioBtn.Name = "DRadioBtn";
            this.DRadioBtn.Size = new System.Drawing.Size(39, 27);
            this.DRadioBtn.TabIndex = 159;
            this.DRadioBtn.TabStop = true;
            this.DRadioBtn.Text = "D";
            this.DRadioBtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.DRadioBtn.UncheckedState.BorderThickness = 2;
            this.DRadioBtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.DRadioBtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.DRadioBtn.UseVisualStyleBackColor = true;
            // 
            // CRadioBtn
            // 
            this.CRadioBtn.AutoSize = true;
            this.CRadioBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CRadioBtn.CheckedState.BorderThickness = 0;
            this.CRadioBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CRadioBtn.CheckedState.InnerColor = System.Drawing.Color.White;
            this.CRadioBtn.CheckedState.InnerOffset = -4;
            this.CRadioBtn.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CRadioBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(241)))), ((int)(((byte)(237)))));
            this.CRadioBtn.Location = new System.Drawing.Point(321, 381);
            this.CRadioBtn.Name = "CRadioBtn";
            this.CRadioBtn.Size = new System.Drawing.Size(39, 27);
            this.CRadioBtn.TabIndex = 158;
            this.CRadioBtn.TabStop = true;
            this.CRadioBtn.Text = "C";
            this.CRadioBtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CRadioBtn.UncheckedState.BorderThickness = 2;
            this.CRadioBtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.CRadioBtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.CRadioBtn.UseVisualStyleBackColor = true;
            // 
            // BRadioBtn
            // 
            this.BRadioBtn.AutoSize = true;
            this.BRadioBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BRadioBtn.CheckedState.BorderThickness = 0;
            this.BRadioBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BRadioBtn.CheckedState.InnerColor = System.Drawing.Color.White;
            this.BRadioBtn.CheckedState.InnerOffset = -4;
            this.BRadioBtn.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRadioBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(241)))), ((int)(((byte)(237)))));
            this.BRadioBtn.Location = new System.Drawing.Point(262, 381);
            this.BRadioBtn.Name = "BRadioBtn";
            this.BRadioBtn.Size = new System.Drawing.Size(39, 27);
            this.BRadioBtn.TabIndex = 157;
            this.BRadioBtn.TabStop = true;
            this.BRadioBtn.Text = "B";
            this.BRadioBtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.BRadioBtn.UncheckedState.BorderThickness = 2;
            this.BRadioBtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.BRadioBtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.BRadioBtn.UseVisualStyleBackColor = true;
            // 
            // ARadioBtn
            // 
            this.ARadioBtn.AutoSize = true;
            this.ARadioBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ARadioBtn.CheckedState.BorderThickness = 0;
            this.ARadioBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ARadioBtn.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ARadioBtn.CheckedState.InnerOffset = -4;
            this.ARadioBtn.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ARadioBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(241)))), ((int)(((byte)(237)))));
            this.ARadioBtn.Location = new System.Drawing.Point(203, 381);
            this.ARadioBtn.Name = "ARadioBtn";
            this.ARadioBtn.Size = new System.Drawing.Size(39, 27);
            this.ARadioBtn.TabIndex = 156;
            this.ARadioBtn.TabStop = true;
            this.ARadioBtn.Text = "A";
            this.ARadioBtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ARadioBtn.UncheckedState.BorderThickness = 2;
            this.ARadioBtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.ARadioBtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.ARadioBtn.UseVisualStyleBackColor = true;
            // 
            // corectOptionLabel
            // 
            this.corectOptionLabel.AutoSize = true;
            this.corectOptionLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.corectOptionLabel.ForeColor = System.Drawing.Color.Red;
            this.corectOptionLabel.Location = new System.Drawing.Point(56, 383);
            this.corectOptionLabel.Name = "corectOptionLabel";
            this.corectOptionLabel.Size = new System.Drawing.Size(126, 23);
            this.corectOptionLabel.TabIndex = 155;
            this.corectOptionLabel.Text = "Correct Option:";
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
            this.BackBtn.Location = new System.Drawing.Point(12, 13);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.ShadowDecoration.Parent = this.BackBtn;
            this.BackBtn.Size = new System.Drawing.Size(68, 28);
            this.BackBtn.TabIndex = 154;
            this.BackBtn.Text = "BACK";
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
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
            this.catagoryCombo.Location = new System.Drawing.Point(62, 434);
            this.catagoryCombo.Name = "catagoryCombo";
            this.catagoryCombo.ShadowDecoration.Parent = this.catagoryCombo;
            this.catagoryCombo.Size = new System.Drawing.Size(380, 36);
            this.catagoryCombo.TabIndex = 77;
            // 
            // idTextBoxPanelLine
            // 
            this.idTextBoxPanelLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTextBoxPanelLine.Location = new System.Drawing.Point(61, 159);
            this.idTextBoxPanelLine.Name = "idTextBoxPanelLine";
            this.idTextBoxPanelLine.Size = new System.Drawing.Size(380, 1);
            this.idTextBoxPanelLine.TabIndex = 66;
            // 
            // idTextBox
            // 
            this.idTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idTextBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(241)))), ((int)(((byte)(237)))));
            this.idTextBox.Location = new System.Drawing.Point(60, 133);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(381, 22);
            this.idTextBox.TabIndex = 64;
            this.idTextBox.Text = "ID";
            this.idTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.idTextBox_KeyDown);
            this.idTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.idTextBox_KeyUp);
            this.idTextBox.MouseEnter += new System.EventHandler(this.idTextBox_MouseEnter);
            this.idTextBox.MouseLeave += new System.EventHandler(this.idTextBox_MouseLeave);
            this.idTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.idTextBox_Validating);
            this.idTextBox.Validated += new System.EventHandler(this.idTextBox_Validated);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(2, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 2);
            this.panel1.TabIndex = 76;
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.AutoSize = true;
            this.errorMessageLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.errorMessageLabel.Location = new System.Drawing.Point(58, 489);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(78, 23);
            this.errorMessageLabel.TabIndex = 74;
            this.errorMessageLabel.Text = "Message";
            // 
            // OpDpanelLine
            // 
            this.OpDpanelLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OpDpanelLine.Location = new System.Drawing.Point(300, 345);
            this.OpDpanelLine.Name = "OpDpanelLine";
            this.OpDpanelLine.Size = new System.Drawing.Size(141, 1);
            this.OpDpanelLine.TabIndex = 72;
            // 
            // OpBPanelLine
            // 
            this.OpBPanelLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OpBPanelLine.Location = new System.Drawing.Point(300, 279);
            this.OpBPanelLine.Name = "OpBPanelLine";
            this.OpBPanelLine.Size = new System.Drawing.Size(141, 1);
            this.OpBPanelLine.TabIndex = 68;
            // 
            // OpDTextBox
            // 
            this.OpDTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.OpDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OpDTextBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpDTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(241)))), ((int)(((byte)(237)))));
            this.OpDTextBox.Location = new System.Drawing.Point(299, 319);
            this.OpDTextBox.Name = "OpDTextBox";
            this.OpDTextBox.Size = new System.Drawing.Size(142, 22);
            this.OpDTextBox.TabIndex = 71;
            this.OpDTextBox.Text = "OptionD";
            this.OpDTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OpDTextBox_KeyDown);
            this.OpDTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OpDTextBox_KeyUp);
            this.OpDTextBox.MouseEnter += new System.EventHandler(this.OpDTextBox_MouseEnter);
            this.OpDTextBox.MouseLeave += new System.EventHandler(this.OpDTextBox_MouseLeave);
            // 
            // OpBTextBox
            // 
            this.OpBTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.OpBTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OpBTextBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpBTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(241)))), ((int)(((byte)(237)))));
            this.OpBTextBox.Location = new System.Drawing.Point(299, 253);
            this.OpBTextBox.Name = "OpBTextBox";
            this.OpBTextBox.Size = new System.Drawing.Size(142, 22);
            this.OpBTextBox.TabIndex = 67;
            this.OpBTextBox.Text = "OptionB";
            this.OpBTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OpBTextBox_KeyDown);
            this.OpBTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OpBTextBox_KeyUp);
            this.OpBTextBox.MouseEnter += new System.EventHandler(this.OpBTextBox_MouseEnter);
            this.OpBTextBox.MouseLeave += new System.EventHandler(this.OpBTextBox_MouseLeave);
            // 
            // OpCpanelLine
            // 
            this.OpCpanelLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OpCpanelLine.Location = new System.Drawing.Point(61, 345);
            this.OpCpanelLine.Name = "OpCpanelLine";
            this.OpCpanelLine.Size = new System.Drawing.Size(141, 1);
            this.OpCpanelLine.TabIndex = 70;
            // 
            // OpCTextBox
            // 
            this.OpCTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.OpCTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OpCTextBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpCTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(241)))), ((int)(((byte)(237)))));
            this.OpCTextBox.Location = new System.Drawing.Point(61, 317);
            this.OpCTextBox.Name = "OpCTextBox";
            this.OpCTextBox.Size = new System.Drawing.Size(142, 22);
            this.OpCTextBox.TabIndex = 69;
            this.OpCTextBox.Text = "OptionC";
            this.OpCTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OpCTextBox_KeyDown);
            this.OpCTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OpCTextBox_KeyUp);
            this.OpCTextBox.MouseEnter += new System.EventHandler(this.OpCTextBox_MouseEnter);
            this.OpCTextBox.MouseLeave += new System.EventHandler(this.OpCTextBox_MouseLeave);
            // 
            // OpAPanelLine
            // 
            this.OpAPanelLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OpAPanelLine.Location = new System.Drawing.Point(61, 279);
            this.OpAPanelLine.Name = "OpAPanelLine";
            this.OpAPanelLine.Size = new System.Drawing.Size(141, 1);
            this.OpAPanelLine.TabIndex = 65;
            // 
            // OpATextBox
            // 
            this.OpATextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.OpATextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OpATextBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpATextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(241)))), ((int)(((byte)(237)))));
            this.OpATextBox.Location = new System.Drawing.Point(61, 251);
            this.OpATextBox.Name = "OpATextBox";
            this.OpATextBox.Size = new System.Drawing.Size(142, 22);
            this.OpATextBox.TabIndex = 64;
            this.OpATextBox.Text = "OptionA";
            this.OpATextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OpATextBox_KeyDown);
            this.OpATextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OpATextBox_KeyUp);
            this.OpATextBox.MouseEnter += new System.EventHandler(this.OpATextBox_MouseEnter);
            this.OpATextBox.MouseLeave += new System.EventHandler(this.OpATextBox_MouseLeave);
            // 
            // QuestionPanelLine
            // 
            this.QuestionPanelLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuestionPanelLine.Location = new System.Drawing.Point(61, 215);
            this.QuestionPanelLine.Name = "QuestionPanelLine";
            this.QuestionPanelLine.Size = new System.Drawing.Size(380, 1);
            this.QuestionPanelLine.TabIndex = 63;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.ForeColor = System.Drawing.Color.Red;
            this.LoginLabel.Location = new System.Drawing.Point(71, 70);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(313, 31);
            this.LoginLabel.TabIndex = 62;
            this.LoginLabel.Text = "ADD NEW QUESTION FORM";
            // 
            // QuestionTextbox
            // 
            this.QuestionTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.QuestionTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuestionTextbox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(241)))), ((int)(((byte)(237)))));
            this.QuestionTextbox.Location = new System.Drawing.Point(61, 189);
            this.QuestionTextbox.Name = "QuestionTextbox";
            this.QuestionTextbox.Size = new System.Drawing.Size(381, 22);
            this.QuestionTextbox.TabIndex = 60;
            this.QuestionTextbox.Text = "Question";
            this.QuestionTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QuestionTextbox_KeyDown);
            this.QuestionTextbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.QuestionTextbox_KeyUp);
            this.QuestionTextbox.MouseEnter += new System.EventHandler(this.QuestionTextbox_MouseEnter);
            this.QuestionTextbox.MouseLeave += new System.EventHandler(this.QuestionTextbox_MouseLeave);
            this.QuestionTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.QuestionTextbox_Validating);
            this.QuestionTextbox.Validated += new System.EventHandler(this.QuestionTextbox_Validated);
            // 
            // AdminForm_AddQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(500, 665);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.TopHeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm_AddQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm_AddQuestion";
            ((System.ComponentModel.ISupportInitialize)(this.errorQuestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIdTextBox)).EndInit();
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

        private System.Windows.Forms.ErrorProvider errorQuestion;
        private System.Windows.Forms.ErrorProvider ErrorIdTextBox;
        private System.Windows.Forms.Panel TopHeaderPanel;
        private System.Windows.Forms.PictureBox minimizeButton;
        private System.Windows.Forms.Label QuizLogoLabel;
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Panel mainPanel;
        private Guna.UI2.WinForms.Guna2GradientButton insetBtn;
        private Guna.UI2.WinForms.Guna2RadioButton DRadioBtn;
        private Guna.UI2.WinForms.Guna2RadioButton CRadioBtn;
        private Guna.UI2.WinForms.Guna2RadioButton BRadioBtn;
        private Guna.UI2.WinForms.Guna2RadioButton ARadioBtn;
        private System.Windows.Forms.Label corectOptionLabel;
        private Guna.UI2.WinForms.Guna2GradientButton BackBtn;
        private Guna.UI2.WinForms.Guna2ComboBox catagoryCombo;
        private System.Windows.Forms.Panel idTextBoxPanelLine;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label errorMessageLabel;
        private System.Windows.Forms.Panel OpDpanelLine;
        private System.Windows.Forms.Panel OpBPanelLine;
        private System.Windows.Forms.TextBox OpDTextBox;
        private System.Windows.Forms.TextBox OpBTextBox;
        private System.Windows.Forms.Panel OpCpanelLine;
        private System.Windows.Forms.TextBox OpCTextBox;
        private System.Windows.Forms.Panel OpAPanelLine;
        private System.Windows.Forms.TextBox OpATextBox;
        private System.Windows.Forms.Panel QuestionPanelLine;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox QuestionTextbox;
    }
}
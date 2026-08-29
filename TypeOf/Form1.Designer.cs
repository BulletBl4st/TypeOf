namespace TypeOf
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tbChallange = new TextBox();
            lbChallange = new Label();
            tbInput = new TextBox();
            lbInput = new Label();
            lbPoints = new Label();
            tbPoints = new TextBox();
            btnStart = new Button();
            lbTimer = new Label();
            timer = new System.Windows.Forms.Timer(components);
            listPrev = new ListBox();
            lbPrev = new Label();
            lbTimer2 = new Label();
            advancedModeButton = new Button();
            hardModeButton = new Button();
            normalModeButton = new Button();
            introLabel = new Label();
            difficultyLabel = new Label();
            pbCredit = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbCredit).BeginInit();
            SuspendLayout();
            // 
            // tbChallange
            // 
            tbChallange.BackColor = Color.FromArgb(64, 64, 64);
            tbChallange.Enabled = false;
            tbChallange.Font = new Font("Rubik", 14.25F);
            tbChallange.ForeColor = SystemColors.Menu;
            tbChallange.Location = new Point(265, 328);
            tbChallange.Multiline = true;
            tbChallange.Name = "tbChallange";
            tbChallange.ReadOnly = true;
            tbChallange.Size = new Size(622, 62);
            tbChallange.TabIndex = 1;
            tbChallange.TextAlign = HorizontalAlignment.Center;
            tbChallange.Visible = false;
            // 
            // lbChallange
            // 
            lbChallange.AutoSize = true;
            lbChallange.Font = new Font("Rubik", 14.25F);
            lbChallange.Location = new Point(507, 204);
            lbChallange.Name = "lbChallange";
            lbChallange.Size = new Size(15, 23);
            lbChallange.TabIndex = 2;
            lbChallange.Text = " ";
            lbChallange.Visible = false;
            // 
            // tbInput
            // 
            tbInput.BackColor = Color.FromArgb(64, 64, 64);
            tbInput.Enabled = false;
            tbInput.Font = new Font("Rubik", 14.25F);
            tbInput.ForeColor = SystemColors.Menu;
            tbInput.Location = new Point(348, 541);
            tbInput.Name = "tbInput";
            tbInput.Size = new Size(510, 30);
            tbInput.TabIndex = 3;
            tbInput.Visible = false;
            tbInput.TextChanged += tbInput_TextChanged;
            // 
            // lbInput
            // 
            lbInput.AutoSize = true;
            lbInput.BackColor = Color.Transparent;
            lbInput.Font = new Font("Rubik", 14.25F);
            lbInput.ForeColor = SystemColors.Control;
            lbInput.Location = new Point(217, 544);
            lbInput.Name = "lbInput";
            lbInput.Size = new Size(100, 23);
            lbInput.TabIndex = 4;
            lbInput.Text = "Type here";
            lbInput.Visible = false;
            // 
            // lbPoints
            // 
            lbPoints.AutoSize = true;
            lbPoints.BackColor = Color.Transparent;
            lbPoints.Font = new Font("Rubik", 14.25F);
            lbPoints.ForeColor = SystemColors.ButtonFace;
            lbPoints.Location = new Point(217, 486);
            lbPoints.Name = "lbPoints";
            lbPoints.Size = new Size(148, 23);
            lbPoints.TabIndex = 5;
            lbPoints.Text = "Points this run:";
            lbPoints.Visible = false;
            // 
            // tbPoints
            // 
            tbPoints.AcceptsReturn = true;
            tbPoints.BackColor = Color.FromArgb(64, 64, 64);
            tbPoints.Enabled = false;
            tbPoints.Font = new Font("Rubik", 14.25F);
            tbPoints.Location = new Point(385, 470);
            tbPoints.Multiline = true;
            tbPoints.Name = "tbPoints";
            tbPoints.ReadOnly = true;
            tbPoints.Size = new Size(72, 54);
            tbPoints.TabIndex = 6;
            tbPoints.Visible = false;
            // 
            // btnStart
            // 
            btnStart.BackgroundImage = (Image)resources.GetObject("btnStart.BackgroundImage");
            btnStart.Enabled = false;
            btnStart.Font = new Font("Rubik", 14.25F);
            btnStart.ForeColor = SystemColors.Control;
            btnStart.Location = new Point(477, 597);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(170, 81);
            btnStart.TabIndex = 8;
            btnStart.Text = "Start ";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lbTimer
            // 
            lbTimer.AutoSize = true;
            lbTimer.BackColor = SystemColors.ActiveCaptionText;
            lbTimer.Font = new Font("Rubik", 14.25F);
            lbTimer.ForeColor = SystemColors.Control;
            lbTimer.Location = new Point(598, 393);
            lbTimer.Name = "lbTimer";
            lbTimer.Size = new Size(47, 23);
            lbTimer.TabIndex = 9;
            lbTimer.Text = "1:00";
            lbTimer.Visible = false;
            // 
            // timer
            // 
            timer.Tick += timer2_Tick;
            // 
            // listPrev
            // 
            listPrev.BackColor = Color.FromArgb(64, 64, 64);
            listPrev.Font = new Font("Rubik", 14.25F);
            listPrev.ForeColor = SystemColors.Menu;
            listPrev.FormattingEnabled = true;
            listPrev.ItemHeight = 23;
            listPrev.Location = new Point(866, 122);
            listPrev.Name = "listPrev";
            listPrev.Size = new Size(258, 556);
            listPrev.TabIndex = 10;
            listPrev.Visible = false;
            // 
            // lbPrev
            // 
            lbPrev.AutoSize = true;
            lbPrev.BackColor = Color.Transparent;
            lbPrev.Font = new Font("Rubik", 14.25F);
            lbPrev.ForeColor = Color.White;
            lbPrev.Location = new Point(866, 96);
            lbPrev.Name = "lbPrev";
            lbPrev.Size = new Size(179, 23);
            lbPrev.TabIndex = 11;
            lbPrev.Text = "Previous Attempts";
            lbPrev.Visible = false;
            // 
            // lbTimer2
            // 
            lbTimer2.AutoSize = true;
            lbTimer2.BackColor = SystemColors.ActiveCaptionText;
            lbTimer2.Font = new Font("Rubik", 14.25F);
            lbTimer2.ForeColor = SystemColors.ButtonFace;
            lbTimer2.Location = new Point(464, 393);
            lbTimer2.Name = "lbTimer2";
            lbTimer2.Size = new Size(101, 23);
            lbTimer2.TabIndex = 12;
            lbTimer2.Text = "Time Left:";
            lbTimer2.Visible = false;
            // 
            // advancedModeButton
            // 
            advancedModeButton.Font = new Font("Rubik", 14.25F);
            advancedModeButton.Location = new Point(682, 406);
            advancedModeButton.Name = "advancedModeButton";
            advancedModeButton.Size = new Size(112, 44);
            advancedModeButton.TabIndex = 13;
            advancedModeButton.Text = "Advanced";
            advancedModeButton.UseVisualStyleBackColor = true;
            advancedModeButton.Click += advancedModeButton_Click;
            // 
            // hardModeButton
            // 
            hardModeButton.Font = new Font("Rubik", 14.25F);
            hardModeButton.Location = new Point(535, 406);
            hardModeButton.Name = "hardModeButton";
            hardModeButton.Size = new Size(112, 43);
            hardModeButton.TabIndex = 14;
            hardModeButton.Text = "Hard";
            hardModeButton.UseVisualStyleBackColor = true;
            hardModeButton.Click += hardModeButton_Click;
            // 
            // normalModeButton
            // 
            normalModeButton.Font = new Font("Rubik", 14.25F);
            normalModeButton.Location = new Point(385, 406);
            normalModeButton.Name = "normalModeButton";
            normalModeButton.Size = new Size(112, 43);
            normalModeButton.TabIndex = 15;
            normalModeButton.Text = "Normal";
            normalModeButton.UseVisualStyleBackColor = true;
            normalModeButton.Click += normalModeButton_Click;
            // 
            // introLabel
            // 
            introLabel.AutoSize = true;
            introLabel.BackColor = Color.Transparent;
            introLabel.Font = new Font("Rubik", 14.25F);
            introLabel.ForeColor = SystemColors.ButtonHighlight;
            introLabel.Location = new Point(405, 9);
            introLabel.Name = "introLabel";
            introLabel.Size = new Size(395, 23);
            introLabel.TabIndex = 16;
            introLabel.Text = "Can you type as fast as you think you can?";
            // 
            // difficultyLabel
            // 
            difficultyLabel.AutoSize = true;
            difficultyLabel.BackColor = Color.Transparent;
            difficultyLabel.Font = new Font("Rubik", 14.25F);
            difficultyLabel.ForeColor = SystemColors.ControlLightLight;
            difficultyLabel.Location = new Point(163, 416);
            difficultyLabel.Name = "difficultyLabel";
            difficultyLabel.Size = new Size(212, 23);
            difficultyLabel.TabIndex = 17;
            difficultyLabel.Text = "Choose your difficulty:";
            // 
            // pbCredit
            // 
            pbCredit.Image = (Image)resources.GetObject("pbCredit.Image");
            pbCredit.Location = new Point(12, 51);
            pbCredit.Name = "pbCredit";
            pbCredit.Size = new Size(349, 244);
            pbCredit.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCredit.TabIndex = 18;
            pbCredit.TabStop = false;
            pbCredit.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1136, 701);
            Controls.Add(pbCredit);
            Controls.Add(difficultyLabel);
            Controls.Add(introLabel);
            Controls.Add(normalModeButton);
            Controls.Add(hardModeButton);
            Controls.Add(advancedModeButton);
            Controls.Add(lbTimer2);
            Controls.Add(lbPrev);
            Controls.Add(listPrev);
            Controls.Add(lbTimer);
            Controls.Add(btnStart);
            Controls.Add(tbPoints);
            Controls.Add(lbPoints);
            Controls.Add(lbInput);
            Controls.Add(tbInput);
            Controls.Add(lbChallange);
            Controls.Add(tbChallange);
            DoubleBuffered = true;
            Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "TypeOf";
            ((System.ComponentModel.ISupportInitialize)pbCredit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbChallange;
        private Label lbChallange;
        private TextBox tbInput;
        private Label lbInput;
        private Label lbPoints;
        private TextBox tbPoints;
        private Button btnStart;
        private Label lbTimer;
        private System.Windows.Forms.Timer timer;
        private ListBox listPrev;
        private Label lbPrev;
        private Label lbTimer2;
        private Button advancedModeButton;
        private Button hardModeButton;
        private Button normalModeButton;
        private Label introLabel;
        private Label difficultyLabel;
        private PictureBox pbCredit;
    }
}

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
            btnStart = new Button();
            lbTimer = new Label();
            timer = new System.Windows.Forms.Timer(components);
            lbPrev = new Label();
            lbTimer2 = new Label();
            advancedModeButton = new Button();
            hardModeButton = new Button();
            normalModeButton = new Button();
            introLabel = new Label();
            difficultyLabel = new Label();
            retryButton = new Button();
            homeButton = new Button();
            listAttempts = new ListView();
            lbScore = new Label();
            SuspendLayout();
            // 
            // tbChallange
            // 
            tbChallange.BackColor = Color.FromArgb(64, 64, 64);
            tbChallange.Font = new Font("Rubik", 14.25F);
            tbChallange.ForeColor = SystemColors.Menu;
            tbChallange.Location = new Point(274, 421);
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
            tbInput.Font = new Font("Rubik", 14.25F);
            tbInput.ForeColor = SystemColors.Menu;
            tbInput.Location = new Point(381, 541);
            tbInput.Name = "tbInput";
            tbInput.Size = new Size(515, 30);
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
            lbInput.Location = new Point(274, 544);
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
            lbPoints.Location = new Point(274, 495);
            lbPoints.Name = "lbPoints";
            lbPoints.Size = new Size(148, 23);
            lbPoints.TabIndex = 5;
            lbPoints.Text = "Points this run:";
            lbPoints.Visible = false;
            // 
            // btnStart
            // 
            btnStart.BackgroundImage = (Image)resources.GetObject("btnStart.BackgroundImage");
            btnStart.Enabled = false;
            btnStart.Font = new Font("Rubik", 14.25F);
            btnStart.ForeColor = SystemColors.Control;
            btnStart.Location = new Point(510, 597);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(179, 81);
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
            lbTimer.Location = new Point(642, 495);
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
            // lbPrev
            // 
            lbPrev.AutoSize = true;
            lbPrev.BackColor = Color.Transparent;
            lbPrev.Font = new Font("Rubik", 14.25F);
            lbPrev.ForeColor = Color.White;
            lbPrev.Location = new Point(935, 395);
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
            lbTimer2.Location = new Point(535, 495);
            lbTimer2.Name = "lbTimer2";
            lbTimer2.Size = new Size(101, 23);
            lbTimer2.TabIndex = 12;
            lbTimer2.Text = "Time Left:";
            lbTimer2.Visible = false;
            // 
            // advancedModeButton
            // 
            advancedModeButton.BackColor = SystemColors.Control;
            advancedModeButton.FlatStyle = FlatStyle.Popup;
            advancedModeButton.Font = new Font("Rubik", 14.25F);
            advancedModeButton.Location = new Point(684, 524);
            advancedModeButton.Name = "advancedModeButton";
            advancedModeButton.Size = new Size(112, 44);
            advancedModeButton.TabIndex = 13;
            advancedModeButton.Text = "Advanced";
            advancedModeButton.UseVisualStyleBackColor = false;
            advancedModeButton.Click += advancedModeButton_Click;
            // 
            // hardModeButton
            // 
            hardModeButton.BackColor = Color.White;
            hardModeButton.FlatStyle = FlatStyle.Popup;
            hardModeButton.Font = new Font("Rubik", 14.25F);
            hardModeButton.Location = new Point(544, 524);
            hardModeButton.Name = "hardModeButton";
            hardModeButton.Size = new Size(112, 43);
            hardModeButton.TabIndex = 14;
            hardModeButton.Text = "Hard";
            hardModeButton.UseVisualStyleBackColor = false;
            hardModeButton.Click += hardModeButton_Click;
            // 
            // normalModeButton
            // 
            normalModeButton.BackColor = SystemColors.Control;
            normalModeButton.FlatStyle = FlatStyle.Popup;
            normalModeButton.Font = new Font("Rubik", 14.25F);
            normalModeButton.Location = new Point(401, 525);
            normalModeButton.Name = "normalModeButton";
            normalModeButton.Size = new Size(112, 43);
            normalModeButton.TabIndex = 15;
            normalModeButton.Text = "Normal";
            normalModeButton.UseVisualStyleBackColor = false;
            normalModeButton.Click += normalModeButton_Click;
            // 
            // introLabel
            // 
            introLabel.AutoSize = true;
            introLabel.BackColor = Color.Transparent;
            introLabel.Font = new Font("Rubik", 14.25F);
            introLabel.ForeColor = SystemColors.ButtonHighlight;
            introLabel.Location = new Point(401, 442);
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
            difficultyLabel.Location = new Point(487, 498);
            difficultyLabel.Name = "difficultyLabel";
            difficultyLabel.Size = new Size(212, 23);
            difficultyLabel.TabIndex = 17;
            difficultyLabel.Text = "Choose your difficulty:";
            // 
            // retryButton
            // 
            retryButton.BackgroundImage = (Image)resources.GetObject("retryButton.BackgroundImage");
            retryButton.Enabled = false;
            retryButton.Font = new Font("Rubik", 14.25F);
            retryButton.ForeColor = SystemColors.Control;
            retryButton.Location = new Point(726, 597);
            retryButton.Name = "retryButton";
            retryButton.Size = new Size(170, 81);
            retryButton.TabIndex = 19;
            retryButton.Text = "Retry";
            retryButton.UseVisualStyleBackColor = true;
            retryButton.Visible = false;
            retryButton.Click += retryButton_Click_1;
            // 
            // homeButton
            // 
            homeButton.BackgroundImage = (Image)resources.GetObject("homeButton.BackgroundImage");
            homeButton.Enabled = false;
            homeButton.Font = new Font("Rubik", 14.25F);
            homeButton.ForeColor = SystemColors.Control;
            homeButton.Location = new Point(274, 597);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(170, 81);
            homeButton.TabIndex = 20;
            homeButton.Text = "Home";
            homeButton.UseVisualStyleBackColor = true;
            homeButton.Visible = false;
            homeButton.Click += homeButton_Click;
            // 
            // listAttempts
            // 
            listAttempts.BackColor = SystemColors.WindowFrame;
            listAttempts.BackgroundImage = (Image)resources.GetObject("listAttempts.BackgroundImage");
            listAttempts.ForeColor = SystemColors.Menu;
            listAttempts.Location = new Point(902, 421);
            listAttempts.Name = "listAttempts";
            listAttempts.Size = new Size(234, 228);
            listAttempts.TabIndex = 21;
            listAttempts.UseCompatibleStateImageBehavior = false;
            listAttempts.View = View.SmallIcon;
            listAttempts.Visible = false;
            // 
            // lbScore
            // 
            lbScore.AutoSize = true;
            lbScore.BackColor = Color.Transparent;
            lbScore.Font = new Font("Rubik", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbScore.ForeColor = SystemColors.ButtonFace;
            lbScore.Location = new Point(428, 495);
            lbScore.Name = "lbScore";
            lbScore.Size = new Size(31, 32);
            lbScore.TabIndex = 22;
            lbScore.Text = "0";
            lbScore.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1136, 701);
            Controls.Add(lbScore);
            Controls.Add(listAttempts);
            Controls.Add(homeButton);
            Controls.Add(retryButton);
            Controls.Add(difficultyLabel);
            Controls.Add(introLabel);
            Controls.Add(normalModeButton);
            Controls.Add(hardModeButton);
            Controls.Add(advancedModeButton);
            Controls.Add(lbTimer2);
            Controls.Add(lbPrev);
            Controls.Add(lbTimer);
            Controls.Add(btnStart);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbChallange;
        private Label lbChallange;
        private TextBox tbInput;
        private Label lbInput;
        private Label lbPoints;
        private Button btnStart;
        private Label lbTimer;
        private System.Windows.Forms.Timer timer;
        private Label lbPrev;
        private Label lbTimer2;
        private Button advancedModeButton;
        private Button hardModeButton;
        private Button normalModeButton;
        private Label introLabel;
        private Label difficultyLabel;
        private Button retryButton;
        private Button homeButton;
        private ListView listAttempts;
        private Label lbScore;
    }
}

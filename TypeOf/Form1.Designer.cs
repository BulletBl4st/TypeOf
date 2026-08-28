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
            label1 = new Label();
            tbChallange = new TextBox();
            lbChallange = new Label();
            tbInput = new TextBox();
            lbInput = new Label();
            lbPoints = new Label();
            tbPoints = new TextBox();
            pictureBox1 = new PictureBox();
            btnStart = new Button();
            lbTimer = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            listPrev = new ListBox();
            lbPrev = new Label();
            lbTimer2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(483, 77);
            label1.Name = "label1";
            label1.Size = new Size(178, 23);
            label1.TabIndex = 0;
            label1.Text = "Game Logo here";
            // 
            // tbChallange
            // 
            tbChallange.BackColor = SystemColors.ControlDarkDark;
            tbChallange.Enabled = false;
            tbChallange.ForeColor = SystemColors.Menu;
            tbChallange.Location = new Point(299, 230);
            tbChallange.Multiline = true;
            tbChallange.Name = "tbChallange";
            tbChallange.ReadOnly = true;
            tbChallange.Size = new Size(622, 81);
            tbChallange.TabIndex = 1;
            tbChallange.Visible = false;
            // 
            // lbChallange
            // 
            lbChallange.AutoSize = true;
            lbChallange.Location = new Point(507, 204);
            lbChallange.Name = "lbChallange";
            lbChallange.Size = new Size(22, 23);
            lbChallange.TabIndex = 2;
            lbChallange.Text = " ";
            lbChallange.Visible = false;
            // 
            // tbInput
            // 
            tbInput.BackColor = SystemColors.ControlDarkDark;
            tbInput.Enabled = false;
            tbInput.ForeColor = SystemColors.Menu;
            tbInput.Location = new Point(449, 449);
            tbInput.Name = "tbInput";
            tbInput.Size = new Size(380, 30);
            tbInput.TabIndex = 3;
            tbInput.Visible = false;
            tbInput.TextChanged += tbInput_TextChanged;
            // 
            // lbInput
            // 
            lbInput.AutoSize = true;
            lbInput.Location = new Point(325, 452);
            lbInput.Name = "lbInput";
            lbInput.Size = new Size(118, 23);
            lbInput.TabIndex = 4;
            lbInput.Text = "Type here";
            lbInput.Visible = false;
            // 
            // lbPoints
            // 
            lbPoints.AutoSize = true;
            lbPoints.Location = new Point(299, 362);
            lbPoints.Name = "lbPoints";
            lbPoints.Size = new Size(202, 23);
            lbPoints.TabIndex = 5;
            lbPoints.Text = "Points this run:";
            lbPoints.Visible = false;
            // 
            // tbPoints
            // 
            tbPoints.AcceptsReturn = true;
            tbPoints.BackColor = SystemColors.ControlDark;
            tbPoints.Enabled = false;
            tbPoints.Location = new Point(507, 348);
            tbPoints.Multiline = true;
            tbPoints.Name = "tbPoints";
            tbPoints.ReadOnly = true;
            tbPoints.Size = new Size(72, 54);
            tbPoints.TabIndex = 6;
            tbPoints.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 230);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 246);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnStart
            // 
            btnStart.BackgroundImage = (Image)resources.GetObject("btnStart.BackgroundImage");
            btnStart.FlatStyle = FlatStyle.Popup;
            btnStart.ForeColor = SystemColors.Control;
            btnStart.Location = new Point(491, 317);
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
            lbTimer.Location = new Point(559, 204);
            lbTimer.Name = "lbTimer";
            lbTimer.Size = new Size(58, 23);
            lbTimer.TabIndex = 9;
            lbTimer.Text = "1:00";
            lbTimer.Visible = false;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // listPrev
            // 
            listPrev.BackColor = SystemColors.ControlDarkDark;
            listPrev.ForeColor = SystemColors.Menu;
            listPrev.FormattingEnabled = true;
            listPrev.ItemHeight = 23;
            listPrev.Location = new Point(927, 88);
            listPrev.Name = "listPrev";
            listPrev.Size = new Size(272, 556);
            listPrev.TabIndex = 10;
            listPrev.Visible = false;
            // 
            // lbPrev
            // 
            lbPrev.AutoSize = true;
            lbPrev.Location = new Point(927, 62);
            lbPrev.Name = "lbPrev";
            lbPrev.Size = new Size(214, 23);
            lbPrev.TabIndex = 11;
            lbPrev.Text = "Previous Attempts";
            lbPrev.Visible = false;
            // 
            // lbTimer2
            // 
            lbTimer2.AutoSize = true;
            lbTimer2.Location = new Point(423, 204);
            lbTimer2.Name = "lbTimer2";
            lbTimer2.Size = new Size(130, 23);
            lbTimer2.TabIndex = 12;
            lbTimer2.Text = "Time Left:";
            lbTimer2.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1220, 701);
            Controls.Add(lbTimer2);
            Controls.Add(lbPrev);
            Controls.Add(listPrev);
            Controls.Add(lbTimer);
            Controls.Add(btnStart);
            Controls.Add(pictureBox1);
            Controls.Add(tbPoints);
            Controls.Add(lbPoints);
            Controls.Add(lbInput);
            Controls.Add(tbInput);
            Controls.Add(lbChallange);
            Controls.Add(tbChallange);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Unispace", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "TypeOf";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbChallange;
        private Label lbChallange;
        private TextBox tbInput;
        private Label lbInput;
        private Label lbPoints;
        private TextBox tbPoints;
        private PictureBox pictureBox1;
        private Button btnStart;
        private Label lbTimer;
        private System.Windows.Forms.Timer timer2;
        private ListBox listPrev;
        private Label lbPrev;
        private Label lbTimer2;
    }
}

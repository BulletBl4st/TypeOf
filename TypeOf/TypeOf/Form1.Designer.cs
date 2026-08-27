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
            timer1 = new System.Windows.Forms.Timer(components);
            btnStart = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(536, 90);
            label1.Name = "label1";
            label1.Size = new Size(178, 23);
            label1.TabIndex = 0;
            label1.Text = "Game Logo here";
            // 
            // tbChallange
            // 
            tbChallange.Enabled = false;
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
            lbChallange.Location = new Point(521, 204);
            lbChallange.Name = "lbChallange";
            lbChallange.Size = new Size(202, 23);
            lbChallange.TabIndex = 2;
            lbChallange.Text = "Text to be typed";
            lbChallange.Visible = false;
            // 
            // tbInput
            // 
            tbInput.AcceptsReturn = true;
            tbInput.Enabled = false;
            tbInput.Location = new Point(474, 449);
            tbInput.Name = "tbInput";
            tbInput.Size = new Size(380, 30);
            tbInput.TabIndex = 3;
            tbInput.Visible = false;
            tbInput.KeyPress += InputAnswer;
            // 
            // lbInput
            // 
            lbInput.AutoSize = true;
            lbInput.Location = new Point(350, 452);
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
            btnStart.Location = new Point(536, 304);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(170, 81);
            btnStart.TabIndex = 8;
            btnStart.Text = "Start ";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1294, 701);
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
        private System.Windows.Forms.Timer timer1;
        private Button btnStart;
    }
}

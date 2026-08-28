using Newtonsoft.Json;
namespace TypeOf
{
    public partial class Form1 : Form
    {
        int timeLeft;
        int points;
        float accuracyPercent;
        int correctWordsCount;
        Game currentRun;
        public Form1()
        {
            InitializeComponent();
            timer2.Interval = 1000;
            timeLeft = 60;
            points = 0;
        }


        //private void InputAnswer(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == (char)Keys.Enter)
        //    {
        //        //Take text from input field, compare to text currently in lbChallange
        //        string answer = lbInput.Text;
        //        MessageBox.Show("Enter is pressed");

        //    }
        //}

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStart.Visible = false;
            lbChallange.Visible = true;
            tbChallange.Visible = true; tbChallange.Enabled = true;
            lbInput.Visible = true;
            tbInput.Visible = true; tbInput.Enabled = true;

            lbPoints.Visible = true;
            tbPoints.Visible = true; tbPoints.Enabled = true;
            lbTimer.Visible = true;
            lbTimer2.Visible = true;
            timer2.Start();
            timeLeft = 60;


        }



        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                lbTimer.Text = String.Format("{0}:{1}", timeLeft / 60, timeLeft % 60);
            }
            else if (timeLeft == 0)
            {
                lbTimer.Text = String.Format("Time's Up");
                timer2.Stop();
                //TODO, implement gameover
            }
        }

        private void tbInput_TextChanged(object sender, EventArgs e)
        {
            //TODO, compare current text of the textbox with the object storing the challange text
            // Mislata mie, za sekoj zbor tocno napisan, dobivas 10 poeni (see points variable at top of file)
            //i na sekoj correct, incorrect word accuracy se kalkulira odnovo, za ova imam i napraveno tbInput da ne prima backspace.
            if (true)
            {
                correctWordsCount++;
                points += 10;
                //ToDO run the function that calculates accuracy
            }
            else
            {
                //ToDo, run the function that calculates accuracy
            }
            
        }
        // Koga igrata zavrsuva
        // lbPrev i listPrev treba da se napravat Visible, tamu e kade ke se displaynat previous attempts sto ke gi cuvame vo Game klasata
        // ^^^ na sekoj game over pred da se resetiraat values, da se prenesat site points i stvari vo Object od tip na Game -currentGame objektot za ova
    }
}

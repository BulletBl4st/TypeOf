using Newtonsoft.Json;
namespace TypeOf
{
    public partial class Form1 : Form
    {
        int timeLeft;
        public Form1()
        {
            InitializeComponent();
            timer2.Interval = 1000;
            timeLeft = 60;
        }

        private void InputAnswer(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                //Take text from input field, compare to text currently in lbChallange
                string answer = lbInput.Text;

            }
        }

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
            timer2.Start();
            timeLeft = 60;
            
        }



        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timeLeft> 0)
            {
                timeLeft--;
                lbTimer.Text = String.Format("{0}:{1}", timeLeft / 60, timeLeft % 60);
            }
            else if(timeLeft == 0)
            {
                lbTimer.Text = String.Format("Time's Up");
                timer2.Stop();
                //TODO, implement gameover
            }
        }
    }
}

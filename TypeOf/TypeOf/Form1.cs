namespace TypeOf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void InputAnswer(object sender, KeyPressEventArgs e)
        {

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
        }
    }
}

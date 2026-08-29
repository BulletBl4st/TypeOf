using System.Text.Json;
namespace TypeOf
{
    public partial class Form1 : Form
    {
        int timeLeft;
        int points;

        string difficulty="";
        int correctWordsCount = 0;
        int allWordsCount;
        int incorrectWordsCount = 0;
        Game currentRun;
        List<Sentence>? sentenceList;
        int temp = 0;

        public Form1()
        {
            InitializeComponent();
            timer2.Interval = 1000;
            timeLeft = 60;
            points = 0;
            allWordsCount = 0;
            sentenceList = new List<Sentence>();
            readData();
            tbInput.KeyUp += new KeyEventHandler(pressEnter);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStart.Visible = false;

            introLabel.Visible = false;
            difficultyLabel.Visible = false;

            normalModeButton.Visible = false;
            normalModeButton.Enabled = false;

            hardModeButton.Visible = false;
            hardModeButton.Enabled = false;

            advancedModeButton.Visible = false;
            advancedModeButton.Enabled = false;

            lbChallange.Visible = true;

            tbChallange.Visible = true;
            tbChallange.Enabled = true;

            lbInput.Visible = true;

            tbInput.Visible = true;
            tbInput.Enabled = true;

            lbPoints.Visible = true;

            tbPoints.Visible = true;
            tbPoints.Enabled = true;

            lbTimer.Visible = true;
            lbTimer2.Visible = true;

            showData();

            timer2.Start();
            timeLeft = 5;
        }

        public void readData()
        {
            string jsonString = File.ReadAllText("sentences.json");

            sentenceList = JsonSerializer.Deserialize<List<Sentence>>(jsonString);
        }

        public void showData()
        {
            List<Sentence> filteredSentences = sentenceList.Where(s => s.difficulty == difficulty).ToList();
            
            Random rnd = new Random();
            int value = rnd.Next(1, filteredSentences.Count);

            tbChallange.Text = filteredSentences[value].text.ToString();
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
                MessageBox.Show($"{correctWordsCount}, {incorrectWordsCount},{allWordsCount}");
                //TODO, implement gameover
            }
        }

        private void tbInput_TextChanged(object sender, EventArgs e)
        {
            checkWords(tbInput.Text, temp);
        }

        private void checkWords(string input, int index)
        {
            if (tbChallange.Text[index].Equals(input[index]))
            {
                correctWordsCount++;
                allWordsCount++;
                temp++;
            }
            else
            {
                incorrectWordsCount++;
                allWordsCount++;
                temp++;
            }
        }

        private void pressEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                temp = 0;
                tbChallange.Clear();
                showData();
            }
        }

        private void normalModeButton_Click(object sender, EventArgs e)
        {
            difficulty = "Normal";
            btnStart.Enabled = true;
        }

        private void hardModeButton_Click(object sender, EventArgs e)
        {
            difficulty = "Hard";
            btnStart.Enabled = true;
        }

        private void advancedModeButton_Click(object sender, EventArgs e)
        {
            difficulty = "Advanced";
            btnStart.Enabled = true;
        }
        // Koga igrata zavrsuva
        // lbPrev i listPrev treba da se napravat Visible, tamu e kade ke se displaynat previous attempts sto ke gi cuvame vo Game klasata
        // ^^^ na sekoj game over pred da se resetiraat values, da se prenesat site points i stvari vo Object od tip na Game -currentGame objektot za ova
    }
}

using System.Text.Json;
namespace TypeOf
{
    public partial class Form1 : Form
    {
        int timeLeft;
        int points;

        string difficulty = "";
        int correctWordsCount = 0;
        int allWordsCount;
        int incorrectWordsCount = 0;
        List<Sentence>? sentenceList;
        int temp = 0;

        public Form1()
        {
            InitializeComponent();
            sentenceList = new List<Sentence>();
            allWordsCount = 0;
        }

        public void startGame()
        {
            timer.Interval = 1000;
            timeLeft = 60;
            points = 0;
            readData();
            tbInput.KeyUp += new KeyEventHandler(pressEnter);
            tbInput.Select();
            showData();
            timer.Start();
            //debug tool
            timeLeft = 5;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //btnStart.Enabled = false;
            btnStart.Visible = false;

            introLabel.Visible = false;
            difficultyLabel.Visible = false;

            normalModeButton.Visible = false;
            //normalModeButton.Enabled = false;

            hardModeButton.Visible = false;
            //hardModeButton.Enabled = false;

            advancedModeButton.Visible = false;
            //advancedModeButton.Enabled = false;

            lbChallange.Visible = true;

            tbChallange.Visible = true;
            //tbChallange.Enabled = true;

            lbInput.Visible = true;

            tbInput.Visible = true;
            //tbInput.Enabled = true;

            lbPoints.Visible = true;

            lbScore.Visible = true;
            //tbPoints.Enabled = true;

            lbTimer.Visible = true;
            lbTimer2.Visible = true;

            startGame();
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

        public float accuracyPercentage(int a, int b)
        {
            return ((float)a / b) * 100;
        }

        public void createAttempt(float accuracy)
        {
            int index = listAttempts.Items.Count + 1;
            Attempt currentAttempt = new Attempt(index, accuracy, points);
            listAttempts.Items.Add(currentAttempt.ToString());
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                if (timeLeft <= 30)
                {
                    lbTimer.ForeColor = Color.Red;
                }
                lbTimer.Text = String.Format("{0}:{1}", timeLeft / 60, timeLeft % 60);
            }
            else if (timeLeft == 0)
            {
                lbTimer.Text = String.Format("Time's Up!");
                tbInput.ReadOnly = true;
                homeButton.Enabled = true;
                homeButton.Visible = true;
                retryButton.Enabled = true;
                retryButton.Visible = true;
                timer.Stop();
                listAttempts.Visible = true;

                
                createAttempt(accuracyPercentage(correctWordsCount, allWordsCount));
            }
        }

        private void tbInput_TextChanged(object sender, EventArgs e)
        {
            checkWords(tbInput.Text, temp);
            //Points system
            //points = correctWordsCount * 10;

            lbScore.Text = points.ToString();
        }

        private void checkWords(string input, int index)
        {
            if (index >= 0 && index < input.Length && index < tbChallange.TextLength)
            {
                if (tbChallange.Text[index].Equals(input[index]))
                {
                    correctWordsCount++;
                    points += 3;
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
        }

        private void pressEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (temp > 0)
                {
                    tbInput.Clear();
                }
                temp = 0;
                tbChallange.Clear();
                showData();
            }
            else if (e.KeyCode == Keys.Back)
            {
                if (temp > 0)
                {
                    temp--;
                    correctWordsCount--;
                    allWordsCount--;
                    incorrectWordsCount--;// placeholder, moze da se smeni
                    points--;
                }
            }
        }
        private void chooseDifficulty(string input)
        {
            difficulty = input;
            btnStart.Enabled = true;
            switch (input)
            {
                case "Normal": normalModeButton.BackColor = Color.DimGray; normalModeButton.ForeColor = Color.White;
                    hardModeButton.BackColor = Color.White; hardModeButton.ForeColor = Color.Black;
                    advancedModeButton.BackColor = Color.White; advancedModeButton.ForeColor = Color.Black;
                    break;
                case "Hard": hardModeButton.BackColor = Color.Gray; hardModeButton.ForeColor = Color.White;
                    normalModeButton.BackColor = Color.White; normalModeButton.ForeColor = Color.Black;
                    advancedModeButton.BackColor = Color.White; advancedModeButton.ForeColor = Color.Black;
                    break; 
                case "Advanced": advancedModeButton.BackColor = Color.IndianRed; advancedModeButton.ForeColor= Color.White;
                    hardModeButton.BackColor = Color.White; hardModeButton.ForeColor = Color.Black;
                    normalModeButton.BackColor = Color.White; normalModeButton.ForeColor = Color.Black;
                    break;
            }


        }

        private void normalModeButton_Click(object sender, EventArgs e)
        {
            chooseDifficulty("Normal");

        }

        private void hardModeButton_Click(object sender, EventArgs e)
        {
            chooseDifficulty("Hard");
        }

        private void advancedModeButton_Click(object sender, EventArgs e)
        {
            chooseDifficulty("Advanced");
        }

        public void reset()
        {
            tbInput.Clear();
            correctWordsCount = 0;
            allWordsCount = 0;
            incorrectWordsCount = 0;
            points = 0;
            temp = 0;
        }

        private void retryButton_Click_1(object sender, EventArgs e)
        {
            retryButton.Visible = false;
            retryButton.Enabled = false;
            homeButton.Visible = false;
            homeButton.Enabled = false;

            tbInput.ReadOnly = false;
            reset();
            startGame();
            tbInput.Select();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStart.Visible = true;

            introLabel.Visible = true;
            difficultyLabel.Visible = true;

            normalModeButton.Visible = true;
            //normalModeButton.Enabled = true;

            hardModeButton.Visible = true;
            //hardModeButton.Enabled = true;
            advancedModeButton.Visible = true;
            //advancedModeButton.Enabled = true;

            lbChallange.Visible = false;
            tbChallange.Visible = false;
            //tbChallange.Enabled = false;

            lbInput.Visible = false;
            tbInput.Visible = false;

            //tbInput.Enabled = false;
            lbPoints.Visible = false;
            lbScore.Visible = false;
            //tbPoints.Enabled = false;

            lbTimer.Visible = false;
            lbTimer2.Visible = false;

            retryButton.Visible = false;
            homeButton.Visible = false;
            listAttempts.Visible = false;
            reset();
            lbScore.Text = "0";
            tbInput.ReadOnly = false;
        }

        // Koga igrata zavrsuva
        // lbPrev i listPrev treba da se napravat Visible, tamu e kade ke se displaynat previous attempts sto ke gi cuvame vo Game klasata
        // ^^^ na sekoj game over pred da se resetiraat values, da se prenesat site points i stvari vo Object od tip na Game -currentGame objektot za ova
    }
}

namespace DiceGame
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    public partial class DiceGame : Form
    {
        private List<string> DiceNumbers = new List<string>();//random dices

        private Dictionary<string, int> DicePoints = new Dictionary<string, int>() {
            { "1", 1000 },
            { "2", 200 },
            { "3", 300 },
            { "4", 400 },
            { "5", 500 },
            { "6", 600 } };

        private List<int> TotalPoins = new List<int>();//list with earned points
                                                       // list of triple's cost

        public DiceGame()
        {
            InitializeComponent();
        }

        private void NonTriple(int index) // search non triple dices
        {
            if (DiceNumbers[index] == "1")
            {
                ResultTextBox.AppendText($"\n1 => 100");
                TotalPoins.Add(100);
            }
            if (DiceNumbers[index] == "5")
            {
                ResultTextBox.AppendText($"\n5 => 50");
                TotalPoins.Add(50);
            }
        }

        private void Start_btn_Click(object sender, EventArgs e)
        {
            DiceNumbers.Clear();
            ResultTextBox.Clear();
            TotalPoins.Clear();
            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                string number = rnd.Next(1, 6).ToString();
                DiceNumbers.Add(number);
                Controls.Find($"Dice{i + 1}", false)[0].Text = number;
            }

            int minRange = 0;
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    if (i <= 2) // search triples
                    {
                        if (DiceNumbers[i].Equals(DiceNumbers[i + 1]) && DiceNumbers[i + 1].Equals(DiceNumbers[i + 2]))
                        {
                            minRange = i;
                            ResultTextBox.AppendText($"\nTriple {DiceNumbers[i]} => {DicePoints[DiceNumbers[i]]}");
                            TotalPoins.Add(Convert.ToInt32(DicePoints[DiceNumbers[i]]));
                            for (int j = minRange + 3; j < 5; j++)
                            {
                                NonTriple(j);
                            }
                            break;
                        }
                    }
                    NonTriple(i);
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"{exception.Message}");
                }
            }

            ResultTextBox.AppendText($"\nTOTAL: {TotalPoins.Sum()}");
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab8
{
    public partial class Form1 : Form
    {
        Random rnd;
        string[] array8Ball = {"It is certain.", "Without a doubt.", "You may rely on it.", "Ask again later.", "Cannot predict now.", "Don’t count on it.", "My sources say no.", "Outlook not so good.", "Signs point to yes.", "Better not tell you now." };
        public Form1()
        {
            Random rnd = new Random();
            InitializeComponent();
        }

        private void buttonFlipCoin_Click(object sender, EventArgs e)
        {
            if (rnd == null) rnd = new Random();
            if(rnd.Next(2) < 1) pictureBoxCoin.Image = Properties.Resources.orel;
            else pictureBoxCoin.Image = Properties.Resources.reshka;
        }

        private void button8Ball_Click(object sender, EventArgs e)
        {
            if (rnd == null) rnd = new Random();
            label8Ball.Text = array8Ball[rnd.Next(10)];
        }

        private void buttonEvents_Click(object sender, EventArgs e)
        {
            int trial_number = (int)numericUpDownTrials.Value;
            double[] arrayProb = {(double)numericUpDown1.Value,
                (double)numericUpDown2.Value,
                (double)numericUpDown3.Value,
                (double)numericUpDown4.Value,
                0};
            double four = 0;
            foreach (double x in arrayProb)
            {
                four += x;
            }
            if (four > 1)
            {
                errorProviderEvents.SetError(this.numericUpDown5, "Sum of events greater than 1");
            }
            else
            {
                errorProviderEvents.SetError(this.numericUpDown5, String.Empty);
                arrayProb[4] = 1 - four;
                numericUpDown5.Value = (decimal)(1 - four);
                if (rnd == null) rnd = new Random();
                int numOfTrials = (int)numericUpDownTrials.Value;
                int[] arrayTrials = new int[5];
                for(int i = 0; i < numOfTrials; i++)
                {
                    double A = rnd.NextDouble();
                    int k = -1;
                    while(A > 0)
                    {
                        A -= arrayProb[++k];
                    }
                    arrayTrials[k]++;
                }
                Series series = new Series("Probabilities")
                {
                    ChartType = SeriesChartType.Column,
                    IsValueShownAsLabel = true
                };
                decimal d = 0;
                for (int i = 0; i < 5; i++)
                {
                    d = (decimal)arrayTrials[i] / numOfTrials;
                    series.Points.AddXY(i, Decimal.Truncate(d * 1000) / 1000);
                }
                chart1.Series.Clear();
                chart1.Series.Add(series);
            }
        }
    }
}

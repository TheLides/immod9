using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9
{
    public partial class Form1 : Form
    {
        public Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            List<double> probs = new List<double>() {
                (double) prob1.Value,
                (double) prob2.Value,
                (double) prob3.Value,
                (double) prob4.Value,
                (double) prob5.Value
            };
            int days = (int)daysNumeric.Value;
            if (probs[0] + probs[1] + probs[2] + probs[3] + probs[4] != 1)
            {
                MessageBox.Show("Probabilities summ should be equal to 1");
            }
            else
            {
                var ans = Count(days, probs);
                for (var i = 0; i < probs.Count; i++)
                {
                    chart1.Series[0].Points.AddXY(i + 1, ans[i]);
                }
                chart1.Series[0].IsValueShownAsLabel = true;
            }
            
        }

        private List<double> Count(int d, List<double> pr)
        {
            List<double> result = new List<double>() { 0, 0, 0, 0, 0};
            List<double> stat = new List<double>() { 0, 0, 0, 0, 0};
            for (var i = 0; i < d; i++)
            {
                var current = rnd.NextDouble();
                for (int j = 0; j < pr.Count; j++)
                {
                    current -= pr[j];
                    if (current < 0)
                    {
                        stat[j]++;
                        break;
                    }
                }
            } 
            
            for (var i = 0; i < result.Count; i++)
            {
                result[i] = (double) stat[i] / d;
            }
            return result;
        }
    }
}

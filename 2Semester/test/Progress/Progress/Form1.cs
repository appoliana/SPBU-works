using System;
using System.Windows.Forms;

namespace Progress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < 500)
            {
                progressBar.Value++;
            }
            else
            {
                TimewAfterBar.Enabled = true;
                TimewAfterBar.Start();
            }  
        }

        private void Start_Click(object sender, EventArgs e)
        {
            MainTimer.Enabled = true;
            MainTimer.Start();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TimerAfterBar_Tick(object sender, EventArgs e)
        {
            Close.Visible = true;
            TimewAfterBar.Stop();
        }
    }
}

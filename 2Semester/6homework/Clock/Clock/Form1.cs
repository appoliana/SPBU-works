using System;
using System.Threading;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {
        Thread secoundsCountingThread;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            secoundsCountingThread = new Thread(new ThreadStart(CountSeconds));
            secoundsCountingThread.Start();
        }
    }
}

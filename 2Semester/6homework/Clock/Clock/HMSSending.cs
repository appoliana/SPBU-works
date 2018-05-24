using System;
using System.Threading;
using System.Windows.Forms;

namespace Clock
{
    delegate void SendTime(string t);
    public partial class ClockForm : Form
    {
        private SendTime sendTime;
        private DateTime dateTime;
        private HoursMinutesSecounds hoursMinutesSecounds;
        private void CountSeconds()
        {
            sendTime = new SendTime(SendSeconds);

            while (true)
            {
                dateTime = DateTime.Now;

                hoursMinutesSecounds = new HoursMinutesSecounds(dateTime);
                SendSeconds($"{hoursMinutesSecounds.Hour}:{hoursMinutesSecounds.Minute}:{hoursMinutesSecounds.Secound}");
                Thread.Sleep(1000);
            }
        }

        public void SendSeconds(string text)
        {
            if (clockLabel.InvokeRequired)
            {
                Invoke(sendTime, new object[] { text });
            }
            else
            {
                clockLabel.Text = text;
            }
        }
    }
}

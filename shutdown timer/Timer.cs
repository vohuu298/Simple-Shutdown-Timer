using System;
using System.Windows.Forms;

namespace shutdown_timer
{
    public partial class Timer : Form
    {
        public Timer()
        {
            InitializeComponent();
        }

        string cmdText;
        int totalTime;
        int second = 0, minute = 0, hour = 0;
        int i;


        private void Timer_Load(object sender, EventArgs e)
        {

        }

        private void ckbCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbCustom.Checked)
            {
                radio15min.Enabled = false;
                radio30min.Enabled = false;
                radio60min.Enabled = false;
                radio45min.Enabled = false;
                txtHour.Enabled = true;
                txtMinute.Enabled = true;
                txtSecond.Enabled = true;
            }
            else
            {
                radio15min.Enabled = true;
                radio30min.Enabled = true;
                radio60min.Enabled = true;
                radio45min.Enabled = true;
                txtHour.Enabled = false;
                txtMinute.Enabled = false;
                txtSecond.Enabled = false;
            }
        }

        private void Timer_Load_1(object sender, EventArgs e)
        {
            radio30min.Checked = true;
            if (!ckbCustom.Checked)
            {
                txtHour.Enabled = false;
                txtMinute.Enabled = false;
                txtSecond.Enabled = false;
            }
        }

        private void radio15min_CheckedChanged(object sender, EventArgs e)
        {
            i = 15; //15 min
        }
        private void radio30min_CheckedChanged(object sender, EventArgs e)
        {
            i = 30; //30 min
        }
        private void radio45min_CheckedChanged(object sender, EventArgs e)
        {
            i = 45; //45 min
        }
        private void radio60min_CheckedChanged(object sender, EventArgs e)
        {
            i = 60; //60 min
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            cmdText = "/C shutdown -a";
            System.Diagnostics.Process.Start("CMD.exe", cmdText);

            //convert time
            int.TryParse(txtHour.Text, out hour);
            int.TryParse(txtMinute.Text, out minute);
            int.TryParse(txtSecond.Text, out second);

            //calculate time
            if (ckbCustom.Checked)
            {
                totalTime = hour * 3600 + minute * 60 + second * 1;
            }
            else
            {
                switch (i)
                {
                    case 15: totalTime = 15 * 60; break;
                    case 30: totalTime = 30 * 60; break;
                    case 45: totalTime = 45 * 60; break;
                    case 60: totalTime = 60 * 60; break;
                }
            }

            //shutdown command


            cmdText = "/C shutdown -s -t " + totalTime.ToString();
            System.Diagnostics.Process.Start("CMD.exe", cmdText);
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            cmdText = "/C shutdown -s -t 5";
            System.Diagnostics.Process.Start("CMD.exe", cmdText);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cmdText = "/C shutdown -a";
            System.Diagnostics.Process.Start("CMD.exe", cmdText);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
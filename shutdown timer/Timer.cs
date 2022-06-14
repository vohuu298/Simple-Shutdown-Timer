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

        string strCmdText;
        int totalSecond;
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
                txtHour.Enabled = true; txtMinute.Enabled = true; txtSecond.Enabled = true;
            }
            else
            {
                radio15min.Enabled = true;
                radio30min.Enabled = true;
                radio60min.Enabled = true;
                txtHour.Enabled = false;
                txtMinute.Enabled = false;
                txtSecond.Enabled = false;
            }
        }

        private void Timer_Load_1(object sender, EventArgs e)
        {
            radio30min.Checked = true;
            if (!ckbCustom.Checked)
            txtHour.Enabled = false; txtMinute.Enabled=false; txtSecond.Enabled=false;
        }

        private void radio15min_CheckedChanged(object sender, EventArgs e)
        {
            i = 15; //15 min
        }

        private void radio30min_CheckedChanged(object sender, EventArgs e)
        {
            i = 30; //30 min
        }

        private void radio60min_CheckedChanged(object sender, EventArgs e)
        {
            i = 60; //60 min
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            strCmdText = "/C shutdown -a";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            strCmdText = "/C shutdown -a";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);

            //convert time
            int.TryParse(txtHour.Text, out hour);
            int.TryParse(txtMinute.Text, out minute);
            int.TryParse(txtSecond.Text, out second);

            //calculate time
            if (ckbCustom.Checked)
            {
                totalSecond = hour * 3600 + minute * 60 + second * 1;
            }
            else
            {
                switch (i)
                {
                    case 15: totalSecond = 15 * 60; break;
                    case 30: totalSecond = 30 * 60; break;
                    case 60: totalSecond = 60 * 60; break;
                }
            }

            //shutdown command
            

            strCmdText = "/C shutdown -s -t " + totalSecond.ToString();
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
            this.Close();
        }
    }
}

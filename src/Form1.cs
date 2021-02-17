using DiscordRPC;
using DiscordRPC.Logging;
using DSharpPlus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discord_Utilities
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }


        public DiscordRpcClient client;
        bool fired = false;

        #region RPC       
        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (fired == false)
            {
                MessageBox.Show("Fire the Presence first!");
            }
            else
            {
                client.SetPresence(new DiscordRPC.RichPresence()
                {
                    Details = $"{details.Text}",
                    State = $"{slate.Text}",
                    Assets = new Assets()
                    {
                        LargeImageKey = $"{lik.Text}",
                        SmallImageKey = $"{smik.Text}",
                        LargeImageText = $"{lit.Text}",
                        SmallImageText = $"{sit.Text}"
                    }
                });
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (apid.Text == string.Empty)
            {
                MessageBox.Show("APPID NEEDED!");
            }
            fired = true;
            client = new DiscordRpcClient($"{apid.Text}");
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
            client.Initialize();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            delab.Text = details.Text;
            stlab.Text = slate.Text;
        }

#endregion

        #region Spammer

        private void metroRadioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void spam_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (metroRadioButton1.Checked)
            {
                timer1.Interval = 1;
            }
            if (metroRadioButton2.Checked)
            {
                timer1.Interval = 10;
            }
            if (metroRadioButton3.Checked)
            {
                timer1.Interval = 50;
            }
            if (metroRadioButton4.Checked)
            {
                timer1.Interval = 70;
            }
            if (metroRadioButton5.Checked)
            {
                timer1.Interval = 100;
            }
            if (metroRadioButton6.Checked)
            {
                timer1.Interval = 200;
            }
            if (metroRadioButton7.Checked)
            {
                timer1.Interval = 500;
            }
            if (metroRadioButton8.Checked)
            {
                timer1.Interval = 800;
            }
            if (metroRadioButton9.Checked)
            {
                timer1.Interval = 1000;
            }
            SendKeys.Send(cont.Text);
            SendKeys.Send("{Enter}");
        }

        #endregion

        #region Notify

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }
        private void form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);
            }
        }
        #endregion

        #region About
        private void metroLabel23_Click(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            Process.Start("https://mehmetali345.xyz");
        }
        #endregion

    }
}

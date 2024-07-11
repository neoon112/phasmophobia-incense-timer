using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Security.Permissions;
using System.Net.Http.Headers;

namespace Smudge_Timer
{

    public partial class Form1 : Form
    {
        private KeyHandler ghk;
        private KeyHandler ghk2;
        private KeyHandler ghk3;

        public enum DWMWINDOWATTRIBUTE
        {
            DWMWA_WINDOW_CORNER_PREFERENCE = 33
        }

        public enum DWM_WINDOW_CORNER_PREFERENCE
        {
            DWMWCP_DEFAULT = 0,
            DWMWCP_DONOTROUND = 1,
            DWMWCP_ROUND = 2,
            DWMWCP_ROUNDSMALL = 3
        }

        [DllImport("dwmapi.dll", CharSet = CharSet.Unicode, PreserveSig = false)]
        internal static extern void DwmSetWindowAttribute(IntPtr hwnd,
                                                         DWMWINDOWATTRIBUTE attribute,
                                                         ref DWM_WINDOW_CORNER_PREFERENCE pvAttribute,
                                                         uint cbAttribute);

        int timeSecond, timeMinute;
        double timeMillisecond;

        bool timerActive;

        private void button1_Click(object sender, EventArgs e)
        {
            timerActive = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timerActive = false;
        }

        private void ResetTime()
        {
            timeSecond = 0;
            timeMinute = 0;
            timeMillisecond = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timerActive == true)
            {
                timeMillisecond = timeMillisecond + 1.55;

                if(timeMillisecond > 99)
                {
                    timeMillisecond = 0;
                    timeSecond++;

                    if(timeSecond >= 60)
                    {
                        timeMinute++;
                        timeSecond = 0;

                    }
                }
            }
            if (clockLayout == false)
            {
                DrawTime();
            }
        }

        private void DrawTime()
        {
            lblSeconds.Text = String.Format("{0:00}", timeSecond);
            lblMinutes.Text = String.Format("{0:00}", timeMinute);
            lblMs.Text = String.Format("{0:00}", timeMillisecond);
        }

        public static class Constants
        {
            public const int WM_HOTKEY_MSG_ID = 0x0312;
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Constants.WM_HOTKEY_MSG_ID)
            {
                if (clockLayout == false)
                {
                    if (m.WParam.ToString() == ghk.GetHashCode().ToString())
                    {
                        timerActive = true;
                    }
                    if (m.WParam.ToString() == ghk2.GetHashCode().ToString())
                    {
                        timerActive = false;
                    }
                    if (m.WParam.ToString() == ghk3.GetHashCode().ToString())
                    {
                        ResetTime();
                        timerActive = false;
                    }
                }
                else if (clockLayout == true)
                {
                    if (m.WParam.ToString() == ghk.GetHashCode().ToString())
                    {
                        ResetTime();
                        smudgedatLbl.Text = "Smudged At: " + DateTime.Now.ToString("mm") + "m" + DateTime.Now.ToString("ss") + "s";
                        timerActive = true;
                    }
                    if (m.WParam.ToString() == ghk3.GetHashCode().ToString())
                    {
                        smudgedatLbl.Text = "Smudged At: 00m:00s";
                        ResetTime();
                        timerActive = false;
                    }
                }
            }

            base.WndProc(ref m);
        }



        public Form1()
        {
            InitializeComponent();


            // add detection for shortcut keys
            ghk = new KeyHandler(Keys.F6, this);
            ghk.Register();

            ghk2 = new KeyHandler(Keys.F7, this);
            ghk2.Register();

            ghk3 = new KeyHandler(Keys.F8, this);
            ghk3.Register();

            var attribute = DWMWINDOWATTRIBUTE.DWMWA_WINDOW_CORNER_PREFERENCE;
            var preference = DWM_WINDOW_CORNER_PREFERENCE.DWMWCP_ROUND;
            DwmSetWindowAttribute(this.Handle, attribute, ref preference, sizeof(uint));
            // ---------------

            RegistryKey topmostkey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Incense Timer"); //topmost key
            if (topmostkey.GetValue("Topmost") == null)
            {
                topmostkey.SetValue("Topmost", "false");
                topmostkey.Close();
                topMost = false;
            }
            else
            {
                if (topmostkey.GetValue("Topmost").ToString() == "true")
                {
                    this.TopMost = true;
                    topMost = true;
                }
                else
                {
                    this.TopMost = false;
                    topMost = false;
                }
                topmostkey.Close();
            }

            RegistryKey clocklayoutKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Incense Timer"); //smudged at label key

            if (clocklayoutKey.GetValue("ClockLayout") == null)
            {
                clocklayoutKey.SetValue("ClockLayout", "false");
                clocklayoutKey.Close();
                clockLayout = false;
            }
            else
            {
                if (clocklayoutKey.GetValue("ClockLayout").ToString() == "true")
                {
                    clockLayout = true;
                }
                else
                {
                    clockLayout = false;
                }
                clocklayoutKey.Close();
            }

            lblMs.Visible = false;
            label2.Visible = false;
            lblSeconds.Visible = false;
            lblMinutes.Visible = false;
            colon.Visible = false;
            minutesLbl.Visible = false;
            labelSeconds.Visible = false;
            Colon2.Visible = false;
            smudgedButton.Visible = false;
            resetButton2.Visible = false;
            smudgedatLbl.Visible = false;
            button1.Visible = false;
            button4.Visible = false;
            button3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResetTime();
            timerActive = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F6)
            {
                timerActive = true;
            }
            else if (e.KeyCode == Keys.F7)
            {
                timerActive = false;
            }
            else if (e.KeyCode == Keys.F8)
            {
                timerActive = false;
                ResetTime();
            }
        }

        private void labalTimers_Tick(object sender, EventArgs e)
        {
            if (clockLayout == true)
            {
                minutesLbl.Text = DateTime.Now.ToString("mm") + "m";
                labelSeconds.Text = DateTime.Now.ToString("ss") + "s";
            }
            if (timeMinute > 0)
            {
                lblDemonGreen.Visible = true;
                lblDemonRed.Visible = false;
            }
            else
            {
                lblDemonRed.Visible = true;
                lblDemonGreen.Visible = false;
            }
            if (timeMinute > 2)
            {
                lblSpiritGreen.Visible = true;
                lblSpiritRed.Visible = false;
            }
            else
            {
                lblSpiritRed.Visible = true;
                lblSpiritGreen.Visible = false;
            }
            if (timeMinute > 0 && timeSecond > 29 || timeMinute > 1)
            {
                lblRegularGreen.Visible = true;
                lblRegularRed.Visible = false;
            }
            else
            {
                lblRegularRed.Visible = true;
                lblRegularGreen.Visible = false;
            }
            if (clockLayout == false)
            {
                if (timerActive == true)
                {
                    button3.Visible = true;
                    button1.Visible = false;
                }
                else
                {
                    button3.Visible = false;
                    button1.Visible = true;
                }
            }
        }
        Point lastPoint;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ad_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://scratch.mit.edu/projects/992603556/");
        }

        private void questionLbl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Once ghosts have been smudged will take some time before they can hunt again.\n\nDemon: 60 Seconds\nRegular Ghost: 90 Seconds\nSpirit: 180 Seconds", "Smudged Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        public static bool settingsMenu;
        public static bool topMost;
        public static bool clockLayout;

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            retry:
            if (settingsMenu == false)
            {
                settingsMenu = true;
                Settings settingsmenuUI = new Settings();
                settingsmenuUI.Show();
            }
            else if (settingsMenu == true)
            {
                DialogResult dialog = MessageBox.Show("Settings Menu is already open.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (dialog == DialogResult.Retry)
                {
                    goto retry;
                }
                else if (dialog == DialogResult.Cancel)
                {
                    return;
                }
            }
        }

        private void topmosttimer_Tick(object sender, EventArgs e)
        {

            if (topMost == true)
            {
                if (this.TopMost == false)
                {
                    this.TopMost = true;
                }
            }
            else if (topMost == false)
            {
                if (this.TopMost == true)
                {
                    this.TopMost = false;
                }
            }

            if (clockLayout == true)
            {
                if (minutesLbl.Visible == false)
                {
                    ResetTime();
                    timerActive = false;
                    minutesLbl.Visible = true; // show clock layout
                    labelSeconds.Visible = true;
                    Colon2.Visible = true;
                    smudgedButton.Visible = true;
                    resetButton2.Visible = true;
                    smudgedatLbl.Visible = true;

                    lblMs.Visible = false; // hide stopwatch layout
                    label2.Visible = false;
                    lblSeconds.Visible = false;
                    lblMinutes.Visible = false;
                    colon.Visible = false;
                    button1.Visible = false;
                    button4.Visible = false;
                    button3.Visible = false;
                }
            }
            else
            {
                if (lblMs.Visible == false)
                {
                    ResetTime();
                    timerActive = false;
                    minutesLbl.Visible = false; // hide clock layout
                    labelSeconds.Visible = false;
                    Colon2.Visible = false;
                    smudgedButton.Visible = false;
                    resetButton2.Visible = false;
                    smudgedatLbl.Visible = false;

                    lblMs.Visible = true; // show stopwatch layout
                    label2.Visible = true;
                    lblSeconds.Visible = true;
                    lblMinutes.Visible = true;
                    colon.Visible = true;
                    button1.Visible = true;
                    button4.Visible = true;
                    button3.Visible= true;
                }
            }
        }

        private void smudgedButton_Click(object sender, EventArgs e)
        {
            ResetTime();
            smudgedatLbl.Text = "Smudged At: " + DateTime.Now.ToString("mm") + "m" + DateTime.Now.ToString("ss") + "s";
            timerActive = true;
            for (int i = 0; i < 4; i++)
            {
                timeSecond--;
            }
        }

        private void resetButton2_Click(object sender, EventArgs e)
        {
            smudgedatLbl.Text = "Smudged At: 00m:00s";
            ResetTime();
            timerActive = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetTime();
            timerActive = false;
            settingsMenu = false;
        }
    }
}

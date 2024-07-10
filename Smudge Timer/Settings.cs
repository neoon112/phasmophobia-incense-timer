using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smudge_Timer
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

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

        private void Settings_Load(object sender, EventArgs e)
        {
            var attribute = DWMWINDOWATTRIBUTE.DWMWA_WINDOW_CORNER_PREFERENCE;
            var preference = DWM_WINDOW_CORNER_PREFERENCE.DWMWCP_ROUND;
            DwmSetWindowAttribute(this.Handle, attribute, ref preference, sizeof(uint));
           
            checkBox2.Checked = true; // make scratchamophobia checkbox checked on load

            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Incense Timer"); // check topmost box
            if (key.GetValue("Topmost").ToString() == "true")
            {
                this.TopMost = true;
                topMostBox.Checked = true;
            }
            else
            {
                this.TopMost = false;
                topMostBox.Checked = false;
            }
            key.Close();


            RegistryKey key2 = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Incense Timer"); // check clock layout box
            if (key2.GetValue("ClockLayout").ToString() == "true")
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
            key2.Close();
        }

        private void topMostBox_CheckedChanged(object sender, EventArgs e)
        {
            RegistryKey topmostkey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Incense Timer");
            if (topMostBox.Checked == true)
            {
                this.TopMost = true;
                topmostkey.SetValue("Topmost", "true");
                Form1.topMost = true;
            }
            else
            {
                this.TopMost = false;
                topmostkey.SetValue("Topmost", "false");
                Form1.topMost = false;
            }
            topmostkey.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.settingsMenu = false;
            this.Close();
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

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
            {
                MessageBox.Show("No. Getting. Rid. Of. Scratchamophobia.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            checkBox2.Checked = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            RegistryKey clockLayoutkey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Incense Timer");

            if (checkBox1.Checked == true)
            {
                clockLayoutkey.SetValue("ClockLayout", "true");
                Form1.clockLayout = true;
            }
            else
            {
                clockLayoutkey.SetValue("ClockLayout", "false");
                Form1.clockLayout = false;
            }
            clockLayoutkey.Close();
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;

namespace ScreenBlindfold
{
    public partial class MainForm : Form
    {
        private bool BlindfoldEnabled = false;
        private BlindfoldForm blindfold;

        public MainForm()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.MonitorIcon;
            notifyIconMain.Icon = Properties.Resources.MonitorIcon;
            toggleToolStripMenuItem.Font = new Font(toggleToolStripMenuItem.Font, toggleToolStripMenuItem.Font.Style | FontStyle.Bold);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            // Restore previous state
            if (Properties.Settings.Default.MinimizedToTray)
            {
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
            }
            if (Properties.Settings.Default.BlindfoldEnabled)
            {
                EnableBlindfold();
            }
        }

        private void EnableBlindfold()
        {
            Properties.Settings.Default.BlindfoldEnabled = true;
            Properties.Settings.Default.Save();
            blindfold = new BlindfoldForm(0);
            blindfold.Show();
            toggleButton.BackColor = Color.DarkOliveGreen;
            toggleButton.Text = "ScreenBlindfold Enabled";
            this.Icon = Properties.Resources.MonitorEyeCrossIcon;
            notifyIconMain.Icon = Properties.Resources.MonitorEyeCrossIcon;
            instructionsLabel.Text = "Click the button to disable.";
            toggleToolStripMenuItem.Text = "Disable ScreenBlindfold";
            BlindfoldEnabled = true;
        }

        private void DisableBlindfold()
        {
            Properties.Settings.Default.BlindfoldEnabled = false;
            Properties.Settings.Default.Save();
            blindfold.Dispose();
            toggleButton.BackColor = Color.Red;
            toggleButton.Text = "ScreenBlindfold Disabled";
            this.Icon = Properties.Resources.MonitorIcon;
            notifyIconMain.Icon = Properties.Resources.MonitorIcon;
            instructionsLabel.Text = "Click the button to enable.";
            toggleToolStripMenuItem.Text = "Enable ScreenBlindfold";
            BlindfoldEnabled = false;
        }

        private void ToggleFunction()
        {
            if (BlindfoldEnabled == false)
            {
                EnableBlindfold();
                this.Activate();
                this.Focus();
            }
            else
            {
                DisableBlindfold();
            }
        }

        private void toggleButton_Click(object sender, EventArgs e)
        {
            ToggleFunction();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ScreenBlindfold\r\nVersion 1.0.0\r\nA utility to protect your screen from screen recording.\r\n\r\nCopyright © 2022-2023 Félix An\r\nLicensed under the MIT License", "About ScreenBlindfold", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Minimize to system tray
        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Properties.Settings.Default.MinimizedToTray = true;
                Properties.Settings.Default.Save();
                notifyIconMain.Visible = true;
                notifyIconMain.ShowBalloonTip(500);
                this.Hide();
            }

            else if (this.WindowState == FormWindowState.Normal || this.WindowState == FormWindowState.Maximized)
            {
                notifyIconMain.Visible = false;
            }
        }

        private void toggleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleFunction();
        }

        private void Restore()
        {
            Properties.Settings.Default.MinimizedToTray = false;
            Properties.Settings.Default.Save();
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.BringToFront();
            this.Activate();
            this.Focus();
        }

        private void notifyIconMain_DoubleClick(object sender, EventArgs e)
        {
            Restore();
        }

        private void showWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restore();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

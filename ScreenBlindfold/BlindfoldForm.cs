using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ScreenBlindfold
{
    public partial class BlindfoldForm : Form
    {
        // Adapted from https://stackoverflow.com/questions/11077236/transparent-window-layer-that-is-click-through-and-always-stays-on-top

        // The screens are a chain of forms like a linked list.
        // Don't try hiding the first form. Just dispose of it and make a new one.
        public int ScreenNumber;
        public BlindfoldForm NextForm;

        // Unmanaged code imports
        [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
        public static extern int GetWindowLong(IntPtr hWnd, GWL nIndex);

        [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
        public static extern int SetWindowLong(IntPtr hWnd, GWL nIndex, int dwNewLong);

        [DllImport("user32.dll", EntryPoint = "SetLayeredWindowAttributes")]
        public static extern bool SetLayeredWindowAttributes(IntPtr hWnd, int crKey, byte alpha, LWA dwFlags);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool SetWindowDisplayAffinity(IntPtr hwnd, uint affinity);

        public BlindfoldForm(int screenNum)
        {
            ScreenNumber = screenNum;
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            if (NextForm != null)
                NextForm.Dispose();
            base.Dispose(disposing);
        }

        void ShowOnScreen(int screenNumber)
        {
            Screen[] screens = Screen.AllScreens;

            if (screenNumber >= 0 && screenNumber < screens.Length)
            {
                bool maximised = false;
                if (WindowState == FormWindowState.Maximized)
                {
                    WindowState = FormWindowState.Normal;
                    maximised = true;
                }
                Location = screens[screenNumber].WorkingArea.Location;
                if (maximised)
                {
                    WindowState = FormWindowState.Maximized;
                }
            }
        }

        private void BlindfoldForm_Load(object sender, EventArgs e)
        {
            base.OnShown(e);
            int wl = GetWindowLong(this.Handle, GWL.ExStyle);
            wl = wl | 0x80000 | 0x20;
            SetWindowLong(this.Handle, GWL.ExStyle, wl);
            //SetLayeredWindowAttributes(this.Handle, 0, 1, LWA.Alpha);
            ShowOnScreen(ScreenNumber);
            // this.Size = new Size(Screen.FromControl(this).Bounds.Width, Screen.FromControl(this).Bounds.Height);
            if (ScreenNumber != Screen.AllScreens.Length - 1)
            {
                NextForm = new BlindfoldForm(ScreenNumber + 1);
                NextForm.Show();
            }
        }

        // Prevent user from closing from by accident
        private void BlindfoldForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        public enum GWL
        {
            ExStyle = -20
        }

        public enum WS_EX
        {
            Transparent = 0x20,
            Layered = 0x80000
        }

        public enum LWA
        {
            ColorKey = 0x1,
            Alpha = 0x2
        }

        protected override void OnShown(EventArgs e)
        {
            // const uint WDA_NONE = 0;
            const uint WDA_MONITOR = 1;
            bool s = SetWindowDisplayAffinity(this.Handle, WDA_MONITOR);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_EX_TOOLWINDOW = 0x00000080;
                var Params = base.CreateParams;
                Params.ExStyle |= WS_EX_TOOLWINDOW;
                return Params;
            }
        }
    }
}

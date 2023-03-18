using System;
using System.Threading;
using System.Windows.Forms;

namespace ScreenBlindfold
{
    static class Program
    {
        static System.Threading.Mutex singleton = new Mutex(true, "FelixAnScreenBlindfold");

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!singleton.WaitOne(TimeSpan.Zero, true))
            {
                // There is already another instance running!
                Environment.Exit(0);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}

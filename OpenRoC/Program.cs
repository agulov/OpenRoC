﻿namespace oroc
{
    using System;
    using System.IO;
    using System.Threading;
    using System.Reflection;
    using System.Windows.Forms;

    static class Program
    {
        [STAThread]
        static int Main()
        {
            if (Environment.OSVersion.Version.Major <= 6)
            SetProcessDPIAware();

            if (Settings.Instance.IsSingleInsntaceEnabled)
            {
                bool only_instance;
                using (Mutex applock = new Mutex(true, Properties.Resources.OpenRoCMutexName, out only_instance))
                {
                    if (!only_instance)
                    {
                        MessageBox.Show(
                            "Another OpenRoC instance is already open.",
                            "Multiple instances detected!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        return 1;
                    }
                    else
                    {
                        Launch();
                    }
                }
            }
            else
            {
                Launch();
            }

            Settings.Instance.Save();
            return 0;
        }

        private static void Launch()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainDialog());
        }

        public static string Directory
        {
            get { return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location); }
        }

        public static string ScreenShotDirectory
        {
            get { return Path.Combine(Directory, ".ScreenShots"); }
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}

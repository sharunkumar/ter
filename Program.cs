using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace terminal
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Diagnostics.Process.Start("wt.exe", "-d .");
        }
    }
}

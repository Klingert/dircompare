using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MainProject
{
    public static class Program
    { 
        internal static MainForm mainForm;

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            mainForm = new MainForm(args);
            Application.Run(mainForm);
        }
    }
}

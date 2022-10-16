using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace crm_system
{
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new crm_system.Forms.Main_Form());
        }
    }
}

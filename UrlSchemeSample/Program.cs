using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrlSchemeSample
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var args = "";
            if (Environment.GetCommandLineArgs().Length > 1)
                args = Environment.GetCommandLineArgs()[1];
            MessageBox.Show($"You can decide what to do with the arguments:\n{args}");
            Application.Run(new Form1());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notatnik
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] arg)
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (arg != null && arg.Length >= 1 && (arg[0] == "\\?" || arg[0] == "?"))
            {
                Application.Run(new OknoPomoc());
            }
            else 
                Application.Run(new OknoNotatnik(arg));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwelveDaysOfChristmasWF
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// Author: Aaron Ehrlich
        /// Date: Jan 29 2017
        /// Icon Source: http://www.iconarchive.com/show/simple-christmas-icons-by-gpritiranjan/christmas-tree-icon.html
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());
        }
    }
}

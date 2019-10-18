using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_HW
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
            //Application.Run(new Task1MainForm());
            //Application.Run(new Task2MainForm());
           Application.Run(new Task3MainForm());
            //Application.Run(new Task4MainForm());
            //Application.Run(new Task5MainForm());
            //Application.Run(new Task6MainForm());
        }
    }
}

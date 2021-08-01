using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace برنامج_المحامي_العربي
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
            Application.Run(new Form36());
            Form6 dd = new Form6();
            Application.Run(dd);

            if (dd.Bo)
            {
                Application.Run(new Form1());
            }
        }


    }
}
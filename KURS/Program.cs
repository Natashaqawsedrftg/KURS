using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace KURS
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //ConsoleClient.ServerClient s = new ConsoleClient.ServerClient();
        }
    }
}

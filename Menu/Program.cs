using System;
using System.Windows.Forms;

namespace Spartak_Project
{
    static class Program
    {
        public static Spartak_ProjectEntities1 Spartak_Project = new Spartak_ProjectEntities1();
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormAuthorization());
        }
    }
}

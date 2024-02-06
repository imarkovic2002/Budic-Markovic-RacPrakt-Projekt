using System;
using System.Windows.Forms;

namespace Budić_Marković_RacPrakt_Projekt
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*
            using (Main main=new Main())
            {
                if(main.ShowDialog() == DialogResult.OK)
                {
                    LoginForm loginForm = new LoginForm();
                    if (loginForm.ShowDialog() == DialogResult.OK)
                    {
                        Application.Run(new DjelatnikForm(loginForm.djelatnik));
                    }
                }
            }
            */

            // Novo
            using (LoginForm loginForm = new LoginForm())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new DjelatnikForm(loginForm.djelatnik));
                }
            }
        }
    }
}

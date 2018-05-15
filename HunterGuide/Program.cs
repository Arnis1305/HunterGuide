using HunterGuide.Singletons;
using HunterGuide.Forms;
using System;
using System.Windows.Forms;

namespace HunterGuide
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            try 
            {
                ContextProvider.GetApplicationContext();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new LoginForm());
            }
            finally 
            {
                ContextProvider.Dispose();
            }
        }
    }
}

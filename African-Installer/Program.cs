using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace African_Installer
{
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// By разогнанный#9036                                                                                                     ///
    /// You have full rights to use my source code provided that I am mentioned on your application and your app must be free and open source.
    /// This app is open source to help you easily, create your own stand theme installer. DM Me for get source or use DNSPY.   ///
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ///By разогнанный#9036  
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
            Application.Run(new InstallThemeForm());
        }
    }
}

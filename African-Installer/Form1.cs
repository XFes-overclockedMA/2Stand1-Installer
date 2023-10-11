using African_Installer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/// By разогнанный#9036                                                                                                     ///
/// You have full rights to use my source code provided that I am mentioned on your application and your app must be free and open source.
/// This app is open source to help you easily, create your own stand theme installer. DM Me for get source or use DNSPY.   ///
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                                                                                                        ///By разогнанный#9036  


namespace African_Installer
{
    public partial class InstallThemeForm : Form
    {
        public static InstallThemeForm InstallThemeFormInstance;
        public InstallThemeForm()
        {
            InitializeComponent();
            InstallThemeFormInstance = this;
        }

        ///////////////////////////////////////////////////////////////////////////////////////
        //// CLOSE APP 
        private void CloseBTN_Click(object sender, EventArgs e) //// EVENT CloseBTN Click
        {
            Application.Exit(); /// Close APP
        }
        ///////////////////////////////////////////////////////////////////////////////////////
        //// INSTALL THEME BTN
        private void InstallBTN_Click(object sender, EventArgs e)//// EVENT InstallBTN Click
        {
            SimpleAsyncThread.RunWorkerAsync();/////Start Async Task
        }
        ///////////////////////////////////////////////////////////////////////////////////////
        //// ASYNC TASK THREAD LOAD
        private void SimpleAsyncThread_DoWork(object sender, DoWorkEventArgs e)
        {
            install ins = new install(); //// New Instance
            ins.installthemelua(); ///// Load public void installtheme in install.cs
            ins.installxfeslib(); ///// Load public void installxfeslib in install.cs
            //// Double Click in installtheme or installxfeslib for look function in install.cs
        }
        ///////////////////////////////////////////////////////////////////////////////////////
        //// ASYNC TASK THREAD COMPLETED
        private void SimpleAsyncThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Settings.Default["ThemeVersion"] = LatestVersionLabel.Text; // String ThemeVersion = latest version  theme
            Settings.Default.Save(); // Save string themeversion
            YourVersionLabel.Text = LatestVersionLabel.Text; // Your version label = latest version

            MessageBox.Show("Finish.");  //// Message box show for finish task
        }
        ///////////////////////////////////////////////////////////////////////////////////////
        //// OPEN SOURCE LABEL CLICK
        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have full rights to use my source code provided that I am mentioned on your application and your app must be free and open source."); // MessageBox 1
            MessageBox.Show("This app is open source to help you easily, create your own stand theme installer. DM Me for get source or use DNSPY."); // MessageBox 2
        }
        ///////////////////////////////////////////////////////////////////////////////////////
        //// APPLICATION FIRST LOAD
        private void InstallThemeForm_Load(object sender, EventArgs e)
        {
            
          getupdate getupd = new getupdate(); // Instance getupdate.cs
          getupd.getversiontheme(); // Load getversiontheme to getupdate.cs
          YourVersionLabel.Text = Settings.Default["ThemeVersion"].ToString(); // Your version = string theme version

        }
    }
}
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/// By разогнанный#9036                                                                                                     ///
/// You have full rights to use my source code provided that I am mentioned on your application and your app must be free and open source.
/// This app is open source to help you easily, create your own stand theme installer. DM Me for get source or use DNSPY.   ///
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///By разогнанный#9036  
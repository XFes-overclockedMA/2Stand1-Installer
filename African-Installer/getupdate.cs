using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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
    internal class getupdate
    {
        ///////////////////////////////////////////////////////////////////////////////////////
        ////  URL STRING
        public string getversionURL = "https://gist.github.com/XFes-overclockedMA/5c2f61d85894c79cf13f15ee3a657937/raw/versionafrican"; // String version theme
        public string getUrlua = "https://gist.github.com/XFes-overclockedMA/4dc1d066806de7e204ae8ef5a1f74ae2/raw/DownloadLuaURL"; // String download lua theme
        public string getUrlxfeslib = "https://gist.github.com/XFes-overclockedMA/54f96f28fbf87c230be9deab5f895aec/raw/xfeslibafrican"; // String download xfeslib theme
        ///////////////////////////////////////////////////////////////////////////////////////
        ////  URL DOWNLOAD LUA
        public string getdownloadlua() //Get URL download LUA
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(getUrlua); // Http request create getUrlua
                HttpWebResponse response = (HttpWebResponse)request.GetResponse(); // http response for getUrlua
                StreamReader sr = new StreamReader(response.GetResponseStream()); // Read in getUrlua
                var viewKEY = sr.ReadToEnd(); // var Text URL Lua
                return viewKEY;
            }
            catch
            {
                InstallThemeForm.InstallThemeFormInstance.LatestVersionLabel.Text = "server off"; // Set label text "server off" if server off
                return ""; // or any appropriate default value in case of an error
            }
        }
        ///////////////////////////////////////////////////////////////////////////////////////
        ////  URL DOWNLOAD XFES LIB THEME
        public string getdownloadxfeslib() //Get URL download XFESLIB
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(getUrlxfeslib); // Http request create getUrlxfeslib
                HttpWebResponse response = (HttpWebResponse)request.GetResponse(); // http response for getUrlxfeslib
                StreamReader sr = new StreamReader(response.GetResponseStream()); // Read in getUrlxfeslib
                var viewKEY = sr.ReadToEnd(); // var Text URL XFES Lib
                return viewKEY;
            }
            catch
            {
                InstallThemeForm.InstallThemeFormInstance.LatestVersionLabel.Text = "server off"; // Set label text "server off" if server off
                return ""; // or any appropriate default value in case of an error
            }

        }
        ///////////////////////////////////////////////////////////////////////////////////////
        //// URL GET VERSION
        public string getversiontheme() // Get Version Theme
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(getversionURL); // Http request create getversionURL
                HttpWebResponse response = (HttpWebResponse)request.GetResponse(); // http response for getversionURL
                StreamReader sr = new StreamReader(response.GetResponseStream()); // Read in getversionURL
                var viewKEY = sr.ReadToEnd();
                InstallThemeForm.InstallThemeFormInstance.LatestVersionLabel.Text = viewKEY; // set label text = latest version
                return viewKEY;
            }
            catch
            {             
                InstallThemeForm.InstallThemeFormInstance.LatestVersionLabel.Text = "server off"; // Set label text "server off" if server off
                return ""; // or any appropriate default value in case of an error
            }
        }
    }
}

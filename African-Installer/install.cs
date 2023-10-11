using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.Net.NetworkInformation;
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/// By разогнанный#9036                                                                                                     ///
/// You have full rights to use my source code provided that I am mentioned on your application and your app must be free and open source.
/// This app is open source to help you easily, create your own stand theme installer. DM Me for get source or use DNSPY.   ///
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///By разогнанный#9036  

namespace African_Installer
{
    internal class install
    {

        
        ///////////////////////////////////////////////////////////////////////////////////////
        //// INSTALL THEME LUA
        public void installthemelua() 
        {
            getupdate getupd = new getupdate();

            // String Get Directory XFES Lua
            string xfeslua;
            xfeslua = @"%APPDATA%\Stand\Lua Scripts\#XFes-Theme-Lua";
            xfeslua = Environment.ExpandEnvironmentVariables(xfeslua);
            if (Directory.Exists(xfeslua)) ///// If xfeslua exist
            {
              
                // Create WebClient Instance
                WebClient webClient = new WebClient();

                // Download FILE
                webClient.DownloadFile(getupd.getdownloadlua(), xfeslua + "\\JTAG-RGH_AfricanEngine.pluto");
            }
            else ///// Else = xfeslua no exist
            {
                // Create Directory xfeslua
                Directory.CreateDirectory(xfeslua);

           
                // Create WebClient Instance
                WebClient webClient = new WebClient();

                // Download FILE
                webClient.DownloadFile(getupd.getdownloadlua(), xfeslua + "\\JTAG-RGH_AfricanEngine.pluto");
            }
        }
        ///////////////////////////////////////////////////////////////////////////////////////
        //// INSTALL XFES LIB
        public void installxfeslib()
        {
            getupdate getupd = new getupdate();
          
                // String Get XFES Library
                string xfeslib;
                xfeslib = @"%APPDATA%\Stand\Lua Scripts\resources\#xfes-lib-theme";
                xfeslib = Environment.ExpandEnvironmentVariables(xfeslib);
                if (Directory.Exists(xfeslib)) // IF xfeslib exists
                 {
                    
                   
                    DownloadFile(getupd.getdownloadxfeslib(), xfeslib + "\\africanengine.zip"); //Start Download
                    string zipFilePath = xfeslib + "\\africanengine.zip"; // Repertory zip output
                    string extractPath = xfeslib; // Repertory extract zip output
                 
                using (ZipArchive archive = ZipFile.OpenRead(zipFilePath)) // Using Zip Archive Extention and read zipFilePath
                {
                        foreach (ZipArchiveEntry entry in archive.Entries)
                        {
                            // Skip directories (if any)
                            if (string.IsNullOrEmpty(entry.Name))
                            {
                                continue;
                            }

                            string entryPath = Path.Combine(extractPath, entry.FullName);
                            string entryDirectory = Path.GetDirectoryName(entryPath);

                            // Create the directory if it doesn't exist
                            if (!Directory.Exists(entryDirectory))
                            {
                                Directory.CreateDirectory(entryDirectory);
                            }

                            entry.ExtractToFile(entryPath, true);
                        }
                    }

                    // Delete the ZIP file
                    File.Delete(zipFilePath);
                }
            else // Else = xfeslib no exists
            {
                // String Resources path in lua script stand
                string resourcesStand;
                    resourcesStand = @"%APPDATA%\Stand\Lua Scripts\resources";
                    resourcesStand = Environment.ExpandEnvironmentVariables(resourcesStand);
                  
                if (Directory.Exists(resourcesStand)) /// If resourcesStand Exists
                    {
                        Directory.CreateDirectory(xfeslib);

                    //Download xfeslib url
                    string urlib = "https://cdn.discordapp.com/attachments/1161490822919884880/1161498336344420402/africanengine.zip?ex=6538849e&is=65260f9e&hm=2384ffb92c88934e72c096999a2027a11ad7bad0b04a8e890e0efc2ef1326d08&africanengine.zip";
                    DownloadFile(urlib, xfeslib + "\\africanengine.zip"); //Start Download
                    string zipFilePath = xfeslib + "\\africanengine.zip"; // Repertory zip output
                    string extractPath = xfeslib; // Repertory extract zip output


                    using (ZipArchive archive = ZipFile.OpenRead(zipFilePath)) /// Using Zip Archive Extention and read zipFilePath
                        {
                            foreach (ZipArchiveEntry entry in archive.Entries)
                            {
                                // Skip directories (if any)
                                if (string.IsNullOrEmpty(entry.Name))
                                {
                                    continue;
                                }

                                string entryPath = Path.Combine(extractPath, entry.FullName);
                                string entryDirectory = Path.GetDirectoryName(entryPath);

                                // Create the directory if it doesn't exist
                                if (!Directory.Exists(entryDirectory))
                                {
                                    Directory.CreateDirectory(entryDirectory);
                                }

                                entry.ExtractToFile(entryPath, true);
                            }
                        }
                        // Delete the ZIP file
                        File.Delete(zipFilePath);
                    }
                    else /// Else = resourcesStand no Exists
                {
                    Directory.CreateDirectory(resourcesStand);
                     Directory.CreateDirectory(xfeslib);
                    //Download xfeslib url
                    string urlib = "https://cdn.discordapp.com/attachments/1161490822919884880/1161498336344420402/africanengine.zip?ex=6538849e&is=65260f9e&hm=2384ffb92c88934e72c096999a2027a11ad7bad0b04a8e890e0efc2ef1326d08&africanengine.zip";
                    DownloadFile(urlib, xfeslib + "\\africanengine.zip"); //Start Download
                    string zipFilePath = xfeslib + "\\africanengine.zip"; // Repertory zip output
                    string extractPath = xfeslib; // Repertory extract zip output

                    using (ZipArchive archive = ZipFile.OpenRead(zipFilePath)) /// Using Zip Archive Extention and read zipFilePath
                    {
                        foreach (ZipArchiveEntry entry in archive.Entries)
                            {
                                // Skip directories (if any)
                                if (string.IsNullOrEmpty(entry.Name))
                                {
                                    continue;
                                }
                                string entryPath = Path.Combine(extractPath, entry.FullName);
                                string entryDirectory = Path.GetDirectoryName(entryPath);
                                if (!Directory.Exists(entryDirectory))
                                {
                                    Directory.CreateDirectory(entryDirectory);
                                }

                                entry.ExtractToFile(entryPath, true);
                            }
                        }
                        // Delete the ZIP file
                        File.Delete(zipFilePath);
                    }
                }
            }
        ///////////////////////////////////////////////////////////////////////////////////////
        //// DOWNLOAD FILE WEBCLIENT
        static void DownloadFile(string url, string fileName) //// Download lib xfes libra
            {
        // Create WebClient Instance
        WebClient webClient = new WebClient();
        // Dowload File 
        webClient.DownloadFile(url, fileName);
         }
    }
}

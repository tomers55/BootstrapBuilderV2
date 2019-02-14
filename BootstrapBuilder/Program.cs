using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Resources;
using BootstrapBuilder.Properties;
using System.Collections;
using System.Globalization;
using System.Reflection;

namespace BootstrapBuilder
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
            SystemGlobalVars();
            AddRegistryKeyForWebBrowser();
            CopyAllZipTemplates();


            Application.Run(new Form2());   //לשנות בהמשך ********
            //Application.Run(new Form2());
        }

        static void AddRegistryKeyForWebBrowser()
        {
            //מוסיף קיי לרג'יסטרי כדי שהוובראוזר יתעדכן לגרסא החדשה של אקספלורר
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\FEATURE_BROWSER_EMULATION", true);
            key.SetValue(System.AppDomain.CurrentDomain.FriendlyName.ToString(), 11001, RegistryValueKind.DWord);
        }
        static void CopyAllZipTemplates()
        {
            bool exists = System.IO.Directory.Exists(Globals.GetValue("Global_projectfolderPath").ToString() + @"\Projects");

            if (!exists)
                System.IO.Directory.CreateDirectory(Globals.GetValue("Global_projectfolderPath").ToString() + @"\Projects");            
        }
        //Set ALL System GlobalVars
        static void SystemGlobalVars()
        {
            Globals.addGlobalVar("Global_exePath", System.Reflection.Assembly.GetEntryAssembly().Location.ToString());
            Globals.addGlobalVar("Global_projectfolderPath", Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location));
            Globals.addGlobalVar("Global_Html_StartbootstrapFullSliderGhPages_Template", Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location)+ @"\StartbootstrapFullSliderGhPages_Template\index.html");
        }
        static void Extract(string x, string y, string z)
        {
            const string nameSpace = "BootstrapBuilder";
            Assembly assembly = Assembly.GetCallingAssembly();
            using (Stream s = assembly.GetManifestResourceStream(nameSpace + "." + (y + ".") + z))
                using (BinaryReader r = new BinaryReader(s))
                    using (FileStream fs = new FileStream(x + "\\" + z,FileMode.OpenOrCreate))
                        using (BinaryWriter w = new BinaryWriter(fs))
                               w.Write(r.ReadBytes((int)s.Length));
        }

        static string[] GetRes()
        {
            string[] temp = { "StartbootstrapFullSliderGhPages.zip", "StartbootstrapFullSliderGhPages.zip" };
            return temp;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

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
            Application.Run(new Form2());
            AddRegistryKeyForWebBrowser();
        }

        static void AddRegistryKeyForWebBrowser()
        {
            //מוסיף קיי לרג'יסטרי כדי שהוובראוזר יתעדכן לגרסא החדשה של אקספלורר
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\FEATURE_BROWSER_EMULATION", true);
            key.SetValue("BootstrapBuilder.exe", 11001, RegistryValueKind.DWord);
        }
    }
}

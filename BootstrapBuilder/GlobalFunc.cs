using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Drawing;
using System.Reflection;
using System.Security.Permissions;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Data;
using System.Runtime.InteropServices.WindowsRuntime;

namespace BootstrapBuilder
{
    static class GlobalFunc
    {
        static public int CreateNewProject(string ProjectName,string ProjectTemplate,ListView lv)
        {
            string NewProjectFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Projects\" + ProjectName;
            string ProjectTemplatePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\" + ProjectTemplate;

            bool IsExists_ProjectTemplatePath = System.IO.Directory.Exists(ProjectTemplatePath);
            bool IsExists_NewProjectFolder = System.IO.Directory.Exists(NewProjectFolder);

            if (!IsExists_ProjectTemplatePath)
            {
                Dialog.Error("Sorry, Template Not Found." + "\n");
                return 1;
            }

            if (IsExists_NewProjectFolder)
            {
                Dialog.Error("Project With The Same Name Alredey Exist");
            }               
            else
            { 
                System.IO.Directory.CreateDirectory(NewProjectFolder);
                ListViewItem item = new ListViewItem(ProjectName);
                item.SubItems.Add(DateTime.Now.ToString());
                lv.Items.Add(item);
            }

            try
            {
                Microsoft.VisualBasic.FileIO.FileSystem.CopyDirectory(ProjectTemplatePath, NewProjectFolder);
            }
            catch (Exception ex)
            {
                Dialog.Error(ex.Message.ToString());
                return 1;
            }
            return 0;

        }
        public static void GetAllProjects(ListView lv)
        {
            string ProjectsFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Projects\";
            foreach (string s in Directory.GetDirectories(ProjectsFolder))
            {
                ListViewItem item = new ListViewItem(s.Remove(0, ProjectsFolder.Length));
                item.SubItems.Add(DateTime.Now.ToString());
                lv.Items.Add(item);
            }
        }        
    }
}

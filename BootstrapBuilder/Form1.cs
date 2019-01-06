using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Microsoft.VisualBasic;
//using System.Windows.Forms;
using System.Drawing;
using System.Reflection;
using System.Security.Permissions;

namespace BootstrapBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HTMLPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            HTMLPath = Path.GetFullPath(Path.Combine(HTMLPath, @"..\..\")) + @"\WebTemplate01\index.html";
        }
        string HTMLPath;

        public void RunHtml_Click(object sender, EventArgs e)
        {
            if (HTMLPath != null)
            {
                Process.Start(HTMLPath);
            }
            else
            { return; }        
        }

        private void btnImportPhoto_Click(object sender, EventArgs e)
        {

        }

        private void btnURLPhoto_Click(object sender, EventArgs e)
        {
            string PhotoURL= "https://www.akc.org/wp-content/themes/akc/component-library/assets/img/welcome.jpg";
            Dialog.InputBox("Add Photo", "URL", ref PhotoURL);
            EditHtml.AddPhoto(PhotoURL, HTMLPath);
        }

        private void SelectFolder_Click(object sender, EventArgs e)
        {
            //HTMLPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            //HTMLPath = Path.GetFullPath(Path.Combine(HTMLPath, @"..\..\")) + @"\WebTemplate01\index.html";
        }

        //public void SelectFolder_Click(object sender, EventArgs e)
        //{
        //    using (var fbd = new FolderBrowserDialog())
        //    {
        //        DialogResult result = fbd.ShowDialog();
        //        if (result == DialogResult.OK)
        //        {
        //            HTMLPath = fbd.SelectedPath.ToString();
        //        }
        //        else { return; }
        //    }
        //    string lastFolderName = Path.GetFileName(Path.GetDirectoryName(HTMLPath + @"\"));
        //    tbFilesList.Text ="- "+ lastFolderName + "\r\n";
        //    DirectoryInfo d = new DirectoryInfo(HTMLPath);//Assuming Test is your Folder
        //    FileInfo[] Files = d.GetFiles("*.html"); //Getting Text files
        //    FileInfo[] AllFiels = d.GetFiles("*.*");
        //    foreach (FileInfo file in AllFiels)
        //    {
        //        tbFilesList.Text = tbFilesList.Text + file.Name.ToString() + "\r\n";
        //    }
        //    foreach (FileInfo file in Files)
        //    {
        //        HTMLPath = d + @"\" + file.Name;         
        //    }            
        //}
    }
}

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
            string Title = "Title ";
            string Description= "Description";
            Dialog.MultiInputBox("Select Url", ref PhotoURL, ref Title, ref Description);
            EditHtml.AddPhoto(PhotoURL, HTMLPath,Title,Description);
        }

        private void SelectFolder_Click(object sender, EventArgs e)
        {
            //HTMLPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            //HTMLPath = Path.GetFullPath(Path.Combine(HTMLPath, @"..\..\")) + @"\WebTemplate01\index.html";
        }

        private void SelectWeb_Click(object sender, EventArgs e)
        {
            string Web = ((PictureBox)sender).Name;
            Dialog.Msg(Web);
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (!rbSelectedBoot01.Checked && !rbSelectedBoot02.Checked)
            {
                Dialog.Error("Select WebPage.");
            }
            else
            {
                SelectWebPanel.Visible = false;
                EditPanel.Visible = true;
            }
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            EditPanel.Visible = false;
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

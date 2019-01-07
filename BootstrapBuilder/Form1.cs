using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Drawing;
using System.Reflection;
using System.Security.Permissions;

namespace BootstrapBuilder
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
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

        }

        private void SelectWeb_Click(object sender, EventArgs e)
        {
            string Web = ((PictureBox)sender).Name;
            Dialog.Msg(Web);
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {

        }

        private void OnFormLoad(object sender, EventArgs e)
        {

        }

        private void MouseOverEvent(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;        
            pic.BackColor = Color.DarkCyan;
        }
        private void MouseLeaveEvent(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            pic.BackColor = Color.Transparent;
        }
    }
}

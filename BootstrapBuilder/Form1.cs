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

        private void OnFormLoad(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Hide();

            //-----
            tbTitle.Visible = false;
            lbTitle.Visible = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var window = MessageBox.Show("Are you sure to close this program ?", "BootStarpBuilder", MessageBoxButtons.YesNo);
            if (window == DialogResult.Yes)                
                System.Windows.Forms.Application.ExitThread();
            else
                e.Cancel = true;
        }
        //icons: https://www.flaticon.com/search?word=line
        //-----------------------------------------------------------------------------------------------------//
        public void RunHtml_Click(object sender, EventArgs e)
        {
            if (HTMLPath != null)
            {
                Process.Start(HTMLPath);
            }
            else
            { return; }        
        }

        private void btnURLPhoto_Click(object sender, EventArgs e)
        {
            string PhotoURL= "https://www.akc.org/wp-content/themes/akc/component-library/assets/img/welcome.jpg";
            string Title = "Title ";
            string Description= "Description";
            Dialog.MultiInputBox("Select Url", ref PhotoURL, ref Title, ref Description);
            EditHtml.AddPhoto(PhotoURL, HTMLPath,Title,Description);
        }

        private void SelectWeb_Click(object sender, EventArgs e)
        {
            string Web = ((PictureBox)sender).Name;
            Dialog.Msg(Web);
        }

        private void MouseOverEvent(object sender, EventArgs e)
        {
            PictureBox pBox = sender as PictureBox;
            pBox.Cursor = Cursors.Hand;
            Desing.ChangePicture(pBox, 1);
        }
        private void MouseLeaveEvent(object sender, EventArgs e)
        {
            PictureBox pBox = sender as PictureBox;
            Desing.ChangePicture(pBox, 0);
        }

        private void notepad_Click(object sender, EventArgs e)
        {
            ExitForm f1 = new ExitForm();

            f1.Show();
        }

        private void typebox_Click(object sender, EventArgs e)
        {
            lbTitle.Visible = true;
            tbTitle.Visible = true;
        }
    }
}

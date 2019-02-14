using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Drawing;
using System.Reflection;
using System.Security.Permissions;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.VisualBasic.FileIO;

namespace BootstrapBuilder
{
    public partial class Form1 : Form
    {
        string LocalProjectName;
        string LocalHtmlPath;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1(string PName, string PTamplate)
        {            
            InitializeComponent();
            lblProjectName.Text = PName;
            LocalProjectName = PName;
            LocalHtmlPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Projects\" + LocalProjectName + @"\index.Html";
            EditHtml.RefreshBrowser(LocalHtmlPath, webBrowser1);
        }

        public void RunHtml_Click(object sender, EventArgs e)
        {
            if (LocalHtmlPath != null)
            {
                
            }
            else
            { return; }       
        }

        private void btnURLPhoto_Click(object sender, EventArgs e)
        {

            EditHtml.AddPhoto(LocalHtmlPath);
        }

        private void SelectWeb_Click(object sender, EventArgs e)
        {
            string Web = ((PictureBox)sender).Name;
        }



        //private void btnTitle_Click(object sender, EventArgs e)
        //{
        //    string NetPath = "https://blackrockdigital.github.io/startbootstrap-freelancer/";
        //    if (tbTitle.Text != "")
        //    EditHtml.EditTitle(tbTitle.Text, HTMLPath);
        //    EditHtml.RefreshBrowser(NetPath, webBrowser1);
        //}
        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
       
        private void ExportWebFolder(object sender, EventArgs e)
        {
            string ProjectName = @"\WebTemplate01";
            string DestinationFolder = "",SourceFolder ="";
            SourceFolder = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + ProjectName;

            FolderBrowserDialog ExportPath = new FolderBrowserDialog();
            DialogResult result = ExportPath.ShowDialog();
            if (result == DialogResult.OK)
                DestinationFolder = ExportPath.SelectedPath.ToString();
            else
                return;

            try
            {
                Microsoft.VisualBasic.FileIO.FileSystem.CopyDirectory(SourceFolder, DestinationFolder);
            }
            catch(Exception ex)
            {
                Dialog.Msg(ex.Message.ToString());
            }          
        }
        //-----------------Events-------------------------------------------------------------
        private void MinimiseWindow(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FullSizeWindow(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void ExitProgram(object sender, EventArgs e)
        {
            var window = MessageBox.Show("Are you sure to Exit Your Project? ?", "BootStarpBuilder", MessageBoxButtons.YesNo);
            if (window == DialogResult.Yes)
            {
                this.Close();
                Form2 form2 = new Form2();
                form2.Show();
            }            
        }

        private void MouseControlersOverEvent(object sender, EventArgs e)
        {
            PictureBox pBox = sender as PictureBox;
            Desing.ControlBox(pBox, 1);
        }
        private void MouseControlersLeaveEvent(object sender, EventArgs e)
        {
            PictureBox pBox = sender as PictureBox;
            Desing.ControlBox(pBox, 0);
        }

        private void buttonPanelHover(object sender, EventArgs e)
        {
            Panel p = sender as  Panel;
            p.Cursor = Cursors.Hand;
            p.BackColor = Color.WhiteSmoke;

        }

        private void buttonPanelLeave(object sender, EventArgs e)
        {
            Panel p = sender as Panel;
            p.BackColor = Color.FromArgb(0, 33, 65);
        }

        private void EditTitle_OnClick(object sender, EventArgs e)
        {
            string Title = EditHtml.GetTitle(LocalHtmlPath);
            Dialog.InputBox("Edit Title","Enter Title:",ref Title);
            EditHtml.EditTitle(Title, LocalHtmlPath);
            EditHtml.RefreshBrowser(LocalHtmlPath, webBrowser1);
        }
    }
}
//icons: https://www.flaticon.com/search?word=line
//-----------------------------------------------------------------------------------------------------//
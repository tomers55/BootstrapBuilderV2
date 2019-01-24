using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BootstrapBuilder
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            listView1.Columns[0].Width = 300;
            listView1.Columns[1].Width = 140;
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();



        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            var window = MessageBox.Show("Are you sure to close this program ?", "BootStarpBuilder", MessageBoxButtons.YesNo);
            if (window == DialogResult.Yes)
                System.Windows.Forms.Application.ExitThread();
            else
                e.Cancel = true;
        }

        private void Form2_FormLoad(object sender, EventArgs e)
        {
            GlobalFunc.GetAllProjects(listView1);

        }
      
        //-----------------Events--&--Functions---------------------------------------------------------
        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

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
            System.Windows.Forms.Application.Exit();
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

        private void SelectedListViewValue(object sender, EventArgs e)
        {
            string ProjectName = listView1.SelectedItems[0].Text;
            Form1 form1 = new Form1(ProjectName, "");
            form1.StartPosition = FormStartPosition.Manual;
            form1.Location = this.Location;
            form1.Size = this.Size;
            form1.Show();
            this.Hide();
        }

        private void NewProject(object sender, EventArgs e)
        {
            using(var form = new SelectTemplate())
{
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string ProjectName = form.ReturnValue1;            //values preserved after close
                    string ProjectTemplate = form.ReturnValue2;

                    //(GlobalFunc.CreateNewProject(ProjectName, ProjectTemplate, listView1));
                   int ErrorFlag = GlobalFunc.CreateNewProject(ProjectName, ProjectTemplate, listView1);
                    if (ErrorFlag == 1)
                        return;



                    Form1 form1 = new Form1(ProjectName,ProjectTemplate);
                    form1.Left = this.Left;
                    form1.Top = this.Top;
                    form1.Size = this.Size;
                    form1.Show();
                }
            }
        }
        public void OnMouseHover(object sender, EventArgs e)
        {
            PictureBox pBox = sender as PictureBox;
            new ToolTip().SetToolTip(pBox, "Strat Edit Your WebSite");
        }

    }
}

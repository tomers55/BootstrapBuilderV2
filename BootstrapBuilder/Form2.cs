using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BootstrapBuilder
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void OnPicturesClick(object sender, EventArgs e)
        {
            PictureBox pBox = sender as PictureBox;
            Globals.addGlobalVar("WebName", pBox.Name);
            Form1 f1 = new Form1();
            f1.Show();
            f1.Left = this.Left;
            f1.Top = this.Top;
            f1.Size = this.Size;
            this.Visible = false;
        }


        public void OnMouseHover(object sender, EventArgs e)
        {
            PictureBox pBox = sender as PictureBox;         
            new ToolTip().SetToolTip(pBox, "Strat Edit Your WebSite");
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            var window = MessageBox.Show("Are you sure to close this program ?", "BootStarpBuilder", MessageBoxButtons.YesNo);
            if (window == DialogResult.Yes)
                System.Windows.Forms.Application.ExitThread();
            else
                e.Cancel = true;
        }
    }
}

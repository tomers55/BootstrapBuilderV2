using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BootstrapBuilder
{
    public partial class ButtonsUC : UserControl
    {
        public ButtonsUC()
        {
            InitializeComponent();
        }

        private void MouseHoverPanel(object sender, EventArgs e)
        {
            Panel p = sender as Panel;
            p.BackColor = Color.LightGray;           
        }

        private void MouseLeavePanel(object sender, EventArgs e)
        {
            Panel p = sender as Panel;
            p.BackColor = Color.Blue;
        }

        private void MouseEnterLabel(object sender, EventArgs e)
        {
            Label l = sender as Label;
            l.ForeColor = Color.White;
        }

        private void MouseLeaveLabel(object sender, EventArgs e)
        {
            Label l = sender as Label;
            l.ForeColor = Color.Black;
        }
    }
}

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
    public partial class SelectTemplate : Form
    {
        public SelectTemplate()
        {
            InitializeComponent();
        }
        public string ReturnValue1 { get; set; }
        public string ReturnValue2 { get; set; }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string ProjectTemplate = "";

            if (radioButton1.Checked == true)
                ProjectTemplate = radioButton1.Text;
            else if (radioButton2.Checked == true)
                ProjectTemplate = radioButton2.Text;
            else
            {
                Dialog.Error("Plase Chosee Tamplate!");
                return;
            }
            

            if (metroTextBox1.Text == "")
            {
                Dialog.Error("Plase Enter Project Name!");
                return ;
            }
            this.ReturnValue1 = metroTextBox1.Text;
            this.ReturnValue2 = ProjectTemplate;
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}

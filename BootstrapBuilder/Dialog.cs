using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Drawing;

namespace BootstrapBuilder
{
    static class Dialog
    {
        public static void Msg(object x)
        {
            MessageBox.Show(x.ToString(), "Message", MessageBoxButtons.OK);
        }

        public static void Error(string x)
        {
            MessageBox.Show(x, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

        public static DialogResult MultiInputBox(string title, ref string Value, ref string tValue, ref string dValue)
        {
            Form form = new Form();
            Label label = new Label();
            Label labe2 = new Label();
            Label labe3 = new Label();
            TextBox textBoxUrl = new TextBox();
            TextBox textBoxTitle = new TextBox();
            TextBox textBoxDes = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();


            form.Text = title;
            label.Text = "URL:";
            textBoxUrl.Text = Value;
            labe2.Text = "Title:";
            textBoxTitle.Text = tValue;
            labe3.Text = "Description:";
            textBoxDes.Text = dValue;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBoxUrl.SetBounds(12, 36, 372, 20);
            labe2.SetBounds(9, 60, 372, 13);
            textBoxTitle.SetBounds(12, 76, 250, 20);
            labe3.SetBounds(9, 100, 372, 13);
            textBoxDes.SetBounds(12, 116, 250, 20);
            buttonOk.SetBounds(228, 180, 75, 23);
            buttonCancel.SetBounds(309, 180, 75, 23);

            label.AutoSize = true;
            textBoxUrl.Anchor = textBoxUrl.Anchor | AnchorStyles.Right;
            textBoxTitle.Anchor = textBoxTitle.Anchor | AnchorStyles.Right;
            textBoxDes.Anchor = textBoxDes.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            //form.ClientSize = new Size(396, 107);
            form.ClientSize = new Size(396,220);
            form.Controls.AddRange(new Control[] { label, textBoxUrl, buttonOk, buttonCancel });
            form.Controls.AddRange(new Control[] { labe2, textBoxTitle, buttonOk, buttonCancel });
            form.Controls.AddRange(new Control[] { labe3, textBoxDes, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.ClientSize = new Size(Math.Max(300, labe2.Right + 10), form.ClientSize.Height);
            form.ClientSize = new Size(Math.Max(300, labe3.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            Value = textBoxUrl.Text;
            tValue = textBoxTitle.Text;
            dValue = textBoxDes.Text;
            return dialogResult;
        }

    }
}

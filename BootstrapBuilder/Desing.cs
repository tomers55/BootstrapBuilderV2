using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Drawing;
using System.Reflection;
using System.Security.Permissions;
using System.Windows.Media.Imaging;
using BootstrapBuilder.Properties;
using System.Resources;

namespace BootstrapBuilder
{
    static class Desing
    {    
        public static void ChangePicture(PictureBox thePicture,int Hover)
        {
            ResourceManager rm = Resources.ResourceManager;
            Bitmap myImage;
            if (Hover == 1)
            {
                myImage = (Bitmap)rm.GetObject(thePicture.Name+"_1_");
            }
            else
            { 
                myImage = (Bitmap)rm.GetObject(thePicture.Name);
            }
            thePicture.Image = myImage;                    
            thePicture.Refresh();
            thePicture.Visible = true;
        }

        public static void ControlBox(PictureBox thePicture,int Hover)
        {
            if (Hover == 1)
            {
                thePicture.Cursor = Cursors.Hand;

                if (thePicture.Name == "pbClose")
                    thePicture.BackColor = Color.Red;
                else
                    thePicture.BackColor = Color.WhiteSmoke;

            }
            else
                thePicture.BackColor = Color.Transparent;

        }
        public static void textevent(object sender, EventArgs e)
        {
            Dialog.Msg("fffff");
        }
    }
}


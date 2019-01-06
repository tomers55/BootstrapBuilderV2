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

namespace BootstrapBuilder
{
    public static class EditHtml
    {
        public static void AddPhoto(string PhotoPath,string HTMLPath)
        {
            string HtmlAddPhoho = Properties.Resources.HtmlAddPhoho;
            string DataSlide = Properties.Resources.DataSlide;
            string FirstPhoto = Properties.Resources.FirstPhoto;
            string text = "";
            //מוסיף תמונה            



            //מוסיף ערך לסליידר
            int Num =0,Count =0;
            foreach (var line in File.ReadAllLines(HTMLPath))
            {
                if (line.Contains(@"data-slide-to=""" + Count + @""""))
                {
                    Count++;
                }
            }
            Num =Count - 1;
            foreach (var line in File.ReadAllLines(HTMLPath))
            {
                if (line.Contains(@"data-slide-to=""" + Num + @""""))
                {
                    Num++;
                }
            }
            Dialog.Msg(Num.ToString());
            if (Num == 1)
            {
                
                text = File.ReadAllText(HTMLPath);
                text = text.Replace("http://placehold.it/1900x1080", PhotoPath);
                //text = text.Replace(FirstPhoto, HtmlAddPhoho);
            }
            else
            {
                HtmlAddPhoho = HtmlAddPhoho.Replace("http://placehold.it/1900x1080", PhotoPath);
                text = File.ReadAllText(HTMLPath);
                DataSlide = DataSlide.Replace("Num", Num.ToString());
                text = text.Replace("<!--AddDataSlide-->", DataSlide);//מוסיף סליידר
                text = text.Replace("<!--AddPhoto-->", HtmlAddPhoho);//מוסיף תמונה
            }
            File.WriteAllText(HTMLPath, text);
        }
    }
}

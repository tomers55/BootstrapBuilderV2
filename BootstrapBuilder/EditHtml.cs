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
        public static void RefreshBrowser(string Path,WebBrowser wb)
        {
            WebBrowser WebBrowser1 = new WebBrowser();
            string curDir = Directory.GetCurrentDirectory();
            wb.Url = new Uri(String.Format(Path, curDir));
        }

        public static void AddPhoto(string PhotoPath, string HTMLPath, object Title, string Description)
        {
            string HtmlAddPhoho = Properties.Resources.HtmlAddPhoho;
            string DataSlide = Properties.Resources.DataSlide;
            string FirstPhoto = Properties.Resources.FirstPhoto;
            string text = "";

            int NextSlideNum = 0, FirstRun = 0;
            foreach (var line in File.ReadAllLines(HTMLPath))
            {
                if (line.Contains("<!--FirstRun-->")) //האם זו התמונה הראשונה
                {
                    FirstRun = 1;
                }
                if (line.Contains(@"data-slide-to=""" + NextSlideNum + @""""))//בודק את מספר הסלייד
                {
                    NextSlideNum++;
                }
            }

            if (FirstRun == 1)
            {
                text = File.ReadAllText(HTMLPath);
                text = text.Replace("<!--FirstRun-->", "");
                text = text.Replace("<h3>0-Title</h3>", "<h3>" + Title.ToString() + "</h3>");
                text = text.Replace("<p>0-Des</p>", "<p>" + Description.ToString() + "</p>");
                text = text.Replace("http://placehold.it/1900x1080", PhotoPath);
                //text = text.Replace(FirstPhoto, HtmlAddPhoho);
            }
            else
            {
                HtmlAddPhoho = HtmlAddPhoho.Replace("http://placehold.it/1900x1080", PhotoPath);
                HtmlAddPhoho = HtmlAddPhoho.Replace("<h3>Title</h3>", "<h3>" + Title + "</h3>");
                HtmlAddPhoho = HtmlAddPhoho.Replace("<p>Des</p>", "<p>" + Title + "</p>");
                text = File.ReadAllText(HTMLPath);
                DataSlide = DataSlide.Replace("NextSlideNum", NextSlideNum.ToString());
                text = text.Replace("<!--AddDataSlide-->", DataSlide);//מוסיף סליידר
                text = text.Replace("<!--AddPhoto-->", HtmlAddPhoho);//מוסיף תמונההה
            }
            File.WriteAllText(HTMLPath, text);
        }

        public static void EditTitle(string TopTitle, string HTMLPath)
        {
            string text = "";
            text = File.ReadAllText(HTMLPath);
            foreach (var line in File.ReadAllLines(HTMLPath))
            {
                    if (line.Contains("<!--Tit-->"))
                    {
                        text = text.Replace(line, @"<!--Tit--><a class=""navbar-brand"" href=""#"">" + TopTitle + "</a>");
                    }               
            }
            File.WriteAllText(HTMLPath, text);
        }
        public static string GetTitle(string HTMLPath)
        {
            string Title = "";
            foreach (var line in File.ReadAllLines(HTMLPath))
            {
                if (line.Contains("<!--Tit-->"))
                {
                    Title = line;
                    Title = Title.Replace(@"<!--Tit--><a class=""navbar-brand"" href=""#"">","");
                    Title = Title.Replace(@"</a>","");
                }
            }       
            return Title;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace WebSite11
{
    /// <summary>
    /// Класс html-страницы Сводное описание для SitePage
    /// </summary>
    public class SitePage
    {
        public string Title { get; set; }
        public string Favicon { get; set; }
        public int BlocksNumber { get; set; }
        public string SiteDirName { get; }

        public SitePage()
        {
            int i = 1;
            this.SiteDirName = "MySite" + i;
            string SiteDirPath = System.AppDomain.CurrentDomain.BaseDirectory + SiteDirName;

            //int i = 1;
            //this.SiteName = "MySite"+i;
            string templDir = "MySite_templ";
            string dirProject = SiteDirPath;
            string templDirPath = System.AppDomain.CurrentDomain.BaseDirectory + templDir;

            while (Directory.Exists(dirProject))
            {
                i++;
                //SiteDirName += i;
                SiteDirName = "MySite" + i;
                dirProject = System.AppDomain.CurrentDomain.BaseDirectory + SiteDirName;
            }
            ////if (!Directory.Exists(dirProject))
            Directory.CreateDirectory(dirProject);
            Directory.CreateDirectory(dirProject + "\\css");
            Directory.CreateDirectory(dirProject + "\\fonts");
            Directory.CreateDirectory(dirProject + "\\Images");
            Directory.CreateDirectory(dirProject + "\\js");

            DirectoryInfo dirInfo = new DirectoryInfo(templDirPath);
            foreach (FileInfo file in dirInfo.GetFiles("*.*"))
            {
                File.Copy(file.FullName, dirProject + "\\" + file.Name, true);
            }
            DirectoryInfo dirInfoCss = new DirectoryInfo(templDirPath + "\\css");
            foreach (FileInfo file in dirInfoCss.GetFiles("*.*"))
            {
                File.Copy(file.FullName, dirProject + "\\css\\" + file.Name, true);
            }
            DirectoryInfo dirInfoFonts = new DirectoryInfo(templDirPath + "\\fonts");
            foreach (FileInfo file in dirInfoFonts.GetFiles("*.*"))
            {
                File.Copy(file.FullName, dirProject + "\\fonts\\" + file.Name, true);
            }
            DirectoryInfo dirInfoImg = new DirectoryInfo(templDirPath + "\\Images");
            foreach (FileInfo file in dirInfoImg.GetFiles("*.*"))
            {
                File.Copy(file.FullName, dirProject + "\\Images\\" + file.Name, true);
            }
            DirectoryInfo dirInfoJs = new DirectoryInfo(templDirPath + "\\js");
            foreach (FileInfo file in dirInfoJs.GetFiles("*.*"))
            {
                File.Copy(file.FullName, dirProject + "\\js\\" + file.Name, true);
            }
        }
        public SitePage(string name)
        {
            Title = name;
        }
    }
}

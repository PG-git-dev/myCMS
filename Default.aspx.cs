using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class _Default : Page 
{ 
    public string SiteName { get; set; } 

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int i = 1;
        this.SiteName = "MySite"+i;
        string templDir = "MySite_templ";
        string dirProject = System.AppDomain.CurrentDomain.BaseDirectory + SiteName;
        string templDirPath = System.AppDomain.CurrentDomain.BaseDirectory + templDir;
        //string siteTmplHtml = templDirPath + "\\" + @"MySite.html";//расположение файла сайта HTML по-умолчанию
        //string siteTmplCss = templDirPath + "\\" + @"style.css";//расположение файла стилей сайта CSS по-умолчанию
        //string fileHtmlPath = dirProject + "\\" + SiteName + ".html";

        while (Directory.Exists(dirProject))
        {
            i++;
            SiteName += i;
            dirProject = System.AppDomain.CurrentDomain.BaseDirectory + SiteName;
        }
        ////if (!Directory.Exists(dirProject))
        Directory.CreateDirectory(dirProject);
        Directory.CreateDirectory(dirProject+"\\css");
        Directory.CreateDirectory(dirProject+"\\fonts");
        Directory.CreateDirectory(dirProject+"\\Images");
        Directory.CreateDirectory(dirProject+"\\js");

        DirectoryInfo dirInfo = new DirectoryInfo(templDirPath);
        foreach (FileInfo file in dirInfo.GetFiles("*.*"))
        {
            File.Copy(file.FullName, dirProject + "\\" + file.Name, true);
        }
        DirectoryInfo dirInfoCss = new DirectoryInfo(templDirPath+"\\css");
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

        Response.Redirect("~/MyPage.aspx?SiteName=" + SiteName);
    }
}
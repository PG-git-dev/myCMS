using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HtmlAgilityPack;

public partial class ImageCrop : System.Web.UI.Page
{
    string fileHtmlPath = System.AppDomain.CurrentDomain.BaseDirectory + "imagecrop.aspx";
    string imagePath;
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (ImageForCropFileUpload.HasFile)
        //{
        //    HtmlDocument doc = new HtmlDocument();
        //    doc.Load(fileHtmlPath);
        //    HtmlNode cropImage = doc.DocumentNode.SelectSingleNode("//img[@class='cropimage']");
        //    cropImage.Attributes["src"].Value = ImageForCropFileUpload.FileName;
        //    doc.Save(fileHtmlPath);
        //}

    }

    void ImageFile()
    {
        if (ImageForCropFileUpload.HasFile)
        {
            imagePath = AppDomain.CurrentDomain.BaseDirectory + "mysite\\images\\" + Server.HtmlEncode(ImageForCropFileUpload.FileName);
            ImageForCropFileUpload.SaveAs(imagePath);
            HtmlDocument doc = new HtmlDocument();
            doc.Load(fileHtmlPath);
            HtmlNode cropImage = doc.DocumentNode.SelectSingleNode("//img[@class='cropimage']");
            cropImage.Attributes["src"].Value = @"mysite\images\"+Server.HtmlEncode(ImageForCropFileUpload.FileName);
            HtmlNode cropImageSave = doc.DocumentNode.SelectSingleNode("//a");
            cropImageSave.Attributes["download"].Value = "croped_" + Server.HtmlEncode(ImageForCropFileUpload.FileName);
            //cropImageSave.Attributes["href"].Value = AppDomain.CurrentDomain.BaseDirectory + "mysite\\images\\";
            doc.Save(fileHtmlPath);
        }
    }

    protected void Panel1_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        ImageFile();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        //HtmlDocument doc = new HtmlDocument();
        //doc.Load(fileHtmlPath);
        //HtmlNode cropImage = doc.DocumentNode.SelectSingleNode("//a");
        //cropImage.Attributes["download"].Value = "croped" + Server.HtmlEncode(ImageForCropFileUpload.FileName);
        //doc.Save(fileHtmlPath);

    }
}
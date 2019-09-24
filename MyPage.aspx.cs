using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;
using HtmlAgilityPack;
using Omu.Drawing;
using WebSite11;

public partial class MyPage : System.Web.UI.Page
{
    public string MainSiteName { get; set; }  //имя сайта, которым будет управлять админка 
    public string SiteDir {get; set; } //директория, где будут располагаться файлы сайта
    protected string projectDir = System.AppDomain.CurrentDomain.BaseDirectory;//директория проекта
    public string FileHtmlPath { get; set; }
    ////string dirProject =
    ////System.AppDomain.CurrentDomain.BaseDirectory + siteName + "\\";
    ////HttpContext.Current.Server.MapPath()
    //string dirProject =System.AppDomain.CurrentDomain.BaseDirectory+"MySite\\";//директория, где будут располагаться файлы сайта
    //string siteTmplHtml = System.AppDomain.CurrentDomain.BaseDirectory + @"header1.html";//расположение файла сайта HTML по-умолчанию
    //string siteTmplCss = System.AppDomain.CurrentDomain.BaseDirectory + @"style.css";//расположение файла стилей сайта CSS по-умолчанию
    //string fileHtmlPath = System.AppDomain.CurrentDomain.BaseDirectory + "MySite\\MySite.html"; 

    protected void Page_Init(object sender, EventArgs e)
    {
        BannerCheckBox.InputAttributes.Add("style", "display: none;");
        BannerCheckBox.InputAttributes.Add("OnCheckedChanged", "BlockVisibilityCheckBox_CheckedChanged");
        BannerCheckBox.InputAttributes.Add("ValidationGroup", "BlockVisibility");
        BannerCheckBox.InputAttributes.Add("Checked", "true");
        
        RadioButtonText.InputAttributes.Add("class", "radio");
        //RadioButtonText.InputAttributes.Add("name", "radio-grp");
        RadioButtonText.InputAttributes.Add("type", "radio");
        RadioButtonText.InputAttributes.Add("GroupName", "BannerTextStyle");
        RadioButtonText.InputAttributes.Add("AutoPostBack", "true");
        RadioButtonText.InputAttributes.Add("OnCheckedChanged", "RadioButton_CheckedChanged");
        //RadioButtonText.InputAttributes.Add("Checked", "True");

        RadioButtonBullet.InputAttributes.Add("class", "radio");
        //RadioButtonBullet.InputAttributes.Add("name", "radio-grp");
        RadioButtonBullet.InputAttributes.Add("type", "radio");
        RadioButtonBullet.InputAttributes.Add("GroupName", "BannerTextStyle");
        RadioButtonBullet.InputAttributes.Add("AutoPostBack", "true");
        RadioButtonBullet.InputAttributes.Add("OnCheckedChanged", "RadioButton_CheckedChanged");
        RadioButtonBullet.InputAttributes.Add("Checked", "true");
    }
    protected void Page_Load(object sender, EventArgs e) //загрузка страницы
    {
        #region Здесь была проверка существования каталога сайта и файлов в нём
        //if (!Directory.Exists(dirProject))
        //    Directory.CreateDirectory(dirProject);
        //if (!File.Exists(dirProject + @"MySite.html"))//м.б. обрамить try catch ?
        //    File.Copy(siteTmplHtml, dirProject + @"MySite.html");
        //    //File.Copy(siteTmplHtml, System.AppDomain.CurrentDomain.BaseDirectory + "MySite.html");
        //if (!File.Exists(dirProject + @"Style.css"))
        //    File.Copy(siteTmplCss, dirProject + @"Style.css");
        ////TextBox1.Text = GetTitleHtml(dirProject + @"\MySite.html");
        #endregion
        if (Request.QueryString["SiteName"] != null)
        {
           MainSiteName = Request.QueryString["SiteName"];//получение имени сайта со стартовой страницы (Default.aspx)
           SiteDir = System.AppDomain.CurrentDomain.BaseDirectory + MainSiteName;//директория размещения файлов сайта
        #region старые переменные (сейчас проверки реализованы в файле Default.asxp)
            /*           //string templDir = "MySite_templ";
                        ////HttpContext.Current.Server.MapPath()
                        ////System.AppDomain.CurrentDomain.BaseDirectory + "MySite\\";//директория, где будут располагаться файлы сайта
                        //    string siteTmplHtml = System.AppDomain.CurrentDomain.BaseDirectory + @"header1.html";//расположение файла сайта HTML по-умолчанию
                        //    string siteTmplCss = System.AppDomain.CurrentDomain.BaseDirectory + @"style.css";//расположение файла стилей сайта CSS по-умолчанию
                        //    string fileHtmlPath = System.AppDomain.CurrentDomain.BaseDirectory + "MySite\\MySite.html";

                        //string siteTmplHtml = System.AppDomain.CurrentDomain.BaseDirectory + templDir + "\\" + @"MySite.html";//расположение файла сайта HTML по-умолчанию
                        //string siteTmplCss = System.AppDomain.CurrentDomain.BaseDirectory + templDir + "\\" + @"style.css";//расположение файла стилей сайта CSS по-умолчанию
            */
            #endregion
            FileHtmlPath = SiteDir + "\\index.html";
            this.DataBind();
        }
        else
        {
            Response.Redirect("~/Default.aspx");
        }
    }
    /*    private string PathHTML()
        {
            string dir = Directory.GetCurrentDirectory();
            string pathHTML = dir + "\\ExampleWebSite";
            return pathHTML;
        }
    */
    protected void Button2_Click(object sender, EventArgs e)//пустая
    {
            
        //StreamWriter sw = null;

            //Directory.CreateDirectory(@"C:\MyCsDir");
/*********************************************************************************************/
        //string ePath =Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
        //string ePathHTML = ePath + "\\IIS Express\\ExampleWebSite";
        //if (!Directory.Exists(epathHTML))
        //    Directory.CreateDirectory(epathHTML);

    }
    
    public string GetTitle()//заголовок страницы из приложения (то, что размещено в TextBox'e)
    {
        return TextBox1.Text;
    }
    public string GetSitePath()//возвращает значение для атрибута OnClick MyPages.aspx (т.е. вызов нового окна с сайтом)
    {
        //MainSiteName = Request.QueryString["SiteName"];

        //string str= "window.open('" + dirProject + "\\MySite.html')";
        //return str;
        //Button1.OnClientClick = "window.open('<%#GetSitePath() %>')";
        //return "www.yandex.ru";
        //FileHtmlPath = SiteDir + "\\" + "index.html";
        string fil;
        //fil = dirProject + "\\MySite1.html";
        //fil = "http://www.yandex.ru";
        //fil = FileHtmlPath;
        fil = MainSiteName+"\\" + "\\index.html"; 
        return "window.open('" + fil + "')";
        //return "window.open('" + fileHtmlPath + "')";//посмотреть почему не работает...
    }
    
/*    public string GetBannerHeader()//заголовок банера из формы
    {
        ArtLebedevStudio.RemoteTypograf typografedText = new ArtLebedevStudio.RemoteTypograf();

        typografedText.xmlEntities();
        typografedText.br(false);
        typografedText.p(false);
        typografedText.nobr(3);
        
        return typografedText.ProcessText(BannerHeaderTextArea.InnerText);
    }
*/

    /*    public string GetBannerHeaderFromHtml(string htmlPath)//заголовок банера из хтмл
        {
            HtmlDocument doc = new HtmlDocument();
            //doc.Load(dirProject + @"MySite.html");
            doc.Load(htmlPath);
            HtmlNode divBannerHeader = doc.DocumentNode.SelectSingleNode("//div[@class='banner_text']//h1");
            return divBannerHeader.InnerHtml;
        }
    */

    //string GetBannerText(HtmlTextArea textAreaElement)//текст из банера на форме
    //{
    //    ArtLebedevStudio.RemoteTypograf typografedText = new ArtLebedevStudio.RemoteTypograf();
    //    typografedText.xmlEntities();
    //    typografedText.br(false);
    //    typografedText.p(false);
    //    typografedText.nobr(3);
    //    return typografedText.ProcessText(textAreaElement.InnerText);

    //}

    string GetTextAreaFromForm(HtmlTextArea textAreaElement)//текст из области на форме
    {
        ArtLebedevStudio.RemoteTypograf typografedText = new ArtLebedevStudio.RemoteTypograf();
        typografedText.xmlEntities();
        typografedText.br(false);
        typografedText.p(false);
        typografedText.nobr(3);
        return typografedText.ProcessText(textAreaElement.InnerText);
    }


    public string GetBulletTextFromHtml(string bulletId)//текст буллита из хтмл-файла
                                                        //bulletId - id буллита в html-файле
    {
        HtmlDocument doc = new HtmlDocument();
        //doc.Load(dirProject + @"MySite.html");
        doc.Load(FileHtmlPath);
        HtmlNode bulText = doc.DocumentNode.SelectSingleNode("//div[@class='banner_text']//ul//li//span[@id='"+ bulletId + "']");
        return bulText.InnerHtml;
    }
    //  string GetBannerTextFromHtml()
    //  {
    //      HtmlDocument doc = new HtmlDocument();
    //      doc.Load(fileHtmlPath);
    //      HtmlNode bannerText = doc.DocumentNode.SelectSingleNode("//p[@class='text_on_banner']");
    //      return bannerText.InnerHtml;
    //  }

    string GetTextFromHtml(string xpath)//получение текста из html-файла
    {
        HtmlDocument doc = new HtmlDocument();
        doc.Load(FileHtmlPath);
        HtmlNode node = doc.DocumentNode.SelectSingleNode(xpath);
        return node.InnerHtml;
    }

    protected void Button1_Click(object sender, EventArgs e)//"Просмотр"
    {
        //Process.Start(dirProject + @"\MySite.html");
        //Process.Start(HttpContext.Current.Server.MapPath("MySite.html"));
        //Process newTab = new Process();
        //newTab.StartInfo.FileName = dirProject + @"\MySite.html";
        //newTab.Start();
        //GetSitePath();
        //this.DataBind();

        //Button1.OnClientClick = "window.open('" + dirProject + "\\MySite.html" + "')";OnClientClick="window.open('<%#GetSitePath() %>')"
        // Button1.OnClientClick= "window.open('<%#GetSitePath() %>')";
        //Response.Redirect(dirProject + "MySite.html");
    }

 /*   string GetTitleFromHtml(string filePath)//заголовок хтмл-страницы сайта из хтмл 
    {
        HtmlDocument doc = new HtmlDocument();
        //doc.Load(dirProject + @"MySite.html");
        doc.Load(filePath);
   
        HtmlNode titleNode = doc.DocumentNode.SelectSingleNode("//title");
        return titleNode.InnerText;
    }
*/
    //void ChangeFavIcon()//изменение фавиконки
    //{
    //    string saveImageDir = @"Images\";
    //    if (!Directory.Exists(dirProject + saveImageDir))
    //        Directory.CreateDirectory(dirProject + saveImageDir);
    //    if (FileUpload1.HasFile)
    //    {
    //        string saveImagePath = dirProject + saveImageDir + Server.HtmlEncode(FileUpload1.FileName);
    //        FileUpload1.SaveAs(saveImagePath);

    //        HtmlDocument doc = new HtmlDocument();
    //        doc.Load(fileHtmlPath);
    //        HtmlNode linkFavIconNode = doc.DocumentNode.SelectSingleNode("//link[@rel='icon']");
    //        //linkFavIconNode.Attributes["href"].Value = saveImagePath;
    //        linkFavIconNode.Attributes["src"].Value = saveImageDir + Server.HtmlEncode(FileUpload1.FileName);
    //        doc.Save(fileHtmlPath);
    //    }
    //}

    void ChangeIcon(FileUpload fileForm, string xpath)//изменение картинки; 
                                                      //fileForm - форма, в которой указан путь к картинке;
                                                      //xpath - куда в хтмл файле вставить путь к картинке.
    {
        string saveImageDir = @"Images\";
        if (!Directory.Exists(SiteDir + "\\" + saveImageDir))
            Directory.CreateDirectory(SiteDir + "\\" + saveImageDir);
        if (fileForm.HasFile)
        {
            string saveImagePath = SiteDir + "\\" + saveImageDir + Server.HtmlEncode(fileForm.FileName);
            fileForm.SaveAs(saveImagePath);

            HtmlDocument doc = new HtmlDocument();
            doc.Load(FileHtmlPath);
            HtmlNode linkFavIconNode = doc.DocumentNode.SelectSingleNode(xpath);
            //linkFavIconNode.Attributes["href"].Value = saveImagePath;
            linkFavIconNode.Attributes["href"].Value = saveImageDir + Server.HtmlEncode(fileForm.FileName);
            doc.Save(FileHtmlPath);
        }
    }
    void ChangeImage(FileUpload elementName, string xpath, string htmlAttribName)//изменение картинки; (альтернатива ChangeIcon)
                                                                                 //elementName - элемент на форме, в котором указан путь к картинке;
                                                                                 //xpath - путь к элементу в HTML-файле;
                                                                                 //htmlAttribName - атрибут элемента в HTML-файле, в который нужно вставить путь к картинке;
    {
        string saveImageDir = @"Images\";
        if (!Directory.Exists(SiteDir + "\\" + saveImageDir))
            Directory.CreateDirectory(SiteDir + "\\" + saveImageDir);
        if (elementName.HasFile)
        {
            string saveImagePath = SiteDir + "\\" + saveImageDir + Server.HtmlEncode(elementName.FileName);
            elementName.SaveAs(saveImagePath);

            HtmlDocument doc = new HtmlDocument();
            doc.Load(FileHtmlPath);
            HtmlNode elemNode = doc.DocumentNode.SelectSingleNode(xpath);
            elemNode.Attributes[htmlAttribName].Value = saveImageDir + Server.HtmlEncode(elementName.FileName);
            doc.Save(FileHtmlPath);
        }
    }


    /*    It's previous version of method
    *    string _GetTitleHtml(string filePath)//заголовок из файла сайта (HTML)
       {
           string fileText = string.Empty;

           using (StreamReader reader = File.OpenText(filePath))
           {
               fileText = reader.ReadToEnd();
           }

           //var regex = new Regex(@"(?<=<title>)(.*)(?=</title>)");
           var regex = new Regex(@"(?<=<title>).*?(?=</title>)");

           var match = regex.Match(fileText);
           if (match.Success)
               return match.ToString();
           else
               return null;
       }
   */
    /*   public string GetCardBlockHeaderFromHtml(string htmlPath)//заголовок блока карточек с картинками из хтмл
        {
            HtmlDocument doc = new HtmlDocument();
            doc.Load(htmlPath);
            HtmlNode divBannerHeader = doc.DocumentNode.SelectSingleNode("//h2");
            return divBannerHeader.InnerHtml;
        }
    */
    void ColorChanger(string xPath)// color - color of block; xPath - block
    {
        HtmlDocument doc = new HtmlDocument();
        doc.Load(FileHtmlPath);
        HtmlNode node = doc.DocumentNode.SelectSingleNode(xPath);
        if (node.Attributes.AttributesWithName("style").ToString().Equals("display: none; background-color: #f1f1f1"))
            node.SetAttributeValue("style", "display: none; background-color: #ffffff");
        if (node.Attributes.AttributesWithName("style").ToString().Equals("display: none; background-color: #ffffff"))
            node.SetAttributeValue("style", "display: none; background-color: #f1f1f1");
        if (node.Attributes.AttributesWithName("style").ToString().Equals("display: block; background-color: #f1f1f1"))
            node.SetAttributeValue("style", "display: block; background-color: #ffffff");
        if (node.Attributes.AttributesWithName("style").ToString().Equals("display: block; background-color: #ffffff"))
            node.SetAttributeValue("style", "display: block; background-color: #f1f1f1");
        doc.Save(FileHtmlPath);
    }//NOT USED NOW
    void SetBlockColor(string xPath, string color)// color - hex-color of block (#xxxxxx); xPath - block
    {
        HtmlDocument doc = new HtmlDocument();
        doc.Load(FileHtmlPath);
        HtmlNode node = doc.DocumentNode.SelectSingleNode(xPath);
        if (node.Attributes["style"].Value.Equals("display: none; background-color: #f1f1f1"))
            node.SetAttributeValue("style", "display: none; background-color: " + color);
        if (node.Attributes["style"].Value.Equals("display: none; background-color: #ffffff"))
            node.SetAttributeValue("style", "display: none; background-color: " + color);
        if (node.Attributes["style"].Value.Equals("display: block; background-color: #ffffff"))
            node.SetAttributeValue("style", "display: block; background-color: " + color);
        if (node.Attributes["style"].Value.Equals("display: block; background-color: #f1f1f1"))
            node.SetAttributeValue("style", "display: block; background-color: " + color);
        doc.Save(FileHtmlPath);
    }
    void SetBlockColorAndVisibility(string xPath, string color, string sw)// color - hex-color of block (#xxxxxx); xPath - block; 
                                                                            // sw: on - visible, off - invisible;
    {
        HtmlDocument doc = new HtmlDocument();
        doc.Load(FileHtmlPath);
        HtmlNode node = doc.DocumentNode.SelectSingleNode(xPath);
        if (sw.Equals("on"))
        {
            if (node.Attributes["style"].Value.Equals("display: none; background-color: #f1f1f1"))
                node.SetAttributeValue("style", "display: block; background-color: " + color);
            else
            {
                if (node.Attributes["style"].Value.Equals("display: none; background-color: #ffffff"))
                    node.SetAttributeValue("style", "display: block; background-color: " + color);
                else
                { 
                    if (node.Attributes["style"].Value.Equals("display: block; background-color: #ffffff"))
                        node.SetAttributeValue("style", "display: block; background-color: " + color);
                    else
                    { 
                    if (node.Attributes["style"].Value.Equals("display: block; background-color: #f1f1f1"))
                        node.SetAttributeValue("style", "display: block; background-color: " + color);
                    }
                }
            }
        }
        if (sw.Equals("off"))
        {
            if (node.Attributes["style"].Value.Equals("display: none; background-color: #f1f1f1"))
                node.SetAttributeValue("style", "display: none; background-color: " + color);
            if (node.Attributes["style"].Value.Equals("display: none; background-color: #ffffff"))
                node.SetAttributeValue("style", "display: none; background-color: " + color);
            if (node.Attributes["style"].Value.Equals("display: block; background-color: #ffffff"))
                node.SetAttributeValue("style", "display: none; background-color: " + color);
            if (node.Attributes["style"].Value.Equals("display: block; background-color: #f1f1f1"))
                node.SetAttributeValue("style", "display: none; background-color: " + color);
        }
        doc.Save(FileHtmlPath);
    }

    void BlockVisibility(string xPath, string sw)// xPath - block; 
                                                 // sw: on - visible, off - invisible;
    {
        HtmlDocument doc = new HtmlDocument();
        doc.Load(FileHtmlPath);//file of the site load
        HtmlNode node = doc.DocumentNode.SelectSingleNode(xPath);
        if (sw=="on")
            node.SetAttributeValue("style", "display: block");
        if (sw=="off")
            node.SetAttributeValue("style", "display: none");
        doc.Save(FileHtmlPath);
    }
    void BlockVisibility(string fileName, string xPath, string sw)// xPath - block; 
                                                                  // sw: on - visible, off - invisible;
    {
        HtmlDocument doc = new HtmlDocument();
        doc.Load(fileName);//file of the site load
        HtmlNode node = doc.DocumentNode.SelectSingleNode(xPath);
        if (sw == "on")
            node.SetAttributeValue("style", "display: block");
        if (sw == "off")
            node.SetAttributeValue("style", "display: none");
        doc.Save(fileName);
    }
    bool CheckBoxChecking(string fileName, string xPath)// fileName - file, xPath - block
    {
        HtmlDocument doc = new HtmlDocument();
        doc.Load(fileName);//file of the site load
        HtmlNode node = doc.DocumentNode.SelectSingleNode(xPath);
        if (node.Attributes["style"].Value.Equals("display: none; background-color: #f1f1f1") || node.Attributes["style"].Value.Equals("display: none; background-color: #ffffff"))
        //if (node.Attributes.AttributesWithName("style").ToString().Equals("display: none; background-color: #f1f1f1") || node.Attributes.AttributesWithName("style").ToString().Equals("display: none; background-color: #ffffff"))
        {
            doc.Save(fileName);
            return false;
        }
        else
        {
            doc.Save(fileName);
            return true;
        }
    }
    protected void Button3_Click(object sender, EventArgs e)//SAVE button
    {
        HtmlDocument doc = new HtmlDocument();
        doc.Load(SiteDir + "\\index.html");//загрузка хтмл-файла сайта
        HtmlNode titleNode = doc.DocumentNode.SelectSingleNode("//title");//тег заголовка
        titleNode.InnerHtml = GetTitle();
/*************************************************************************************************************/
        HtmlNode bannerHeader = doc.DocumentNode.SelectSingleNode("//div[@class='banner_text']//h1");//тег заголовка банера
        bannerHeader.InnerHtml = GetTextAreaFromForm(BannerHeaderTextArea);
        //TextArea1.InnerText = divBanner.InnerHtml;
        // doc.Save(dirProject + @"\MySite.html");
/*************************************************************************************************************/
        if (RadioButtonBullet.Checked)
        {
            HtmlNode bannerBulletsBlok = doc.DocumentNode.SelectSingleNode("//ul[@class='banner_bullits']");
            bannerBulletsBlok.SetAttributeValue("style", "display: block");
            HtmlNode bannerBullet1 = doc.DocumentNode.SelectSingleNode("//span[@id='banner_bul1']");
            //bannerBullet1.InnerHtml = TextArea3.InnerText;//запись в хтмл текста из буллита
            bannerBullet1.InnerHtml = GetTextAreaFromForm(Bullet1TextArea);
            //TextArea3.InnerText = bannerBullet1.InnerHtml;
            // doc.Save(dirProject + @"\MySite.html");
            HtmlNode bannerBullet2 = doc.DocumentNode.SelectSingleNode("//span[@id='banner_bul2']");
            //bannerHeader.InnerHtml = GetBannerHeader();
            //TextArea4.InnerText = bannerBullet2.InnerHtml;
            bannerBullet2.InnerHtml = GetTextAreaFromForm(Bullet2TextArea);
            // doc.Save(dirProject + @"\MySite.html");
            HtmlNode bannerBullet3 = doc.DocumentNode.SelectSingleNode("//span[@id='banner_bul3']");
            //bannerHeader.InnerHtml = GetBannerHeader();
            bannerBullet3.InnerHtml = GetTextAreaFromForm(Bullet3TextArea);
            // doc.Save(dirProject + @"\MySite.html");
            HtmlNode bannerBullet4 = doc.DocumentNode.SelectSingleNode("//span[@id='banner_bul4']");
            //bannerHeader.InnerHtml = GetBannerHeader();
            bannerBullet4.InnerHtml = GetTextAreaFromForm(Bullet4TextArea);
            HtmlNode bannerText = doc.DocumentNode.SelectSingleNode("//p[@class='text_on_banner']");
            bannerText.SetAttributeValue("style", "display: none");
            doc.Save(SiteDir + "\\index.html");
        }
        else//if (RadioButtonText.Checked)
        {
            HtmlNode bannerText = doc.DocumentNode.SelectSingleNode("//p[@class='text_on_banner']");
            bannerText.SetAttributeValue("style", "display: block");
            bannerText.InnerHtml = GetTextAreaFromForm(BannerTextArea);
            HtmlNode bannerBulletsBlok = doc.DocumentNode.SelectSingleNode("//ul[@class='banner_bullits']");
            bannerBulletsBlok.SetAttributeValue("style", "display: none");
            doc.Save(SiteDir + "\\index.html");
        }
        /*************************************************************************************************************/

        /*        string fileText = string.Empty;
                using (StreamReader reader = File.OpenText(dirProject + @"\MySite.html"))
                {
                    fileText = reader.ReadToEnd(); //чтение данных из файла MySite.html и запись их в fileText 
                }
                //titleText = titleText.Replace("<title>", "<title>"+GetTitle()+"</title>");
                //if (lineTitle.StartsWith("      <title>"))
                //    lineTitle = "<title>" + GetTitle() + "</title>";
                var regex = new Regex(@"(?<=<title>)(.*)(?=</title>)");//создание шаблона, по которому будет искаться текст (содержимое блока между тегами title)
                var match = regex.Match(fileText);
                if (match.Success)
                    fileText = fileText.Replace(match.ToString(), GetTitle());

                using (StreamWriter writer = new StreamWriter(dirProject + @"\MySite.html"))//короткая форма записи (включает try catch и dispose)
                {
                    writer.Write(fileText);
                }
                this.DataBind();//для привязки данных
                //Process.Start(dirProject + @"\MySite.html");
                //Process.Start(dirProject + @"\MySite.html");
        */
    }

    protected void TextPreRender(object sender, EventArgs e)//срабатывает перед отрисовкой страницы
    {
        //TextBox1.Text = GetTitleFromHtml(fileHtmlPath);
        TextBox1.Text = GetTextFromHtml("//title");//title
        //BannerHeaderTextArea.InnerHtml = GetBannerHeaderFromHtml(fileHtmlPath);
       // BannerHeaderTextArea.InnerHtml = GetTextFromHtml("//div[@class='banner_text']//h1");//header of the banner
        BannerHeaderTextArea.InnerHtml = GetTextFromHtml("//h1[@id='banner_title']");
        Bullet1TextArea.InnerHtml = GetBulletTextFromHtml("banner_bul1");//content of bullet 1
        Bullet2TextArea.InnerHtml = GetBulletTextFromHtml("banner_bul2");//content of bullet 2
        Bullet3TextArea.InnerHtml = GetBulletTextFromHtml("banner_bul3");//content of bullet 3
        Bullet4TextArea.InnerHtml = GetBulletTextFromHtml("banner_bul4");//content of bullet 4
        //BannerTextArea.InnerHtml = GetBannerTextFromHtml();
        BannerTextArea.InnerHtml = GetTextFromHtml("//p[@class='text_on_banner']"); //text on banner
        //TextArea4.InnerText = bannerBullet2.InnerHtml;
        CardBlockTextArea1.InnerHtml = GetTextFromHtml("//p[@id='card1']");//text of cardblock 1
        CardBlockTextArea2.InnerHtml = GetTextFromHtml("//p[@id='card2']");//text of cardblock 2
        CardBlockTextArea3.InnerHtml = GetTextFromHtml("//p[@id='card3']");//text of cardblock 3
        CardBlockHeaderTextArea.InnerHtml = GetTextFromHtml("//h2[@id='card_image_block_header']");//header of the cadrblock
        TextAreaImageBlockHeader1.InnerHtml = GetTextFromHtml("//h5[@id='card-title1']");//textHeader of imageCard1
        TextAreaImageBlockHeader2.InnerHtml = GetTextFromHtml("//h5[@id='card-title2']");//textHeader of imageCard2
        TextAreaImageBlockHeader3.InnerHtml = GetTextFromHtml("//h5[@id='card-title3']");//textHeader of imageCard3
        CardDigitTextarea1.InnerHtml = GetTextFromHtml("//p[@id='card_digit1']");//text of digitcardblock 1
        CardDigitTextarea2.InnerHtml = GetTextFromHtml("//p[@id='card_digit2']");//text of digitcardblock 2
        CardDigitTextarea3.InnerHtml = GetTextFromHtml("//p[@id='card_digit3']");//text of digitcardblock 3
        CardDigitHeaderTextarea.InnerHtml = GetTextFromHtml("//h2[@id='card_digit_block_header']");//header of the digital cadrblock
        VarNumberCardBlockTextarea.InnerHtml = GetTextFromHtml("//h2[@id='var_num_card_block']");//header of the cadrblock variabling numbers
        VarNumberCardNumberTextarea1.InnerHtml = GetTextFromHtml("//p[@id='var_num_number1']");//text of variabling number on card1
        VarNumberCardTextarea1.InnerHtml = GetTextFromHtml("//p[@id='var_num_text1']");//main text on variabling number card1
        VarNumberCardNumberTextarea2.InnerHtml = GetTextFromHtml("//p[@id='var_num_number2']");//text of variabling number on card2
        VarNumberCardTextarea2.InnerHtml = GetTextFromHtml("//p[@id='var_num_text2']");//main text on variabling number card2
        VarNumberCardNumberTextarea3.InnerHtml = GetTextFromHtml("//p[@id='var_num_number3']");//text of variabling number on card3
        VarNumberCardTextarea3.InnerHtml = GetTextFromHtml("//p[@id='var_num_text3']");//main text on variabling number 
        BannerCheckBox.Checked = CheckBoxChecking(FileHtmlPath, "//section[@id='banner_block']");//banner block's visibility status
        CardImageBlockCheckBox.Checked = CheckBoxChecking(FileHtmlPath, "//section[@id='card_image_block']");//banner block's visibility status
        CardDigitCheckBox.Checked = CheckBoxChecking(FileHtmlPath, "//section[@id='card_digital_block']");//banner block's visibility status
        VarNumberCheckBox.Checked = CheckBoxChecking(FileHtmlPath, "//section[@id='var_num_block']");//banner block's visibility status


    }

    protected void ButtonFixFileUpload_Click(object sender, EventArgs e)
    {
        ChangeImage(FileUpload1, "//link[@rel='icon']", @"href");//изменение фавиконки
        //ChangeIcon(FileUpload1, "//link[@rel='icon']"); //faviconka
            //fileText = fileText.Replace(titleNode.InnerText, GetTitle());

/*        using (StreamWriter writer = new StreamWriter(dirProject + @"\MySite.html"))//короткая форма записи (включает try catch и dispose)
        {
            writer.Write(fileText);
        }
*/
    }

    protected void RadioButton_CheckedChanged(object sender, EventArgs e)//radiobuttons in block with text and bullits
    {
        if (RadioButtonText.Checked)
        {
            Bullet1TextArea.Disabled = true;
            Bullet2TextArea.Disabled = true;
            Bullet3TextArea.Disabled = true;
            Bullet4TextArea.Disabled = true;
            BannerTextArea.Disabled = false;
            //TextBox3.Enabled = false;
            //TextBox4.Enabled = false;
            //TextBox5.Enabled = false;
        }
        else
        {
            BannerTextArea.Disabled = true;
            Bullet1TextArea.Disabled = false;
            Bullet2TextArea.Disabled = false;
            Bullet3TextArea.Disabled = false;
            Bullet4TextArea.Disabled = false;

        }
    }

    protected void CardImageSaveButton1_Click(object sender, EventArgs e) //SAVE-button of the first image card
    {
        HtmlDocument doc = new HtmlDocument();
        doc.Load(FileHtmlPath);//загрузка хтмл-файла сайта
        HtmlNode node = doc.DocumentNode.SelectSingleNode("//p[@id='card1']");//text of card
        node.InnerHtml = GetTextAreaFromForm(CardBlockTextArea1);
        HtmlNode headerImageCardBlockNode = doc.DocumentNode.SelectSingleNode("//h5[@id='card-title1']");//tag with header //div[@class='card-body']//h5
        headerImageCardBlockNode.InnerHtml = GetTextAreaFromForm(TextAreaImageBlockHeader1);
        if (RadioButtonWithoutHeader.Checked)
        {
            headerImageCardBlockNode.SetAttributeValue("style", "display: none");
        }
        doc.Save(FileHtmlPath);
    }
    protected void CardImageSaveButton2_Click(object sender, EventArgs e)//SAVE-button of the second image card
    {
        HtmlDocument doc = new HtmlDocument();
        doc.Load(FileHtmlPath);//загрузка хтмл-файла сайта
        HtmlNode node = doc.DocumentNode.SelectSingleNode("//p[@id='card2']");//text of card
        node.InnerHtml = GetTextAreaFromForm(CardBlockTextArea2);
        HtmlNode headerImageCardBlockNode = doc.DocumentNode.SelectSingleNode("//h5[@id='card-title2']");//tag with header
        headerImageCardBlockNode.InnerHtml = GetTextAreaFromForm(TextAreaImageBlockHeader2);
        if (RadioButtonWithoutHeader.Checked)
        {
            headerImageCardBlockNode.SetAttributeValue("style", "display: none");
        }
        doc.Save(FileHtmlPath);
    }
    protected void CardImageSaveButton3_Click(object sender, EventArgs e)//SAVE-button of the third image card
    {
        HtmlDocument doc = new HtmlDocument();
        doc.Load(FileHtmlPath);//file of the site load
        HtmlNode node = doc.DocumentNode.SelectSingleNode("//p[@id='card3']");//text of card
        node.InnerHtml = GetTextAreaFromForm(CardBlockTextArea3);
        HtmlNode headerImageCardBlockNode = doc.DocumentNode.SelectSingleNode("//h5[@id='card-title3']");//tag with header
        headerImageCardBlockNode.InnerHtml = GetTextAreaFromForm(TextAreaImageBlockHeader3);
        if (RadioButtonWithoutHeader.Checked)
        {
            headerImageCardBlockNode.SetAttributeValue("style", "display: none");
        }
        doc.Save(FileHtmlPath);
    }

    protected void CardImageBlockHeaderButton_Click(object sender, EventArgs e)
    {
        if (RadioButtonWithoutHeader.Checked)
        {
            BlockVisibility("//h5[@id='card-title1']", "off");//не отображать заголовок карточки
            BlockVisibility("//h5[@id='card-title2']", "off");
            BlockVisibility("//h5[@id='card-title3']", "off");
        }
        else
        {
            BlockVisibility("//h5[@id='card-title1']", "on");//отображать заголовок карточки
            HtmlTextChangerWithTypograph(TextAreaImageBlockHeader1, "//h5[@id='card-title1']");
            BlockVisibility("//h5[@id='card-title2']", "on");
            BlockVisibility("//h5[@id='card-title3']", "on");

        }
        HtmlTextChangerWithTypograph(CardBlockHeaderTextArea, "//h2[@id='card_image_block_header']");
    }

    void HtmlTextChangerWithTypograph(HtmlTextArea formTextArea, string xPath)//rewrites text from formTextArea on form to xPath in html with Lebedev's Polygraph
    {
        HtmlDocument doc = new HtmlDocument();
        doc.Load(FileHtmlPath);//file of the site load
        HtmlNode node = doc.DocumentNode.SelectSingleNode(xPath);//text in html
        //node.InnerHtml = textArea.InnerText;
        node.InnerHtml = GetTextAreaFromForm(formTextArea);
        doc.Save(FileHtmlPath);
    }

    void HtmlTextChangerWithTypograph(HtmlTextArea formTextArea1, string xPath1, HtmlTextArea formTextArea2, string xPath2)//rewrites text from formTextArea on form to xPath in html with Lebedev's Polygraph
    {
        HtmlDocument doc = new HtmlDocument();
        doc.Load(FileHtmlPath);//file of the site load
        HtmlNode node = doc.DocumentNode.SelectSingleNode(xPath1);//text in html
        //node.InnerHtml = textArea.InnerText;
        node.InnerHtml = GetTextAreaFromForm(formTextArea1);
        node = doc.DocumentNode.SelectSingleNode(xPath2);
        node.InnerHtml = GetTextAreaFromForm(formTextArea2);
        doc.Save(FileHtmlPath);
    }

    /********обработчики изменения картинок в блоке карточек с картинками*************/
    protected void ButtonCard1_Click(object sender, EventArgs e)
    {

        if(FileUploadImageCardBlock1.HasFile)
            ChangeImage(FileUploadImageCardBlock1, "//img[@id='imageCard1']", @"src");
    }

    protected void ButtonCard2_Click(object sender, EventArgs e)
    {
        ChangeImage(FileUploadImageCardBlock2, "//img[@id='imageCard2']", @"src");
    }

    protected void ButtonCard3_Click(object sender, EventArgs e)
    {
        ChangeImage(FileUploadImageCardBlock3, "//img[@id='imageCard3']", @"src");
    }
/******обработчики изменения картинок в блоке карточек с картинками************/
/******радиокнопки отображения/скрытия заголовка в блоке с картинками*******************************/
    protected void RadioButtonCardImageHeader_CheckedChanged(object sender, EventArgs e)
    {
        if (RadioButtonWithoutHeader.Checked)
        {
            TextAreaImageBlockHeader1.Disabled = true;
            TextAreaImageBlockHeader2.Disabled = true;
            TextAreaImageBlockHeader3.Disabled = true;
        }
        else
        {
            TextAreaImageBlockHeader1.Disabled = false;
            TextAreaImageBlockHeader2.Disabled = false;
            TextAreaImageBlockHeader3.Disabled = false;
        }
/******радиокнопки отображения/скрытия заголовка в блоке с картинками*******************************/
    }


    protected void CardDigitSaveButton1_Click(object sender, EventArgs e)
    {
        HtmlTextChangerWithTypograph(CardDigitTextarea1, "//p[@id='card_digit1']");//rewrite text from CardDigitTextarea1 to "//p[@id='card_digit1']"
    }

    protected void CardDigitSaveButton2_Click(object sender, EventArgs e)
    {
        HtmlTextChangerWithTypograph(CardDigitTextarea2, "//p[@id='card_digit2']");
    }

    protected void CardDigitSaveButton3_Click(object sender, EventArgs e)
    {
        HtmlTextChangerWithTypograph(CardDigitTextarea3, "//p[@id='card_digit3']");
    }

    protected void CardDigitBlockHeaderSaveButton_Click(object sender, EventArgs e)
    {
        HtmlTextChangerWithTypograph(CardDigitHeaderTextarea, "//h2[@id='card_digit_block_header']");
    }

    protected void VarNumberCardBlockHeaderSaveButton_Click(object sender, EventArgs e)
    {
        HtmlTextChangerWithTypograph(VarNumberCardBlockTextarea, "//h2[@id='var_num_card_block']");
    }


    protected void VarNumberCardSaveButton1_Click(object sender, EventArgs e)
    {
        HtmlTextChangerWithTypograph(VarNumberCardTextarea1, "//p[@id='var_num_text1']", VarNumberCardNumberTextarea1, "//p[@id='var_num_number1']");
    }

    protected void VarNumberCardSaveButton2_Click(object sender, EventArgs e)
    {
        HtmlTextChangerWithTypograph(VarNumberCardTextarea2, "//p[@id='var_num_text2']", VarNumberCardNumberTextarea2, "//p[@id='var_num_number2']");
    }

    protected void VarNumberCardSaveButton3_Click(object sender, EventArgs e)
    {
        HtmlTextChangerWithTypograph(VarNumberCardTextarea3, "//p[@id='var_num_text3']", VarNumberCardNumberTextarea3, "//p[@id='var_num_number3']");
    }

    protected void BlockVisibilityCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        bool isColor = false;
        //string color = "#ffffff";
        if (BannerCheckBox.Checked)
        {
            //BlockVisibility("//section[@id='banner_block']", "on");
            isColor = !isColor;
            if (isColor)
                SetBlockColorAndVisibility("//section[@id='banner_block']", "#f1f1f1", "on");
            else
                SetBlockColorAndVisibility("//section[@id='banner_block']", "#ffffff", "on");
            //change style.css
        }
        else
        {
            SetBlockColorAndVisibility("//section[@id='banner_block']", "#ffffff", "off");
        }
        if (CardImageBlockCheckBox.Checked)
        {
            //BlockVisibility("//section[@id='card_image_block']", "on");
            isColor = !isColor;
            if (isColor)
                SetBlockColorAndVisibility("//section[@id='card_image_block']", "#f1f1f1", "on");
            else
                SetBlockColorAndVisibility("//section[@id='card_image_block']", "#ffffff", "on");
            //change style.css
        }
        else
        {
            SetBlockColorAndVisibility("//section[@id='card_image_block']", "#ffffff", "off");
        }
        if (CardDigitCheckBox.Checked)
        {
            //BlockVisibility("//section[@id='card_digital_block']", "on");
            isColor = !isColor;
            if (isColor)
                SetBlockColorAndVisibility("//section[@id='card_digital_block']", "#f1f1f1", "on");
            else
                SetBlockColorAndVisibility("//section[@id='card_digital_block']", "#ffffff", "on");
            //change style.css
        }
        else
        {
            SetBlockColorAndVisibility("//section[@id='card_digital_block']", "#ffffff", "off");
        }
        if (VarNumberCheckBox.Checked)
        {
            //BlockVisibility("//section[@id='var_num_block']", "on");
            isColor = !isColor;
            if (isColor)
                SetBlockColorAndVisibility("//section[@id='var_num_block']", "#f1f1f1", "on");
            else
                SetBlockColorAndVisibility("//section[@id='var_num_block']", "#ffffff", "on");
            //change style.css
        }
        else
        {
            //BlockVisibility("//section[@id='var_num_block']", "off");
            SetBlockColorAndVisibility("//section[@id='var_num_block']", "#ffffff", "off");

        }
/*        if (tableSectionCheckBox.Checked)
        {
            //BlockVisibility("//section[@id='var_num_block']", "on");
            isColor = !isColor;
            if (isColor)
                SetBlockColorAndVisibility("//section[@id='var_num_block']", "#f1f1f1", "on");
            else
                SetBlockColorAndVisibility("//section[@id='var_num_block']", "#ffffff", "on");
            //change style.css
        }
        else
        {
            //BlockVisibility("//section[@id='var_num_block']", "off");
            SetBlockColorAndVisibility("//section[@id='var_num_block']", "#ffffff", "off");

        }*/
    }
}
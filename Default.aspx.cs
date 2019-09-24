using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using WebSite11;

public partial class _Default : Page 
{ 
    //public string SiteName { get; set; } 

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SitePage sp = new SitePage();
        

        Response.Redirect("~/MyPage.aspx?SiteName=" + sp.SiteDirName);
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        //SitePage sp = new SitePage("MySite");

    }
}
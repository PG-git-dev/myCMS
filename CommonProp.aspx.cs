using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSite11;

public partial class CommonProp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SendMail sendMail = new SendMail(TextBox1.Text, TextBox2.Text, TextBox3.Text);
        sendMail.MySendMail();
    }
}
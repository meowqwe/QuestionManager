using QBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AdminMaster : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["CurUser"] != null)
        {
            User user = (User)Session["CurUser"];
            lblUserName.Text = user.UuserName1;
        }
        else
        {
            Response.Redirect("../Login.aspx");
        }
    }
    protected void LinkButton1_Click(object sender,EventArgs e)
    {
        //清空Session中的数据
        Session["CurUser"] = null;
        Response.Redirect("../Login.aspx");
    }
}

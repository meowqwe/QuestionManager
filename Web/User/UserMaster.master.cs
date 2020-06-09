using QBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_UserMaster : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //判断用户是否非法访问
        if (Session["CurUser"] != null)
        {
            //从Session中取出当前用户信息并显示
            User user = (User)Session["CurUser"];
            lblUserName.Text = user.UuserName1;
        }
        else
        {
            //跳转到登录页面
            Response.Redirect("../Login.aspx");
        }
    }
    //注销
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        //清空Session中的数据
        Session["CurUser"] = null;
        Response.Redirect("../Login.aspx");
    }
}

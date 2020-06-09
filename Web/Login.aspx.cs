using QBBLL;
using QBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
    }
    protected void btnLogin_Click(object sender,EventArgs e)
    {
        string strName = txtName.Text;
        string strPwd = txtPwd.Text;
        int role = 0;
        if (rdAdmin.Checked)
        {
            role = 1;
        }
        //根据用户名获取Userdetail中的用户对象
        User user = UserManager.GetUserByUserName(strName);
        if (user != null)
        {
            //检查用户输入的数据是否正确
            if (strPwd.Equals(user.UpassWord1) && role == user.Urole1)
            {
                //将当前用户保存到Session中
                Session.Add("CurUser", user);
                if (role == 0)
                {
                    //跳转到用户主页
                    Response.Redirect("~/User/UserMain.aspx");
                }
                else
                {
                    //跳转到管理员主页
                    Response.Redirect("~/Admin/AdminMain.aspx");
                }
            }
            else
            {
                Response.Write("<Script>alert('密码或权限不正确！')</Script>");
            }
        }
        else
        {
            Response.Write("<Script>alert('没有该用户！')</Script>");
        }

    }
    protected void btnReset_Click(object sender, EventArgs e)
    {
        txtName.Text = "";
        txtPwd.Text = "";
        rdUser.Checked = true;
    }
}
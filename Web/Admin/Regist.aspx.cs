using QBBLL;
using QBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Regist : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        string strName = txtName.Text;
        string strPwd = txtPwd.Text;
        string strSex = "男";
        if (RadioButton2.Checked)
        {
            strSex = "女";
        }
        int role = 0;
        if (rdAdmin.Checked)
        {
            role = 1;
        }
        string strClass = txtClass.Text;
        string strGrade = txtGrade.Text;
        //根据用户名查询用户，确保用户名不重复
        if (UserManager.GetUserByUserName(strName) != null)
        {
            Response.Write("<Script>alert('此用户名已被使用，请重新填写');</Script>");
            ResetText();
            txtName.Focus();
            return;
        }
        //将信息封装到User对象中
        User user = new User();
        user.UuserName1 = strName;
        user.UpassWord1 = strPwd;
        user.Urole1 = role;
        user.Usex1 = strSex;
        user.Uclass1 = strClass;
        user.Ugrade1 = strGrade;
        //添加用户
        if (UserManager.AddUser(user) != null)
        {
            Response.Write("<Script>alert('注册成功，请记住您的信息！');</Script>");
        }
        else
        {
            Response.Write("<Script>alert('注册失败');</Script>");
        }
    }
    protected void btnReset_Click(object sender, EventArgs e)
    {
        ResetText();
    }
    private void ResetText()
    {
        txtName.Text = "";
        txtPwd.Text = "";
        txtClass.Text = "";
        txtGrade.Text = "";
        rdUser.Checked = true;
        RadioButton1.Checked = true;
    }
}
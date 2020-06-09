using QBBLL;
using QBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_UploadTitle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
            User user = (User)Session["CurUser"];
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        string strStem = txtStem.Text;
        string strSubject = txtSubject.Text;
        string[] str = { txtA.Text, txtB.Text, txtC.Text, txtD.Text };
        string strAnswer = txtAnswer.Text;
        string Type="选择";
        if (rdXuanze.Checked)
        {
            Type = "选择";
            
        }
        if (rdTiankong.Checked)
        {
            Type = "填空";
        }
        if (rdPanduan.Checked)
        {
            Type = "判断";
        }
        if (rdJianda.Checked)
        {
            Type = "简答";
        }
        //信息封装
        title title = new title();
        title.Tstem1 = strStem;
        title.Tsubject1 = strSubject;
        title.Tanswer1 = strAnswer;
        title.Ttype1 = Type;
        title=TitleManager.AddTitle(title);
        if (title != null)
        {
            //添加选项
            if (Type.Equals("选择"))
            {
                for (int i = 0; i < 4; i++)
                {
                    options options = new options();
                    if (!str[i].Equals(""))
                    {
                        options.Oname1 = i.ToString();
                        options.Otext1 = str[i];
                        options = OptionManager.AddOption(options);
                        TitleManager.TitleAppend(options, title);
                    }

                }
                Response.Write("<Script>alert('添加成功');</Script>");
            }
        }
        else
        {
            Response.Write("<Script>alert('添加失败');</Script>");
        }
    }
}
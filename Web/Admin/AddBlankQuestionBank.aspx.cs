using QBBLL;
using QBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AddBlankQuestionBank : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        User user = (User)Session["CurUser"];
    }

    protected void Submit_Click(object sender, EventArgs e)
    {
        string strQBname = txtQBname.Text;
        QuestionBank questionBank = QuestionBankManager.CreateBlankQuestionBank(strQBname);
        if (questionBank != null)
        {
            Response.Write("<Script>alert('创建成功');</Script>");
        }
        else
        {
            Response.Write("<Script>alert('创建失败');</Script>");
        }
    }
}
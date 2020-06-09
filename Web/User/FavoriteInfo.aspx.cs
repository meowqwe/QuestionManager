using QBBLL;
using QBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_FavoriteInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        User user = (User)Session["CurUser"];
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        string QBname = ((LinkButton)sender).CommandArgument.ToString();
        QuestionBank questionBank = QuestionBankManager.GetQuestionBankByQBnum(QBname);
        Session.Add("CurQuestionBank", questionBank);
        Response.Redirect("Exercises");
    }
}
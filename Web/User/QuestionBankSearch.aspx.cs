using QBBLL;
using QBDAL;
using QBModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_QuestionBankSearch : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        User user = (User)Session["CurUser"];
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        string sql = "SELECT * FROM questionbank WHERE QBname=" + txtQBname.Text;
        odsQuestionBank.SelectParameters["safeSql"].DefaultValue = sql;
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        string QBname = ((LinkButton)sender).CommandArgument.ToString();
        QuestionBank questionBank = QuestionBankManager.GetQuestionBankByQBnum(QBname);
        Session.Add("CurQuestionBank", questionBank);
        Response.Redirect("Exercises1.aspx");
    }

    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        string QBname = ((LinkButton)sender).CommandArgument.ToString();
        QuestionBank questionBank = QuestionBankManager.GetQuestionBankByQBnum(QBname);
        Session.Add("CurQuestionBank", questionBank);
        Response.Redirect("FavoriteQB.aspx");
    }
}
using QBBLL;
using QBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_FavoriteQB : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        User user = (User)Session["CurUser"];
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        QuestionBank questionBank = (QuestionBank)Session["CurQuestionBank"];
        string strFname = txtFname.Text;
        Favorite favorite = FavoriteManager.GetFavoriteByName(strFname);
        if (favorite != null)
        {
            FavoriteManager.QuestionBankAppend(questionBank, favorite);
        }
        else
        {
            favorite = FavoriteManager.CreateBlankFavorite(strFname);
            FavoriteManager.QuestionBankAppend(questionBank, favorite);
        }
        Response.Write("<Script>alert('收藏成功！')</Script>");

    }
}
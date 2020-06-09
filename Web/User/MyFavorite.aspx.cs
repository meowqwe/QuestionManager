using QBBLL;
using QBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_Favorite : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        User user = (User)Session["CurUser"];
        
    }

    protected void BtnCreate_Click(object sender, EventArgs e)
    {
        string strName = txtName.Text;
        Favorite favorite = new Favorite();
        favorite.Fname1 = strName;
        favorite.QBnumber1 = 0;
        favorite=FavoriteManager.CreateBlankFavorite(favorite);
        if (favorite != null)
        {
            Response.Write("<Script>alert('添加成功！');</Script>");
        }
        else
        {
            Response.Write("<Script>alert('添加失败！');</Script>");
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        string Fname = ((LinkButton)sender).CommandArgument.ToString();
        Favorite favorite = FavoriteManager.GetFavoriteByName(Fname);
        Session.Add("CurFavorite", favorite);
        Response.Redirect("FavoriteInfo.aspx");
    }
}
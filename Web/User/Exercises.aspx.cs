using QBBLL;
using QBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_Exercises : System.Web.UI.Page
{
    private QuestionBank questionbank;
    private IList<title> tlist;
    private int titlenum;

    public QuestionBank Questionbank { get => questionbank= (QuestionBank)Session["CurQuestionBank"]; set => questionbank = value; }
    public IList<title> Tlist { get => tlist=QuestionBankManager.GetAllTitle(Questionbank); set => tlist = value; }
    public int Titlenum { get => titlenum; set => titlenum = value; }

    protected void Page_Load(object sender, EventArgs e)
    {
        Titlenum = 0;
    }

    protected void NEXT_Click(object sender, EventArgs e)
    {

    }

    protected void Submit_Click(object sender, EventArgs e)
    {

    }
    protected void LoadTitle(int Titlenum)
    {
        lblType.Text = Tlist[Titlenum].Ttype1;
        lblSubject.Text = Tlist[Titlenum].Tsubject1;
        lblStem.Text = Tlist[Titlenum].Tstem1;
        if (Tlist[Titlenum].Ttype1.Equals("选择"))
        {
            options options = new options();
        }
    }
}
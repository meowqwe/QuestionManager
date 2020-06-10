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
        LoadTitle(Titlenum);
    }

    protected void NEXT_Click(object sender, EventArgs e)
    {
        Random ran = new Random();
        int MaxInt = Questionbank.QBqnum1;
        Titlenum = ran.Next(MaxInt);
        LoadTitle(Titlenum);
    }

    protected void Submit_Click(object sender, EventArgs e)
    {
        string strAnswer = txtAnswer.Text;
        if (strAnswer.Equals(Tlist[Titlenum].Tanswer1))
        {
            Response.Write("<Script>alert('答案正确！')</Script>");
        }
        else
        {
            Response.Write("<Script>alert('答案错误！')</Script>");
            lblAnswer.Text = Tlist[Titlenum].Tanswer1;
        }
    }
    protected void LoadTitle(int Titlenum)
    {
        lblType.Text = Tlist[Titlenum].Ttype1;
        lblSubject.Text = Tlist[Titlenum].Tsubject1;
        lblStem.Text = Tlist[Titlenum].Tstem1;
        if (Tlist[Titlenum].Ttype1.Equals("选择"))
        {
            options options = new options();
            IList<options> Olist = TitleManager.GetAllOptions(Tlist[Titlenum]);
            for(int i = 0; i < 4; i++)
            {
                AddOptions(i, Olist);
            }

        }
    }
    protected void AddOptions(int optionNum,IList<options> Olist)
    {
        switch (optionNum)
        {
            case 0:
                lblA.Text = "A";
                lblAtext.Text = Olist[0].Otext1;
                break;
            case 1:
                lblB.Text = "B";
                lblBtext.Text = Olist[0].Otext1;
                break;
            case 2:
                lblC.Text = "C";
                lblCtext.Text = Olist[0].Otext1;
                break;
            case 3:
                lblD.Text = "D";
                lblDtext.Text = Olist[0].Otext1;
                break;

        }
    }
}
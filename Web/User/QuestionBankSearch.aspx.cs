﻿using QBModels;
using System;
using System.Collections.Generic;
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
        string sql = "SELECT * FROM @questionbank";
        SqlParameter[] para = new SqlParameter[]
        {
            new SqlParameter("@questionbank","questionbank")
        };
        
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {

    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace blogAsp
{
    public partial class AdminDeneyimEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.tbl_deneyimTableAdapter dtDeneyim = new DataSet1TableAdapters.tbl_deneyimTableAdapter();
            dtDeneyim.DeneyimEkle(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text);
            Response.Redirect("AdminDeneyimler.aspx");
            
        }
    }
}
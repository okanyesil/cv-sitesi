﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace blogAsp
{
    public partial class hakkimda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {


                DataSet1TableAdapters.tbl_hakkimdaTableAdapter dt = new DataSet1TableAdapters.tbl_hakkimdaTableAdapter();
                TextBox1.Text = dt.HakkimdaListele()[0].AD;
                TextBox2.Text = dt.HakkimdaListele()[0].SOYAD;
                TextBox3.Text = dt.HakkimdaListele()[0].ADRESS;
                TextBox4.Text = dt.HakkimdaListele()[0].MAIL;
                TextBox5.Text = dt.HakkimdaListele()[0].TELEFON;
                TextBox6.Text = dt.HakkimdaListele()[0].KISANOT;
                TextBox7.Text = dt.HakkimdaListele()[0].FOTOGRAF;
            }



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.tbl_hakkimdaTableAdapter dt1 = new DataSet1TableAdapters.tbl_hakkimdaTableAdapter();
            dt1.HakkimdaGuncelle(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text);
            Response.Redirect("default.aspx");
        }
    }
}
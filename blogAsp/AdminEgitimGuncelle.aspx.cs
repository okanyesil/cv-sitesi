using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace blogAsp
{
    public partial class AdminEgitimGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                int id = Convert.ToInt16(Request.QueryString["ID"]);
                DataSet1TableAdapters.tbl_egitimTableAdapter dtegitim = new DataSet1TableAdapters.tbl_egitimTableAdapter();
                TextBox1.Text = dtegitim.EgitimGetir(Convert.ToInt16(id))[0].BASLIK;
                TextBox2.Text = dtegitim.EgitimGetir(Convert.ToInt16(id))[0].ALT_BASLIK;
                TextBox3.Text = dtegitim.EgitimGetir(Convert.ToInt16(id))[0].ACIKLAMA;
                TextBox4.Text = dtegitim.EgitimGetir(Convert.ToInt16(id))[0].GNOT;
                TextBox5.Text = dtegitim.EgitimGetir(Convert.ToInt16(id))[0].TARIH;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);
            DataSet1TableAdapters.tbl_egitimTableAdapter dtegitim = new DataSet1TableAdapters.tbl_egitimTableAdapter();
            dtegitim.EgitimGuncelle(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, Convert.ToInt16(id));

            Response.Redirect("AdminEgitimHayati.aspx");
        }
    }
}
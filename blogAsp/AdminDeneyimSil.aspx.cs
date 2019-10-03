using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace blogAsp
{
    public partial class AdminDeneyimSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);
            DataSet1TableAdapters.tbl_deneyimTableAdapter dtDeneyim =new DataSet1TableAdapters.tbl_deneyimTableAdapter();
            Repeater1.DataSource = dtDeneyim.SilinecekDeneyimListele(Convert.ToInt16(id));
            Repeater1.DataBind();


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);
            DataSet1TableAdapters.tbl_deneyimTableAdapter dtDeneyimSil = new DataSet1TableAdapters.tbl_deneyimTableAdapter();
            dtDeneyimSil.DeneyimSil(Convert.ToInt16(id));
            Response.Redirect("AdminDeneyimler.aspx");

        }
    }
}
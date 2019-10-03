using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace blogAsp
{
    public partial class AdminYetenekSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["ID"];
            DataSet1TableAdapters.tbl_yeteneklerTableAdapter dtYetenek = new DataSet1TableAdapters.tbl_yeteneklerTableAdapter();
            TextBox1.Text = dtYetenek.YetenekAl(Convert.ToInt16(id))[0].YETENEK;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String id = Request.QueryString["ID"];
            DataSet1TableAdapters.tbl_yeteneklerTableAdapter dtYenek = new DataSet1TableAdapters.tbl_yeteneklerTableAdapter();
            dtYenek.YetenekSil(Convert.ToInt16(id));
            Response.Redirect("AdminYetenekListesi.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace blogAsp
{
    public partial class AdminOdulListele : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            DataSet1TableAdapters.tbl_odullerTableAdapter dtOdul = new DataSet1TableAdapters.tbl_odullerTableAdapter();
            Repeater1.DataSource = dtOdul.OdulListele();
            Repeater1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminOdulEkle.aspx");
        }
    }
}
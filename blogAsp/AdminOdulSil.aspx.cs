using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace blogAsp
{
    public partial class AdminOdulSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["ID"];
            DataSet1TableAdapters.tbl_odullerTableAdapter dtOdul = new DataSet1TableAdapters.tbl_odullerTableAdapter();
            TextBox1.Text = dtOdul.OdulGetir(Convert.ToInt16(id))[0].ODULLER;


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string id = Request.QueryString["ID"];
            DataSet1TableAdapters.tbl_odullerTableAdapter dtOduller = new DataSet1TableAdapters.tbl_odullerTableAdapter();
            dtOduller.OdulSil(Convert.ToInt16(id));
            Response.Redirect("AdminOdulListele.aspx");
            
        }
    }
}
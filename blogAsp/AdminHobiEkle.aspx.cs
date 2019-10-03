using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace blogAsp
{
    public partial class AdminHobiEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.tbl_hobilerTableAdapter dtHobi = new DataSet1TableAdapters.tbl_hobilerTableAdapter();
            dtHobi.HobiEkle(TextBox1.Text);
            Response.Redirect("AdminHobilerimListele.aspx");
        }
    }
}
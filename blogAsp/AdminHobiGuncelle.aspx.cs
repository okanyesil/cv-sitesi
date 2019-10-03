using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace blogAsp
{
    public partial class AdminHobiGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {

            
            String id = Request.QueryString["ID"];
            DataSet1TableAdapters.tbl_hobilerTableAdapter dtHobi = new DataSet1TableAdapters.tbl_hobilerTableAdapter();
            TextBox1.Text = dtHobi.HobiGetir(Convert.ToInt16(id))[0].HOBI;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String id = Request.QueryString["ID"];
            DataSet1TableAdapters.tbl_hobilerTableAdapter dtHobi = new DataSet1TableAdapters.tbl_hobilerTableAdapter();
            dtHobi.HobiGuncelle(TextBox1.Text, Convert.ToInt16(id));
            Response.Redirect("AdminHobilerimListele.aspx");
        }
    }
}
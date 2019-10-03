using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace blogAsp
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            DataSet1TableAdapters.tbl_hakkimdaTableAdapter dt = new DataSet1TableAdapters.tbl_hakkimdaTableAdapter();
            Repeater1.DataSource = dt.HakkimdaListele();
            Repeater1.DataBind();
            DataSet1TableAdapters.tbl_deneyimTableAdapter dtDeneyim = new DataSet1TableAdapters.tbl_deneyimTableAdapter();
            Repeater2.DataSource = dtDeneyim.deneyimListele();
            Repeater2.DataBind();
            DataSet1TableAdapters.tbl_egitimTableAdapter dtEgitim = new DataSet1TableAdapters.tbl_egitimTableAdapter();
            Repeater3.DataSource = dtEgitim.EgitimListele();
            Repeater3.DataBind();
            DataSet1TableAdapters.tbl_hobilerTableAdapter dtHobi = new DataSet1TableAdapters.tbl_hobilerTableAdapter();
            Repeater4.DataSource = dtHobi.HobiListele();
            Repeater4.DataBind();
            DataSet1TableAdapters.tbl_odullerTableAdapter dtOduller = new DataSet1TableAdapters.tbl_odullerTableAdapter();
            Repeater5.DataSource = dtOduller.OdulListele();
            Repeater5.DataBind();
            DataSet1TableAdapters.tbl_yeteneklerTableAdapter dtYetenek = new DataSet1TableAdapters.tbl_yeteneklerTableAdapter();
            Repeater6.DataSource = dtYetenek.YetenekListele();
            Repeater6.DataBind();


        }
    }
}
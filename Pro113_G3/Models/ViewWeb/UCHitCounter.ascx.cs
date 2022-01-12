using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pro113_G3.Models.ViewWeb
{
    public partial class UCHitCounter : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            object[] o = new object[2];
            o = new HitCount().GetCount();
            lblTodayVisit.Text = o[0].ToString();
            lblTotalVisit.Text = o[1].ToString();
        }
    }
}
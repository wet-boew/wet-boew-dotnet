using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GCIntranetTheme
{
    public partial class WetForm1 : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = WetForm1;
            Page.MetaDescription = "";
            base.Subject = "Citizenship; Immigration; Multiculturalism";
        }
    }
}
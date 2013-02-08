using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

namespace WET_BOEW_dotnet.App_Master
{
    public partial class BreadCrumb : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (CultureInfo.CurrentCulture.Name.Contains("fr"))
            {
                smpBC.SiteMapProvider = "FRSitemapProvider";
            }
            else
            {
                smpBC.SiteMapProvider = "ENSitemapProvider";
            }
        }
    }
}
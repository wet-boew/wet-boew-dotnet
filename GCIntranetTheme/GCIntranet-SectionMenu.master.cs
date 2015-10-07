using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GCIntranetTheme
{
    public partial class GCIntranet_SecondaryMenu : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Read the site title and home page from the custom web.config section.
            WetBoewConfiguration config = (WetBoewConfiguration)System.Configuration.ConfigurationManager.GetSection("WetBoewGroup/WetBoew");

            if (config != null)
            {
                HyperLinkSiteTitle.Text = string.Format("<span>{0}</span>", config.SiteName);
                HyperLinkSiteTitle.NavigateUrl = config.HomePage;
            }

            //TODO:  Show the subsite section if appropriate.
            //TODO:  Option to hide the search and language selection link.
            //TODO:  Option to hide the site menu and breadcrumb trail.
        }
    }
}
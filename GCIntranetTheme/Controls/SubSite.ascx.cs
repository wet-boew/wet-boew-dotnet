using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GCIntranetTheme.Controls
{
    public partial class SubSite : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //TODO:  Maybe the subsite name and link could be determined from a web.config in the sub-directory?
            //
            //<WetBoew breadcrumbTrail="true" search="true" siteMenu="true">
            //  <languages>
            //    <add name="English"  abbr="en" textDirection="ltr" default="true" homePage="~/subsite/index-en.aspx" siteName="Sub-site name" />
            //    <add name="Français" abbr="fr" textDirection="ltr"                homePage="~/subsite/index-fr.aspx" siteName="[FR] Sub-site name" />
            //  </languages>
            //</WetBoew
        }
    }
}
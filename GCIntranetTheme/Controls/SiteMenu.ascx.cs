using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GCIntranetTheme.Controls
{
    public partial class SiteMenu : System.Web.UI.UserControl
    {
        protected string myProvider;

        protected void Page_Load(object sender, EventArgs e)
        {
            //Set the sitemap provider.  Assuming that each provider is prefixed with the language abbreviation.
            string lang = ((BasePage)Page).Language;
            myProvider = string.Format("{0}HeaderSiteMapProvider", lang.ToUpper());
            SiteMapDataSource1.SiteMapProvider = myProvider;

            //Hide or show the site menu depending on the setting of WetBoewGroup/WetBoew/@showSiteMenu in web.config.
            WetBoewConfiguration config = WetBoewConfiguration.GetConfiguration();
            bool showSiteMenu = config.ShowSiteMenu;

            if (showSiteMenu)
            {
                this.PlaceHolderSiteMenu.Visible = true;
                this.PlaceHolderNoSiteMenu.Visible = false;
            }
            else
            {
                this.PlaceHolderSiteMenu.Visible = false;
                this.PlaceHolderNoSiteMenu.Visible = true;
            }
        }

        protected string SiteMenuFile
        {
            get
            {
                //REVIEW:  Should this be added to the custom config section of web.config?
                return string.Format("/wet-v4/ajax/sitemenu-{0}.html", ((BasePage)Page).Language);
            }
        }
    }
}
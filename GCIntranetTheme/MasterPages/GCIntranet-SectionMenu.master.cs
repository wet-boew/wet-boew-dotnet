using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GCIntranetTheme.MasterPages
{
    public partial class GCIntranet_SecondaryMenu : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Read the site title and home page from the custom web.config section.
            WetBoewConfiguration config = WetBoewConfiguration.GetConfiguration();
            LanguagesCollection myLanguagesSection = config.Languages as LanguagesCollection;
            string lang = ((BasePage)Page).Language;

            for (int i = 0; i < myLanguagesSection.Count; i++)
            {
                if (myLanguagesSection[i].Abbr == lang)
                {
                    HyperLinkSiteTitle.Text = string.Format("<span>{0}</span>", myLanguagesSection[i].SiteName);
                    HyperLinkSiteTitle.NavigateUrl = myLanguagesSection[i].HomePage;
                    break;
                }
            }

            //Hide the breadcrumbs depending on the setting of WetBoewGroup/WetBoew/@showBreadcrumbTrail in web.config.
            bool showBreadcrumbTrail = config.ShowBreadcrumbTrail;

            if (!showBreadcrumbTrail)
            {
                Breadcrumb.Visible = false;
            }

            //Hide the search depending on the setting of WetBoewGroup/WetBoew/@showSearch in web.config.
            bool showSearch = config.ShowSearch;

            if (!showSearch)
            {
                Search.Visible = false;
            }

            //Hide the language selection link(s) if the WetBoewGroup/WetBoew/Languages section only has one language defined.
            bool showLanguage = (config.Languages.Count > 1 ? true : false);

            if (!showLanguage)
            {
                LanguageSelection.Visible = false;
            }
        }

        protected string GetSignatureImage()
        {
            string lang = ((BasePage)Page).Language;

            if (lang == "fr")
            {
                return "./wet-v4/dist/assets/sig-blk-fr.svg";
            }
            else
            {
                return "./wet-v4/dist/assets/sig-blk-en.svg";
            }
        }
    }
}
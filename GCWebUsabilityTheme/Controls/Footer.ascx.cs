using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GCWebUsabilityTheme.Controls
{
    public partial class Footer : System.Web.UI.UserControl
    {
        protected string myProvider;

        protected void Page_Load(object sender, EventArgs e)
        {
            //Set the sitemap provider.  Assuming that each provider is prefixed with the language abbreviation.
            string lang = ((BasePage)Page).Language;
            myProvider = string.Format("{0}FooterSiteMapProvider", lang.ToUpper());
            SiteMapDataSource1.SiteMapProvider = myProvider;

            myProvider = string.Format("{0}Footer2SiteMapProvider", lang.ToUpper());
            SiteMapDataSource2.SiteMapProvider = myProvider;

            //Set the licence, transparency, and Canada.ca links.
            WetBoewConfiguration config = WetBoewConfiguration.GetConfiguration();
            LanguagesCollection myLanguagesSection = config.Languages as LanguagesCollection;

            for (int i = 0; i < myLanguagesSection.Count; i++)
            {
                if (myLanguagesSection[i].Abbr == ((BasePage)Page).Language)
                {
                    Terms.NavigateUrl = myLanguagesSection[i].LicencePage;
                    break;
                }
            }

            if (lang == "fr")
            {
                Trans.NavigateUrl = "http://www.tbs-sct.gc.ca/tbs-sct/common/trans-fra.asp";
                CanadaCa.NavigateUrl = "http://www.canada.ca/fr/index.html";
            }
            else
            {
                Trans.NavigateUrl = "http://www.tbs-sct.gc.ca/tbs-sct/common/trans-eng.asp";
                CanadaCa.NavigateUrl = "http://www.canada.ca/en/index.html";
            }

            Terms.Text = Localization.TemplateStrings.tmpl_terms;
            Trans.Text = Localization.TemplateStrings.tmpl_transparency;
        }
    }
}
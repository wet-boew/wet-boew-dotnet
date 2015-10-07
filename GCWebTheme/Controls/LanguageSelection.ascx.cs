using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GCWebTheme.Controls
{
    public partial class LanguageSelection : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SetLanguageSelection();

            //TODO:  Create a language selection link for each language defined in WetBoewGroup/WetBoew/Languages section?
        }

        /// <summary>
        /// Adjust the link on the language switcher to point to the page in the other language.
        /// </summary>
        /// <remarks>
        /// Current standard on the WET site is to use two-letter languages.
        /// The method below assumes only English and French will be available.
        /// No test is done to see if the translated page actually exists.
        /// </remarks>
        private void SetLanguageSelection()
        {
            //REVIEW:  Instead of using the url, maybe could use ((BasePage)Page).Language?
            string rawUrl = Request.RawUrl;

            if (rawUrl.Contains("-en."))
            {
                HyperLinkLanguage1.NavigateUrl = rawUrl.Replace("-en.", "-fr.");
                HyperLinkLanguage1.Text = "Français";
                HyperLinkLanguage1.Attributes.Remove("lang");
                HyperLinkLanguage1.Attributes.Add("lang", "fr");
            }
            else if (rawUrl.Contains("-fr."))
            {
                HyperLinkLanguage1.NavigateUrl = rawUrl.Replace("-fr.", "-en.");
                HyperLinkLanguage1.Text = "English";
                HyperLinkLanguage1.Attributes.Remove("lang");
                HyperLinkLanguage1.Attributes.Add("lang", "en");
            }
            else if (rawUrl.Contains("-eng."))
            {
                HyperLinkLanguage1.NavigateUrl = rawUrl.Replace("-eng.", "-fra.");
                HyperLinkLanguage1.Text = "Français";
                HyperLinkLanguage1.Attributes.Remove("lang");
                HyperLinkLanguage1.Attributes.Add("lang", "fr");
            }
            else if (rawUrl.Contains("-fra."))
            {
                HyperLinkLanguage1.NavigateUrl = rawUrl.Replace("-fra.", "-eng.");
                HyperLinkLanguage1.Text = "English";
                HyperLinkLanguage1.Attributes.Remove("lang");
                HyperLinkLanguage1.Attributes.Add("lang", "en");
            }
            else
            {
                //REVIEW: Assume no language extension is on the page and the default is English.
                HyperLinkLanguage1.NavigateUrl = rawUrl.Replace(".aspx", "-fr.aspx");
                HyperLinkLanguage1.Text = "Français";
                HyperLinkLanguage1.Attributes.Remove("lang");
                HyperLinkLanguage1.Attributes.Add("lang", "fr");
            }
        }
    }
}
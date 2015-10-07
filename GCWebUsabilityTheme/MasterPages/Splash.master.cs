using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace GCWebUsabilityTheme.MasterPages
{
    public partial class Splash : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                WetBoewConfiguration config = WetBoewConfiguration.GetConfiguration();
                LanguagesCollection myLanguagesSection = config.Languages as LanguagesCollection;

                string abbr = "";
                string title = "";
                string pageTitle = "";
                string headingTitle = "";

                for (int i = 0; i < myLanguagesSection.Count; i++)
                {
                    abbr = myLanguagesSection[i].Abbr;
                    title = TranslateTitles(abbr);
                    pageTitle = pageTitle + string.Format("{0} - {1} / ", title, myLanguagesSection[i].SiteName);

                    if (abbr != ((BasePage)Page).Language)
                    {
                        headingTitle = headingTitle + string.Format("<span lang='{0}'>{1} - {2}</span> / ", abbr, title, myLanguagesSection[i].SiteName);
                    }
                    else
                    {
                        headingTitle = pageTitle;
                    }
                }

                pageTitle = pageTitle.TrimEnd("/ ".ToArray());
                headingTitle = headingTitle.TrimEnd("/ ".ToArray());

                Page.Title = pageTitle;
                LiteralTitle.Text = headingTitle;

                //For this theme only, need a way to replace two "theme" css files with "theme-sp-pe" files.
                List<HtmlLink> oldLinks = new List<HtmlLink>(); 

                foreach (Control c in Page.Header.Controls)
                {
                    if (c is HtmlLink && (c as HtmlLink).Attributes["rel"] == "stylesheet")
                    {
                        oldLinks.Add(c as HtmlLink);
                    }
                }

                foreach (HtmlLink oldLink in oldLinks)
                {
                    oldLink.Href = oldLink.Href.Replace("theme", "theme-sp-pe");
                }

            }
        }

        /// <summary>
        /// Get translations for "Language selection".
        /// </summary>
        /// <param name="lang">The abbreviation of the target language.</param>
        /// <returns>"Language selection" translated to the target language.</returns>
        private string TranslateTitles(string lang)
        {
            string result = "";
            string currentLang = Thread.CurrentThread.CurrentUICulture.Name;

            Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
            result = Localization.TemplateStrings.tmpl_lang_select;
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(currentLang);

            return result;
        }

        protected string GetSignatureImage()
        {
            string lang = ((BasePage)Page).Language;

            if (lang == "fr")
            {
                return "./wet-v4/dist/assets/sig-alt-fr.svg";
            }
            else
            {
                return "./wet-v4/dist/assets/sig-alt-en.svg";
            }
        }
    }
}
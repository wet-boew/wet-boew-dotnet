using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Collections;
using System.Data;
using System.Threading;
using System.Globalization;

namespace GCIntranetTheme
{
    public partial class splashpage : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //NOTE:  Page.Title is automatically created in Splash.master.
            Page.MetaDescription = "Web Experience Toolkit (WET) includes reusable components for building and maintaining innovative Web sites that are accessible, usable, and interoperable. These reusable components are open source software and free for use by departments and external Web communities";

            if (!IsPostBack)
            {
                //Create the language buttons based on the WetBoewGroup/WetBoew/Languages section of the web.config file.
                WetBoewConfiguration config = WetBoewConfiguration.GetConfiguration();
                LanguagesCollection myLanguagesSection = config.Languages as LanguagesCollection;

                DataTable dt = new DataTable();
                dt.Columns.Add("abbr", typeof(string));
                dt.Columns.Add("name", typeof(string));
                dt.Columns.Add("homePage", typeof(string));
                dt.Columns.Add("siteName", typeof(string));
                dt.Columns.Add("terms", typeof(string));
                dt.Columns.Add("licencePage", typeof(string));

                for (int i = 0; i < myLanguagesSection.Count; i++)
                {
                    DataRow dr = dt.NewRow();
                    dr["abbr"] = myLanguagesSection[i].Abbr;
                    dr["name"] = myLanguagesSection[i].Name;
                    dr["homePage"] = myLanguagesSection[i].HomePage;
                    dr["siteName"] = myLanguagesSection[i].SiteName;
                    dr["terms"] = TranslateTerms(myLanguagesSection[i].Abbr);
                    dr["licencePage"] = myLanguagesSection[i].LicencePage;
                    dt.Rows.Add(dr);
                } 
                
                Repeater1.DataSource = dt;
                Repeater1.DataBind();
            }
        }

        /// <summary>
        /// Get translations for "Terms and conditions of use".
        /// </summary>
        /// <param name="lang">The abbreviation of the target language.</param>
        /// <returns>"Terms and conditions of use" translated to the target language.</returns>
        private string TranslateTerms(string lang)
        {
            string result = "";
            string currentLang = Thread.CurrentThread.CurrentUICulture.Name;

            Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
            result = Localization.TemplateStrings.tmpl_terms_of_use;
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(currentLang);

            return result;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GCIntranetTheme.Controls
{
    public partial class LanguageSelection : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //Create a language selection link for each language defined in WetBoewGroup/WetBoew/Languages section
                WetBoewConfiguration config = WetBoewConfiguration.GetConfiguration();
                LanguagesCollection myLanguagesSection = config.Languages as LanguagesCollection;

                DataTable dt = new DataTable();
                dt.Columns.Add("abbr", typeof(string));
                dt.Columns.Add("name", typeof(string));
                dt.Columns.Add("page", typeof(string));

                for (int i = 0; i < myLanguagesSection.Count; i++)
                {
                    string abbr = myLanguagesSection[i].Abbr;

                    if (abbr != ((BasePage)Page).Language)
                    {
                        DataRow dr = dt.NewRow();
                        dr["abbr"] = abbr;
                        dr["name"] = myLanguagesSection[i].Name;
                        dr["page"] = TranslatePage(Request.RawUrl, abbr);
                        dt.Rows.Add(dr);
                    }
                }
                
                Repeater1.DataSource = dt;
                Repeater1.DataBind();
            }
        }

        /// <summary>
        /// Get the URL of the current page in another language.
        /// </summary>
        /// <param name="lang">The abbreviation of the target language.</param>
        /// <returns>The URL of the current page in the target language.</returns>
        /// <remarks>
        /// Current standard on the WET site is to use two-letter languages.
        /// No test is done to see if the translated page actually exists.
        /// </remarks>
        private string TranslatePage(string rawUrl, string lang)
        {
            //Given an arbitrary page such as "/SomeDir/SomePage-fra.aspx?id=123",
            //this pattern should replace "-fra" with the target language.
            string pattern = "^(\\S+)(-\\S+)(.aspx\\S*)$";
            string replacement = string.Format("$1{0}$3", string.Format("-{0}", lang));
            string translatedPage = Regex.Replace(rawUrl, pattern, replacement, RegexOptions.IgnoreCase);

            return translatedPage;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GCWebTheme.MasterPages
{
    public partial class GCWeb : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string lang = ((BasePage)Page).Language;
            string img;
            string feedback;

            if (lang == "fr") {
                Home.NavigateUrl = "http://www.canada.ca/fr/index.html";
                Feedback.NavigateUrl = "http://www.canada.ca/fr/contact/feedback.html";                
                img = "sig-blk-fr.svg";
                feedback = "Rétroaction<span class=\"wb-inv\"> sur ce site Web</span>";
            }
            else {
                Home.NavigateUrl = "http://www.canada.ca/en/index.html";
                Feedback.NavigateUrl = "http://www.canada.ca/en/contact/feedback.html";
                img = "sig-blk-en.svg";
                feedback = "Feedback<span class=\"wb-inv\"> about this web site</span>";
            }

            Home.Text = string.Format("<object type=\"image/svg+xml\" tabindex=\"-1\" data=\"/wet-v4/dist/assets/{0}\"></object><span class=\"wb-inv\"> {1}</span>", img, Localization.TemplateStrings.tmpl_gc_sig);
            Feedback.Text = string.Format("<span class=\"glyphicon glyphicon-comment mrgn-rght-sm\"></span>{0}", feedback);


            //Show a section menu if required.
            if (((BasePage)Page).ShowSectionMenu) {
                container.CssClass = "container";
                row.CssClass = "row";
                main.Attributes["class"] = "col-md-9 col-md-push-3";

                GCWebTheme.Controls.SectionMenu SectionMenu1 = (GCWebTheme.Controls.SectionMenu)LoadControl("~/Controls/SectionMenu.ascx") as GCWebTheme.Controls.SectionMenu;
                row.Controls.Add(SectionMenu1);
            }
        }
    }
}
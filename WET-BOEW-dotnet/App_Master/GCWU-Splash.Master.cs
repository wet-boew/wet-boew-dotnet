using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System;
using System.Globalization;
using System.Resources;
using System.Threading;

namespace WET_BOEW_dotnet.App_Master
{
    public partial class GCWU_Splash : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

    //        <add key="PrimLangSiteName" value="Web Experience Toolkit (WET)" />
    //<add key="AltLangSiteName" value="Boîte à outils de l’expérience Web (BOEW)" />
            //<html lang="en" class="no-js">
            //<!--[if IE 7]><html lang="en" class="no-js ie7"><![endif]-->
            //<!--[if IE 8]><html lang="en" class="no-js ie8"><![endif]-->
            ltlhtml.Text = "<html lang='" + ConfigurationSettings.AppSettings["PrimaryLanguage"].ToString() + "' class='no-js'>";
            ltlhtml7.Text = "<html lang='" + ConfigurationSettings.AppSettings["PrimaryLanguage"].ToString() + "' class='no-js ie7'>";
            ltlhtml8.Text = "<html lang='" + ConfigurationSettings.AppSettings["PrimaryLanguage"].ToString() + "' class='no-js ie8'>";
            ltlTitle.Text = ConfigurationSettings.AppSettings["PrimLangSiteName"].ToString() + " / " + ConfigurationSettings.AppSettings["AltLangSiteName"].ToString();
            if(ConfigurationSettings.AppSettings["PrimaryLanguage"].ToString()=="en"){
                ltlWelcome.Text="Welcome / <span lang='fr'>Bienvenue</span>";
                hlkLeft.Text = "English";
                hlkRight.Text = "Français";
                hlkLeftTC.Text = "Terms and conditions";
                hlkRightTC.Text = "Avis";
            }else{
                ltlWelcome.Text = "Bienvenue / <span lang='en'>Welcome</span>";
                hlkLeft.Text = "Français";
                hlkRight.Text = "English";
                hlkRightTC.Text = "Terms and conditions";
                hlkLeftTC.Text = "Avis";
            }
            ltlLeft.Text = ConfigurationSettings.AppSettings["PrimLangSiteName"].ToString();
            ltlRight.Text = ConfigurationSettings.AppSettings["AltLangSiteName"].ToString();
        }

        protected void hlkLeft_Click(object sender, System.EventArgs e)
        {
            Session["l"] = ConfigurationSettings.AppSettings["PrimaryLanguage"].ToString();
            Response.Redirect("~/content.aspx");
        }

        protected void hlkRight_Click(object sender, System.EventArgs e)
        {
            Session["l"] = ConfigurationSettings.AppSettings["AlternateLanguage"].ToString();
            Response.Redirect("~/content.aspx");
        }
    }
}
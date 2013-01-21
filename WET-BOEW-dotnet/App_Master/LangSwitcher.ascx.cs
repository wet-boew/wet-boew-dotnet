using System;
using System.Threading;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WET_BOEW_dotnet.App_Master
{
    public partial class LangSwitcher : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbtnSwitch_Click(object sender, EventArgs e)
        {
            //Response.Write(Thread.CurrentThread.CurrentUICulture);
            string myLanguage = lbtnSwitch.Text.Trim();
            myLanguage = myLanguage.ToLower();

            if (myLanguage == "english")
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            }
            else
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-CA");
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr");
            }
            Response.Redirect(Request.RawUrl);
        }
    }
}
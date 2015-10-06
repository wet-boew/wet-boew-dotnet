using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GCWebUsabilityTheme.Controls
{
    public partial class TopOfPage : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Make PlaceHolderSecondaryMenu visible if the page is using a 2-column layout.
            if (((BasePage)Page).ShowSectionMenu)
            {
                PlaceHolderSecondaryMenu.Visible = true;
            }
        }
    }
}
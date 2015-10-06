using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GCIntranetTheme.Controls
{
    public partial class DateModified : System.Web.UI.UserControl
    {
        public string PageDateModified
        {
            get { return ((BasePage)Page).Modified; }
        }
    }
}
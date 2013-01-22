using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WET_BOEW_dotnet.App_Master
{
    public partial class ModificationDate : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string currentURL = HttpContext.Current.Request.Path.ToString();
            string sformat = "yyyy/MM/dd"; 
            FileInfo file = new FileInfo(MapPath(currentURL));
            //FileInfo file = new FileInfo(currentURL);
            ltlModDate.Text = file.LastWriteTime.ToString(sformat);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GCWebTheme.Controls
{
    public partial class SearchAndMenus : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Change AppRelativeTemplateSourceDirectory to a root relative virtual path so that any relative paths in 
            //the UserControl will be relative to the requested page rather than the user controls path.
            //See http://stackoverflow.com/questions/2604636/relative-path-from-an-asp-net-user-control-navigateurl
            string rootPath = HttpContext.Current.Request.ApplicationPath;
            if (!rootPath.EndsWith("/"))
            {
                rootPath += "/";
            }

            Uri requestUri = HttpContext.Current.Request.Url;
            string folderPath = requestUri.AbsolutePath.Remove(0, rootPath.Length);
            string lastSegment = requestUri.Segments[requestUri.Segments.Length - 1];
            folderPath = folderPath.Remove(folderPath.LastIndexOf(lastSegment));

            AppRelativeTemplateSourceDirectory = "~/" + folderPath;
        }
    }
}
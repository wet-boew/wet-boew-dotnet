using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GCWebTheme.Controls
{
    public partial class Aside : System.Web.UI.UserControl
    {
        private string _asideTitle;
        protected string myProvider;

        protected void Page_Load(object sender, EventArgs e)
        {
            //Set the sitemap provider.  Assuming that each provider is prefixed with the language abbreviation.
            string lang = ((BasePage)Page).Language;
            myProvider = string.Format("{0}AsideSiteMapProvider", lang.ToUpper());
            SiteMapDataSource1.SiteMapProvider = myProvider;

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

        protected string AsideTitle
        {
            get
            {
                if (string.IsNullOrEmpty(_asideTitle))
                {
                    _asideTitle = SiteMap.Providers[myProvider].RootNode.Title;
                }
                return _asideTitle;
            }
        }

        /// <summary>
        /// Read Only. Gets the Branch of the Site Map that holds the SiteMap.CurrentNode.
        /// Returns an empty list if SiteMap.CurrentNode == null
        /// </summary>
        /// <remarks>
        /// From http://www.4guysfromrolla.com/articles/060309-1.aspx
        /// </remarks>
        private List<SiteMapNode> CurrentBranch
        {
            get
            {
                List<SiteMapNode> currentBranch = null;
                SiteMapNode cn = SiteMap.Providers[myProvider].CurrentNode;
                SiteMapNode n = cn;
                currentBranch = new List<SiteMapNode>();
                if (cn != null)
                {
                    while (n.Url != SiteMap.Providers[myProvider].RootNode.Url)
                    {
                        // I don't need to check for n.ParentNode == null
                        // because I know that:
                        // cn != null && n != SiteMap.RootNode
                        currentBranch.Add(n);
                        n = n.ParentNode;
                    }
                    // the while loop excludes the root node, so add it here
                    // I could add n, that should now be equal to SiteMap.RootNode, but this is clearer
                    currentBranch.Add(SiteMap.Providers[myProvider].RootNode);

                    // The nodes were added in reverse order, from the CurrentNode up, so reverse them.
                    currentBranch.Reverse();
                }
                return currentBranch;
            }
        }

        private int CurrentNodeLevel
        {
            get
            {
                return CurrentBranch.Count - 1;
            }
        }
    }
}
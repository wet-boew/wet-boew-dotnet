using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GCIntranetTheme.Controls
{
    public partial class Breadcrumb : System.Web.UI.UserControl
    {
        protected string myProvider;

        protected void Page_Load(object sender, EventArgs e)
        {
            //Set the sitemap provider.  Assuming that each provider is prefixed with the language abbreviation.
            string lang = ((BasePage)Page).Language;
            myProvider = string.Format("{0}SiteMapProvider", lang.ToUpper());
            SiteMapDataSource1.SiteMapProvider = myProvider;

            //Assuming that each Web[.??].sitemap file has a siteMapNode at the top like "~/index-??.aspx".
            SiteMapDataSource1.StartingNodeUrl = string.Format("~/index-{0}.aspx", lang);

            //Create the bulleted list
            BreadcrumbListItems.Text = string.Format("<li><a href=\"{0}\">{1}</a></li>{2}", SiteMap.Providers[myProvider].RootNode.Url, SiteMap.Providers[myProvider].RootNode.Title, DisplaySiteMapLevelAsBulletedList());
        }

        private string DisplaySiteMapLevelAsBulletedList()
        {
            //Get the SiteMapDataSourceView from the siteMapData SiteMapDataSource
            SiteMapDataSourceView siteMapView = (SiteMapDataSourceView)SiteMapDataSource1.GetView(string.Empty);

            //Get the SiteMapNodeCollection from the SiteMapDataSourceView
            SiteMapNodeCollection nodes = (SiteMapNodeCollection)siteMapView.Select(DataSourceSelectArguments.Empty);

            //Recurse through the SiteMapNodeCollection...
            return GetSiteMapLevelAsBulletedList(nodes);
        }

        private string GetSiteMapLevelAsBulletedList(SiteMapNodeCollection nodes)
        {
            string output = string.Empty;
            foreach (SiteMapNode node in nodes)
            {
                if (SiteMap.Providers[myProvider].CurrentNode.IsDescendantOf(node) || SiteMap.Providers[myProvider].CurrentNode == node)
                {
                    output += string.Format("<li><a href=\"{0}\">{1}</a>", node.Url, node.Title);

                    //Add any children levels, if needed (recursively)
                    if (node.HasChildNodes)
                    {
                        output += GetSiteMapLevelAsBulletedList(node.ChildNodes);
                    }

                    output += "</li>";
                }
            }

            return output;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GCWebTheme.Controls
{
    public partial class SectionMenu : System.Web.UI.UserControl
    {
        private string _sectionTitle;
        protected string myProvider;

        protected void Page_Load(object sender, EventArgs e)
        {
            //Set the sitemap provider.  Assuming that each provider is prefixed with the language abbreviation.
            string lang = ((BasePage)Page).Language;
            myProvider = string.Format("{0}SiteMapProvider", lang.ToUpper());
            SiteMapDataSource1.SiteMapProvider = myProvider;

            //Set the starting node level of the sitemap.
            //NOTE:  The intention of a side menu is apparently to show siblings, not children, 
            //       but in practice, it does show children in a nested unordered list.  However,
            //       this is being discussed further.
            //SEE:  https://github.com/wet-boew/GCWeb/issues/776#issuecomment-65173962
            //      https://github.com/wet-boew/GCWeb/issues/995
            SiteMapDataSource1.StartingNodeOffset = CurrentNodeLevel - 1;
        }

        protected void RepeaterItemEventHandler(Object Sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                //Set a different style on the current node.
                HyperLink currentHyperLink = (HyperLink)e.Item.FindControl("HyperLink1");
                SiteMapNode currentNode = SiteMap.Providers[myProvider].CurrentNode;

                if (currentNode != null)
                {
                    if (currentHyperLink.NavigateUrl == currentNode.Url)
                    {
                        currentHyperLink.CssClass = "list-group-item wb-navcurr";
                    }
                }
            }
        }

        protected string SectionTitle
        {
            get
            {
                if (string.IsNullOrEmpty(_sectionTitle))
                {
                    SiteMapNode currentNode = SiteMap.Providers[myProvider].CurrentNode;

                    if (currentNode != null)
                    {
                        _sectionTitle = SiteMap.Providers[myProvider].CurrentNode.ParentNode.Title;
                    }
                    else
                    {
                        _sectionTitle = "";  //REVIEW:  What is a good default for a missing title?
                    }
                }
                return _sectionTitle;
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
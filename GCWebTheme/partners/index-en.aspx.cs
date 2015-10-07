using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GCWebTheme.partners
{
    public partial class index_en : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Canada.ca theme for Partner sites";
            Page.MetaDescription = "Web Experience Toolkit (WET) includes reusable components for building and maintaining innovative Web sites that are accessible, usable, and interoperable. These reusable components are open source software and free for use by departments and external Web communities";
            //base.ShowSectionMenu = true;
        }
    }
}
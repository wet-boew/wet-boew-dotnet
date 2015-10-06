using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GCIntranetTheme
{
    public partial class Content : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Test Content Page Title 1";
            Page.MetaDescription = "Test 1";
            //Page.DateModified = "Test 2";
            
        }
    }
}
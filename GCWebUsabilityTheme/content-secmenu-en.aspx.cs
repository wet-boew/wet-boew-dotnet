using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GCWebUsabilityTheme
{
    public partial class content_secmenu_en :BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Content Page - Secondary menu";
            Page.MetaDescription = "Web Experience Toolkit (WET) includes reusable components for building and maintaining innovative Web sites that are accessible, usable, and interoperable. These reusable components are open source software and free for use by departments and external Web communities";
            base.Issued = "2015-08-21";                                                 //Defaults to base.Created.
            //base.Created = "2015-08-21";                                              //Defaults to file system creation date.
            //base.Modified = "2015-07-29";                                             //Defaults to file system last write time date.
            base.Creator = "Government of Canada, Citizenship and Immigration Canada";  //Default defined in BasePage.cs
            base.Subject = "Citizenship; Immigration; Multiculturalism";                //Default defined in BasePage.cs
            base.ShowSectionMenu = true;                                                //Default defined in web.config.
        }
    }
}
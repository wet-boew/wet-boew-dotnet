using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GCIntranetTheme
{
    public partial class Wet_Boew : System.Web.UI.MasterPage
    {
        private string _pageCreationDate;
        private string _pageModifiedDate;

        protected void Page_Load(object sender, EventArgs e)
        {
            GetDateCreated();
            GetDateModified();
        }

        #region Private Methods
        /// <summary>
        /// Get the creation date of the content page (not this master page).
        /// </summary>
        /// <remarks></remarks>
        private void GetDateCreated()
        {
            if (_pageCreationDate == null)
            {
                System.IO.FileInfo objInfo = new System.IO.FileInfo(Server.MapPath(Request.ServerVariables.Get("SCRIPT_NAME")));
                string strDate = null;

                strDate = String.Format("{0:yyyy-MM-dd}", objInfo.CreationTime.Date);
                _pageCreationDate = strDate;
            }
        }

        /// <summary>
        /// Get the modification date of the content page (not this master page).
        /// </summary>
        /// <remarks></remarks>
        private void GetDateModified()
        {
            if (_pageModifiedDate == null)
            {
                System.IO.FileInfo objInfo = new System.IO.FileInfo(Server.MapPath(Request.ServerVariables.Get("SCRIPT_NAME")));
                string strDate = null;

                strDate = String.Format("{0:yyyy-MM-dd}", objInfo.LastWriteTime.Date);
                _pageModifiedDate = strDate;
            }
        }
        #endregion

        #region Public Properties
        public string PageModified
        {
            get { return _pageModifiedDate; }
            set { _pageModifiedDate = value; }
        }

        public string ThreeLetterLangName
        {
            get { return Thread.CurrentThread.CurrentUICulture.ThreeLetterISOLanguageName; }
        }

        public string TwoLetterLangName
        {
            get { return Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName; }
        } 
        #endregion
    }
}
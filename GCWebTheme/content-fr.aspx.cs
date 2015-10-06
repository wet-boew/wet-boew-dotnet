using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GCWebTheme
{
    public partial class content_fr : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Page de contenu";
            Page.MetaDescription = "La Boîte à outils de l’expérience Web (BOEW) rassemble différents composants réutilisables et prêts-à-utiliser pour la conception et la mise à jour de sites Web innovateurs qui sont à la fois accessibles, conviviaux et interopérables. Tous ces composants réutilisables sont des logiciels libres mis à la disposition des ministères et des collectivités Web externes.";
            base.Issued = "2015-08-21";
            //base.Modified = "2015-08-26";
            //base.ShowSectionMenu = false;
        }
    }
}
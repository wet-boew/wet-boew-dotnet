using System;
using System.Globalization;
using System.Threading;
using System.Web;


namespace WET_BOEW_dotnet.App_Master
{
    public partial class Base : System.Web.UI.Page
    {
            protected override void InitializeCulture()
            {
                if (!Page.IsPostBack)
                {
                    
                    try
                    {

                        string browserLanguage = Request.UserLanguages[0];
                        // Check profile language if authenticated
                        //if (Context.Profile.GetPropertyValue("LANGUAGEPREFERENCE").ToString().Contains("FR"))
                        //{
                        //    SetLanguage("fr-CA");
                        //}
                        //else if (Context.Profile.GetPropertyValue("LANGUAGEPREFERENCE").ToString().Contains("EN"))
                        //{
                        //    SetLanguage("en-CA");
                        //}
                        // Check for query string
                        //else if (Session["l"] != null)
                        if (Session["l"] != null)
                        {
                            string myLanguage = Session["l"].ToString();
                            myLanguage = myLanguage.ToLower();
                            if (myLanguage.Contains("fr"))
                            {
                                SetLanguage("fr-CA");
                            }
                            else
                            {
                                SetLanguage("en-CA");
                            }
                        }
                        // Check browser language
                        else if (browserLanguage != null)
                        {
                            if (Request.UserLanguages[0].ToLower().Contains("fr"))
                            {
                                SetLanguage("fr-CA");
                            }
                            else
                            {
                                SetLanguage("en-CA");
                            }
                        }
                        // Otherwise set to english
                        else
                        {
                            SetLanguage("en-CA");
                        }
                    }
                    catch (Exception ex)
                    {
                        //Response.Write(ex.ToString());
                        //Log.LogMessage(ex.ToString(), 9999);
                    }
                }
            }

            protected void SetLanguage(string language)
            {
                CultureInfo ci;
                ci = new CultureInfo(language);
                Thread.CurrentThread.CurrentUICulture = ci;
                Thread.CurrentThread.CurrentCulture = ci;
                base.InitializeCulture();
            }
    }
}
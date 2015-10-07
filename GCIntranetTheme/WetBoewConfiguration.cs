using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace GCIntranetTheme
{
    public class WetBoewConfiguration : ConfigurationSection
    {
        internal static WetBoewConfiguration GetConfiguration()
        {
            //Configuration configuration = ConfigurationManager.GetSection("WetBoewGroup/WetBoew") as Configuration;
            WetBoewConfiguration configuration = (WetBoewConfiguration)System.Configuration.ConfigurationManager.GetSection("WetBoewGroup/WetBoew");
            if (configuration != null)
                return configuration;
            
            return new WetBoewConfiguration();
        }

        //Create a "defaultLanguage" attribute.
        //REVIEW:  This property isn't being used anywhere?
        [ConfigurationProperty("defaultLanguage", DefaultValue = "en", IsRequired = false)]
        [StringValidator(MinLength = 2, MaxLength = 2)]
        public string DefaultLanguage
        {
            get
            {
                return (string)this["defaultLanguage"];
            }
            set
            {
                this["defaultLanguage"] = value;
            }
        }

        //Create a "showBreadcrumbTrail" attribute.
        [ConfigurationProperty("showBreadcrumbTrail", DefaultValue = true, IsRequired = false)]
        public bool ShowBreadcrumbTrail
        {
            get
            {
                return (bool)this["showBreadcrumbTrail"];
            }
            set
            {
                this["showBreadcrumbTrail"] = value;
            }
        }

        //Create a "showSearch" attribute.
        [ConfigurationProperty("showSearch", DefaultValue = true, IsRequired = false)]
        public bool ShowSearch
        {
            get
            {
                return (bool)this["showSearch"];
            }
            set
            {
                this["showSearch"] = value;
            }
        }

        //Create a "showSiteMenu" attribute.
        [ConfigurationProperty("showSiteMenu", DefaultValue = true, IsRequired = false)]
        public bool ShowSiteMenu
        {
            get
            {
                return (bool)this["showSiteMenu"];
            }
            set
            {
                this["showSiteMenu"] = value;
            }
        }

        //Create a "showSectionMenu" attribute.
        [ConfigurationProperty("showSectionMenu", DefaultValue = false, IsRequired = false)]
        public bool ShowSectionMenu
        {
            get
            {
                return (bool)this["showSectionMenu"];
            }
            set
            {
                this["showSectionMenu"] = value;
            }
        }

        // Declare a collection element represented in the configuration file 
        // by the sub-section <languages> <add .../> </languages>  
        // Note: the "IsDefaultCollection = false" instructs the .NET Framework 
        // to build a nested section like <languages> ...</languages>.
        [ConfigurationProperty("languages", IsDefaultCollection = false)]
        public LanguagesCollection Languages
        {
            get
            {
                LanguagesCollection languagesCollection = (LanguagesCollection)base["languages"];
                return languagesCollection;
            }
        }
    }


    public class LanguagesCollection : ConfigurationElementCollection
    {
        public LanguagesCollection()
        {
            // Add one language to the collection.  This is not necessary; 
            // could leave the collection empty until items are added to it 
            // outside the constructor.

            //LanguageConfigElement lang = (LanguageConfigElement)CreateNewElement();
            //Add(lang);
        }

        public override ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return ConfigurationElementCollectionType.AddRemoveClearMap;
            }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new LanguageConfigElement();
        }

        protected override Object GetElementKey(ConfigurationElement element)
        {
            return ((LanguageConfigElement)element).Name;
        }

        public new string AddElementName
        {
            get
            { return base.AddElementName; }

            set
            { base.AddElementName = value; }
        }

        public new string ClearElementName
        {
            get
            { return base.ClearElementName; }

            set
            { base.ClearElementName = value; }
        }

        public new string RemoveElementName
        {
            get
            { return base.RemoveElementName; }
        }

        public new int Count
        {
            get { return base.Count; }
        }


        public LanguageConfigElement this[int index]
        {
            get
            {
                return (LanguageConfigElement)BaseGet(index);
            }
            set
            {
                if (BaseGet(index) != null)
                {
                    BaseRemoveAt(index);
                }
                BaseAdd(index, value);
            }
        }

        new public LanguageConfigElement this[string Name]
        {
            get
            {
                return (LanguageConfigElement)BaseGet(Name);
            }
        }

        public int IndexOf(LanguageConfigElement lang)
        {
            return BaseIndexOf(lang);
        }

        public void Add(LanguageConfigElement lang)
        {
            BaseAdd(lang);
            // Add custom code here.
        }

        protected override void BaseAdd(ConfigurationElement element)
        {
            BaseAdd(element, false);
            // Add custom code here.
        }

        public void Remove(LanguageConfigElement lang)
        {
            if (BaseIndexOf(lang) >= 0)
                BaseRemove(lang.Name);
        }

        public void RemoveAt(int index)
        {
            BaseRemoveAt(index);
        }

        public void Remove(string name)
        {
            BaseRemove(name);
        }

        public void Clear()
        {
            BaseClear();
            // Add custom code here.
        }
    }


    public class LanguageConfigElement : ConfigurationElement
    {
        private string elementName;

        #region Constructors
        public LanguageConfigElement(String name, String abbr, string homePage, string licencePage, string siteName, string textDirection)
        {
            Abbr = abbr;
            HomePage = homePage;
            LicencePage = licencePage;
            Name = name;
            SiteName = siteName;
            TextDirection = textDirection;
        }

        public LanguageConfigElement(String name, String abbr, string homePage, string licencePage, string siteName) 
        {
            Abbr = abbr;
            HomePage = homePage;
            LicencePage = licencePage;
            Name = name;
            SiteName = siteName;
            TextDirection = "ltr";
        }

        public LanguageConfigElement(String name, String abbr)
        {
            Abbr = abbr;
            HomePage = "";
            LicencePage = "";
            Name = name;
            SiteName = "";
            TextDirection = "ltr";
        }

        public LanguageConfigElement()
        {
            // TODO: Complete member initialization
        }
        #endregion

        [ConfigurationProperty("abbr", DefaultValue = "", IsKey=true, IsRequired = true)]
        public string Abbr
        {
            get
            {
                return (string)this["abbr"];
            }
            set
            {
                this["abbr"] = value;
            }
        }

        //REVIEW:  The home page is the first siteMapNode in the Web.sitemap file, so can't that be used instead?
        [ConfigurationProperty("homePage", DefaultValue = "", IsRequired = true)]
        public string HomePage
        {
            get
            {
                return (string)this["homePage"];
            }
            set
            {
                this["homePage"] = value;
            }
        }

        [ConfigurationProperty("licencePage", DefaultValue = "", IsRequired = true)]
        public string LicencePage
        {
            get
            {
                return (string)this["licencePage"];
            }
            set
            {
                this["licencePage"] = value;
            }
        }
        
        [ConfigurationProperty("name", DefaultValue ="", IsRequired=true)]
        public string Name
        {
            get
            {
                return (string)this["name"];
            }
            set
            {
                this["name"] = value;
            }
        }

        [ConfigurationProperty("siteName", DefaultValue = "", IsRequired = true)]
        public string SiteName
        {
            get
            {
                return (string)this["siteName"];
            }
            set
            {
                this["siteName"] = value;
            }
        }

        [ConfigurationProperty("textDirection", DefaultValue = "ltr", IsRequired = false)]
        public string TextDirection
        {
            get
            {
                return (string)this["textDirection"];
            }
            set
            {
                this["textDirection"] = value;
            }
        }

        protected override void DeserializeElement(System.Xml.XmlReader reader, bool serializeCollectionKey)
        {
            base.DeserializeElement(reader, serializeCollectionKey);
            // You can your custom processing code here.
        }


        protected override bool SerializeElement(System.Xml.XmlWriter writer, bool serializeCollectionKey)
        {
            bool ret = base.SerializeElement(writer, serializeCollectionKey);
            // You can enter your custom processing code here. 
            return ret;
        }


        protected override bool IsModified()
        {
            bool ret = base.IsModified();
            // You can enter your custom processing code here. 
            return ret;
        }
    }
}
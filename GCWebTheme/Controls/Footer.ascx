<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Footer.ascx.cs" Inherits="GCWebTheme.Controls.Footer" %>
<asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" ShowStartingNode="true" />
<footer role="contentinfo" id="wb-info">
<nav role="navigation" class="container visible-sm visible-md visible-lg wb-navcurr">
<h2 class="wb-inv"><asp:Localize ID="LocalizeAbout" runat="server" Text="About this site" meta:resourcekey="LocalizeAboutResource1" /></h2>
<div class="row">
<div class="col-sm-3 col-lg-3">
<asp:Repeater ID="Repeater1" runat="server" DataSourceID="SiteMapDataSource1">
    <HeaderTemplate>
        
    </HeaderTemplate>

    <ItemTemplate>
        <section>
        <h3><%# Eval("Title") %></h3>
            <asp:Repeater runat="server" DataSource='<%# ((SiteMapNode) Container.DataItem).ChildNodes %>'>
                <HeaderTemplate>
                    <ul class="list-unstyled">
                </HeaderTemplate>
                <ItemTemplate>
                    <li><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("Url") %>'> <%# Eval("Title") %></asp:HyperLink></li>
                </ItemTemplate>
                <FooterTemplate>
                    </ul>
                </FooterTemplate>
            </asp:Repeater>
        </section>
    </ItemTemplate>

    <FooterTemplate>
        
    </FooterTemplate>
</asp:Repeater>
<section>
<h3><asp:Localize ID="Localize2" runat="server" Text="News" meta:resourcekey="Localize2Resource1" /></h3>
<ul class="list-unstyled">
<li><asp:HyperLink ID="HyperLink2A" runat="server" NavigateUrl="http://news.gc.ca/web/index-en.do" Text="Newsroom" meta:resourcekey="HyperLink2AResource1" /></li>
<li><asp:HyperLink ID="HyperLink2B" runat="server" NavigateUrl="http://news.gc.ca/web/nwsprdct-en.do?mthd=tp&amp;crtr.tp1D=1" Text="News releases" meta:resourcekey="HyperLink2BResource1" /></li>
<li><asp:HyperLink ID="HyperLink2C" runat="server" NavigateUrl="http://news.gc.ca/web/nwsprdct-en.do?mthd=tp&amp;crtr.tp1D=3" Text="Media advisories" meta:resourcekey="HyperLink2CResource1" /></li>
<li><asp:HyperLink ID="HyperLink2D" runat="server" NavigateUrl="http://news.gc.ca/web/nwsprdct-en.do?mthd=tp&amp;crtr.tp1D=970" Text="Speeches" meta:resourcekey="HyperLink2DResource1" /></li>
<li><asp:HyperLink ID="HyperLink2E" runat="server" NavigateUrl="http://news.gc.ca/web/nwsprdct-en.do?mthd=tp&amp;crtr.tp1D=980" Text="Statements" meta:resourcekey="HyperLink2EResource1" /></li>
</ul>
</section>
</div>
<section class="col-sm-3 col-lg-3">
<h3><asp:Localize ID="Localize3" runat="server" Text="Government" meta:resourcekey="Localize3Resource1" /></h3>
<ul class="list-unstyled">
<li><asp:HyperLink ID="HyperLink3A" runat="server" NavigateUrl="http://www.canada.ca/en/gov/system" Text="How government works" meta:resourcekey="HyperLink3AResource1" /></li>
<li><asp:HyperLink ID="HyperLink3B" runat="server" NavigateUrl="http://www.canada.ca/en/gov/dept" Text="Departments & agencies" meta:resourcekey="HyperLink3BResource1" /></li>
<li><asp:HyperLink ID="HyperLink3C" runat="server" NavigateUrl="http://pm.gc.ca/eng" Text="Prime Minister" meta:resourcekey="HyperLink3CResource1" /></li>
<li><asp:HyperLink ID="HyperLink3D" runat="server" NavigateUrl="http://www.canada.ca/en/gov/ministers" Text="Ministers" meta:resourcekey="HyperLink3DResource1" /></li>
<li><asp:HyperLink ID="HyperLink3E" runat="server" NavigateUrl="http://www.canada.ca/en/gov/publicservice" Text="Public service & military" meta:resourcekey="HyperLink3EResource1" /></li>
<li><asp:HyperLink ID="HyperLink3F" runat="server" NavigateUrl="http://www.canada.ca/en/gov/policy" Text="Policies, regulations & laws" meta:resourcekey="HyperLink3FResource1" /></li>
<li><asp:HyperLink ID="HyperLink3G" runat="server" NavigateUrl="http://www.canada.ca/en/gov/libraries" Text="Libraries" meta:resourcekey="HyperLink3GResource1" /></li>
<li><asp:HyperLink ID="HyperLink3H" runat="server" NavigateUrl="http://www.canada.ca/en/gov/publications" Text="Publications" meta:resourcekey="HyperLink3HResource1" /></li>
<li><asp:HyperLink ID="HyperLink3I" runat="server" NavigateUrl="http://www.canada.ca/en/gov/statistics" Text="Statistics & data" meta:resourcekey="HyperLink3IResource1" /></li>
<li><asp:HyperLink ID="HyperLink3J" runat="server" NavigateUrl="http://www.canada.ca/en/newsite.html" Text="About Canada.ca" meta:resourcekey="HyperLink3JResource1" /></li>
</ul>
</section>
<section class="col-sm-3 col-lg-3 brdr-lft">
<h3><asp:Localize ID="Localize4" runat="server" Text="Transparency" meta:resourcekey="Localize4Resource1" /></h3>
<ul class="list-unstyled">
<li><asp:HyperLink ID="HyperLink4A" runat="server" NavigateUrl="http://www.canada.ca/en/transparency/reporting.html" Text="Government-wide reporting" meta:resourcekey="HyperLink4AResource1" /></li>
<li><asp:HyperLink ID="HyperLink4B" runat="server" NavigateUrl="http://open.canada.ca/en" Text="Open government" meta:resourcekey="HyperLink4BResource1" /></li>
<li><asp:HyperLink ID="HyperLink4C" runat="server" NavigateUrl="http://www.canada.ca/en/transparency/disclosure.html" Text="Proactive disclosure" meta:resourcekey="HyperLink4CResource1" /></li>
<li><asp:HyperLink ID="HyperLink4D" runat="server" NavigateUrl="http://www.canada.ca/en/transparency/terms.html" Text="Terms & conditions" meta:resourcekey="HyperLink4DResource1" /></li>
<li><asp:HyperLink ID="HyperLink4E" runat="server" NavigateUrl="http://www.canada.ca/en/transparency/privacy.html" Text="Privacy" meta:resourcekey="HyperLink4EResource1" /></li>
</ul>
</section>
<div class="col-sm-3 col-lg-3 brdr-lft">
<section>
<h3><asp:Localize ID="Localize5" runat="server" Text="Feedback" meta:resourcekey="Localize5Resource1" /></h3>
<p><asp:HyperLink ID="HyperLinkFeedback" runat="server" NavigateUrl="http://www.canada.ca/en/contact/feedback.html" meta:resourcekey="HyperLinkFeedbackResource1"><img src="/wet-v4/dist/assets/feedback.png" alt="Feedback about this Web site"></asp:HyperLink></p>
</section>
<section>
<h3><asp:Localize ID="Localize6" runat="server" Text="Social media" meta:resourcekey="Localize6Resource1" /></h3>
<p><asp:HyperLink ID="HyperLinkSocial" runat="server" NavigateUrl="http://www.canada.ca/en/social" meta:resourcekey="HyperLinkSocialResource1"><img src="/wet-v4/dist/assets/social.png" alt="Social media"></asp:HyperLink></p>
</section>
<section>
<h3><asp:Localize ID="Localize7" runat="server" Text="Mobile centre" meta:resourcekey="Localize7Resource1" /></h3>
<p><asp:HyperLink ID="HyperLinkMobile" runat="server" NavigateUrl="http://www.canada.ca/en/mobile" meta:resourcekey="HyperLinkMobileResource1"><img src="/wet-v4/dist/assets/mobile.png" alt="Mobile centre"></asp:HyperLink></p>
</section>
</div>
</div>
</nav>
<div class="brand">
<div class="container">
<div class="row">
<div class="col-xs-6 visible-sm visible-xs tofpg">
<asp:HyperLink runat="server" NavigateUrl="#wb-cont" meta:resourcekey="HyperLinkResource1">Top of Page <span class="glyphicon glyphicon-chevron-up"></span></asp:HyperLink>
</div>
<div class="col-xs-6 col-md-12 text-right">
<asp:Literal runat="server" meta:resourcekey="LocalizeWordMarkResource1"><object type="image/svg+xml" tabindex="-1" role="img" data="/wet-v4/dist/assets/wmms-blk.svg" aria-label="Symbol of the Government of Canada"></object></asp:Literal>
</div>
</div>
</div>
</div>
</footer>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LanguageSelection.ascx.cs" Inherits="GCWebUsabilityTheme.Controls.LanguageSelection" %>

<ul id="gc-bar" class="list-inline">
<li><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="http://www.canada.ca/en/index.html" Text="Canada.ca" rel="external" meta:resourcekey="HyperLink1Resource1" /></li>
<li><asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="http://www.canada.ca/en/services/index.html" Text="Services" rel="external" meta:resourcekey="HyperLink2Resource1" /></li>
<li><asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="http://www.canada.ca/en/gov/dept/index.html" Text="Departments" rel="external" meta:resourcekey="HyperLink3Resource1" /></li>
<asp:Repeater ID="Repeater1" runat="server">
    <HeaderTemplate>
        <li id="wb-lng"><h2><%=Localization.TemplateStrings.tmpl_lang_select %></h2>
        <ul class="list-inline">
    </HeaderTemplate>

    <ItemTemplate>
        <li><asp:HyperLink ID="HyperLinkLanguage" runat="server" lang='<%#Eval("abbr") %>' Text='<%#Eval("name") %>' NavigateUrl='<%#Eval("page") %>' /></li>
    </ItemTemplate>

    <FooterTemplate>
        </ul>
    </FooterTemplate>
</asp:Repeater>
</li>
</ul>
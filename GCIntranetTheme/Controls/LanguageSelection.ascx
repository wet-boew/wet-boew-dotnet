<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LanguageSelection.ascx.cs" Inherits="GCIntranetTheme.Controls.LanguageSelection" %>
<section id="wb-lng"><h2><%=Localization.TemplateStrings.tmpl_lang_select %></h2>
<asp:Repeater ID="Repeater1" runat="server">
    <HeaderTemplate>
        <ul class="list-inline">
    </HeaderTemplate>

    <ItemTemplate>
        <li><asp:HyperLink ID="HyperLinkLanguage" runat="server" lang='<%#Eval("abbr") %>' Text='<%#Eval("name") %>' NavigateUrl='<%#Eval("page") %>' /></li>
    </ItemTemplate>

    <FooterTemplate>
        </ul>
    </FooterTemplate>
</asp:Repeater>
</section>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SiteMenu.ascx.cs" Inherits="GCWebTheme.Controls.SiteMenu" %>
<asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" ShowStartingNode="false" />

<nav role="navigation" id="wb-sm" class="wb-menu visible-md visible-lg" data-trgt="mb-pnl" data-ajax-replace="<%=this.SiteMenuFile %>" typeof="SiteNavigationElement">
<h2 class="wb-inv"><%=Localization.TemplateStrings.tmpl_topics_menu %></h2>
<div class="container nvbar">
<div class="row">

<asp:Repeater ID="Repeater1" runat="server" DataSourceID="SiteMapDataSource1">
    <HeaderTemplate>
        <ul class="list-inline menu">
    </HeaderTemplate>

    <ItemTemplate>
        <li><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("Url") %>'> <%# Eval("Title") %></asp:HyperLink></li>
    </ItemTemplate>

    <FooterTemplate>
        </ul>
    </FooterTemplate>
</asp:Repeater>

</div>
</div>
</nav>
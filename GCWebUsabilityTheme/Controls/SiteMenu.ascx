<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SiteMenu.ascx.cs" Inherits="GCWebUsabilityTheme.Controls.SiteMenu" %>
<asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" ShowStartingNode="false" />

<asp:PlaceHolder ID="PlaceHolderSiteMenu" runat="server">
<nav role="navigation" id="wb-sm" data-ajax-replace="<%=this.SiteMenuFile %>" data-trgt="mb-pnl" class="wb-menu visible-md visible-lg" typeof="SiteNavigationElement">
<div class="container nvbar">
<h2><%=Localization.TemplateStrings.tmpl_topics_menu %></h2>
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
</asp:PlaceHolder>
<asp:PlaceHolder ID="PlaceHolderNoSiteMenu" runat="server" Visible="False">
<span data-trgt="mb-pnl" class="wb-menu hide"></span>
</asp:PlaceHolder>
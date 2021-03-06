﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SectionMenu.ascx.cs" Inherits="GCWebTheme.Controls.SectionMenu" %>
<asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" ShowStartingNode="false" StartingNodeOffset="0" />
<asp:Repeater ID="Repeater1" runat="server" DataSourceID="SiteMapDataSource1" OnItemDataBound="RepeaterItemEventHandler">
    <HeaderTemplate>
        <nav class="wb-sec col-md-3 col-md-pull-9" typeof="SiteNavigationElement" id="wb-sec" role="navigation">
        <h2 id="wb-sec-h" class="wb-inv"><%=Localization.TemplateStrings.tmpl_sec_menu %></h2>
        <ul class="list-group menu list-unstyled">
        <li>
        <h3 class="wb-navcurr"><%= this.SectionTitle %></h3>
        <ul class="list-group menu list-unstyled">
    </HeaderTemplate>

    <ItemTemplate>
        <li><asp:HyperLink ID="HyperLink1" runat="server" CssClass="list-group-item" NavigateUrl='<%# Eval("Url") %>'> <%# Eval("Title") %></asp:HyperLink>
<%--            <asp:Repeater ID="Repeater2" runat="server" DataSource='<%#((SiteMapNode)Container.DataItem).ChildNodes %>' OnItemDataBound="RepeaterItemEventHandler">
                <HeaderTemplate>
                    <ul class="list-group menu list-unstyled">
                </HeaderTemplate>
                <ItemTemplate>
                    <li><asp:HyperLink ID="HyperLink1" runat="server" CssClass="list-group-item" NavigateUrl='<%# Eval("Url") %>'> <%# Eval("Title") %></asp:HyperLink></li>
                </ItemTemplate>
                <FooterTemplate>
                    </ul>
                </FooterTemplate>
            </asp:Repeater>--%>
        </li>
    </ItemTemplate>

    <FooterTemplate>
        </ul>
        </li>
        </ul>
        </nav>
    </FooterTemplate>
</asp:Repeater>
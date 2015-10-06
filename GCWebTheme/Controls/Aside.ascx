<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Aside.ascx.cs" Inherits="GCWebTheme.Controls.Aside" %>
<asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" ShowStartingNode="false" StartingNodeUrl="" StartingNodeOffset="0" />
<asp:Repeater ID="Repeater1" runat="server" DataSourceID="SiteMapDataSource1">
    <HeaderTemplate>
        <aside class="gc-nttvs container">
        <h2><%= this.AsideTitle %></h2>
        <div id="gcwb_prts" class="wb-eqht row">
    </HeaderTemplate>

    <ItemTemplate>
        <section class="col-lg-4 col-md-6 mrgn-bttm-md">
        <asp:HyperLink ID="HyperLink1" runat="server" rel="external" NavigateUrl='<%# Eval("Url") %>'>
        <h3 class="h5"><%# Eval("Title") %></h3>
        <img class="img-responsive thumbnail mrgn-bttm-sm" src="<%# ((SiteMapNode)Container.DataItem)["ImageUrl"] %>" alt="">
        </asp:HyperLink>
        <p><%# Eval("Description") %></p>
        </section>
    </ItemTemplate>

    <FooterTemplate>
        </div>
        </aside>
    </FooterTemplate>
</asp:Repeater>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BreadCrumb.ascx.cs" Inherits="WET_BOEW_dotnet.App_Master.BreadCrumb" %>
<asp:SiteMapPath ID="smpBC" runat="server" SiteMapProvider="ENSitemapProvider" SkipLinkText="">
    <PathSeparatorTemplate>
        <asp:Image ID="imgBcrumb" Runat="Server" ImageUrl="~/theme/dotnet/images/blank.png" AlternateText="Breadcrumb seperator" />
    </PathSeparatorTemplate>
</asp:SiteMapPath>


<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Splash.master" AutoEventWireup="true" CodeBehind="splashpage.aspx.cs" Inherits="GCWebUsabilityTheme.splashpage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            <section class="col-md-6" lang="en">
            <h2 class="h3 text-center"><asp:Localize ID="LocalizeTitle" runat="server" Text='<%#Eval("siteName") %>' /></h2>
            <ul class="list-unstyled">
                <li><asp:HyperLink runat="server" CssClass="btn btn-lg btn-primary btn-block" NavigateUrl='<%#Eval("homePage") %>' Text='<%#Eval("name") %>' /></li>
                <li><asp:HyperLink runat="server" CssClass="btn btn-lg btn-default btn-block mrgn-tp-sm" NavigateUrl='<%#Eval("licencePage") %>' rel="license" Text='<%#Eval("terms") %>' /></li>
            </ul>
            </section>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>

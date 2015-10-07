<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Breadcrumb.ascx.cs" Inherits="GCWebTheme.Controls.Breadcrumb" %>
<asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" StartingNodeOffset="1" />
<nav role="navigation" id="wb-bc" class="" property="breadcrumb">
<h2 class="wb-inv"><%=Localization.General.you_are_here %></h2>
<div class="container">
<div class="row">
<ol class="breadcrumb">
<asp:Literal ID="BreadcrumbListItems" runat="server" />
</ol>
</div>
</div>
</nav>

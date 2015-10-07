<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TopOfPage.ascx.cs" Inherits="GCWebTheme.Controls.TopOfPage" %>
<ul id="wb-tphp">
<li class="wb-slc">
<a class="wb-sl" href="#wb-cont"><%=Localization.TemplateStrings.tmpl_skip_cont %></a>
</li>
<li class="wb-slc visible-sm visible-md visible-lg">
<a class="wb-sl" href="#wb-info"><%=Localization.TemplateStrings.tmpl_skip_about_site %></a>
</li>
<asp:PlaceHolder ID="PlaceHolderSectionMenu" runat="server" Visible="False">
<li class="wb-slc visible-md visible-lg">
<a class="wb-sl" href="#wb-sec"><%=Localization.TemplateStrings.tmpl_skip_section %></a>
</li>
</asp:PlaceHolder>
</ul>
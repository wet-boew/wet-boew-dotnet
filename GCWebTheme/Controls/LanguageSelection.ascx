<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LanguageSelection.ascx.cs" Inherits="GCWebTheme.Controls.LanguageSelection" %>
<section id="wb-lng" class="visible-md visible-lg text-right">
<h2 class="wb-inv"><%=Localization.TemplateStrings.tmpl_lang_select %></h2>
<div class="row">
<div class="col-md-12">
<ul class="list-inline margin-bottom-none">
<li><asp:HyperLink ID="HyperLinkLanguage1" runat="server" lang="fr" Text="Français" /></li>
</ul>
</div>
</div>
</section>
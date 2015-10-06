<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SearchAndMenus.ascx.cs" Inherits="GCWebUsabilityTheme.Controls.SearchAndMenus" %>
<section class="wb-mb-links col-xs-12 visible-sm visible-xs" id="wb-glb-mn">
<h2><%=Localization.General.srch_menus %></h2>
<ul class="pnl-btn list-inline text-right">
<li><a href="#mb-pnl" title="<%=Localization.General.srch_menus %>" aria-controls="mb-pnl" class="overlay-lnk btn btn-sm btn-default" role="button"><span class="glyphicon glyphicon-search"><span class="glyphicon glyphicon-th-list"><span class="wb-inv"><%=Localization.General.srch_menus %></span></span></span></a></li>
</ul>
<div id="mb-pnl"></div>
</section>
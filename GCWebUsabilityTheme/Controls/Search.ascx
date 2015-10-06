<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Search.ascx.cs" Inherits="GCWebUsabilityTheme.Controls.Search" %>
<section id="wb-srch" class="visible-md visible-lg">
<h2><%=Localization.TemplateStrings.tmpl_search %></h2>
<form action="https://google.ca/search" method="get" role="search" class="form-inline">
<div class="form-group">
<label for="wb-srch-q"><%=Localization.TemplateStrings.tmpl_search_site %></label>
<input id="wb-srch-q" class="form-control" name="q" type="search" value="" size="27" maxlength="150">
<input type="hidden" name="q" value="site:wet-boew.github.io OR site:github.com/wet-boew/">
</div>
<button type="submit" id="wb-srch-sub" class="btn btn-default"><%=Localization.TemplateStrings.tmpl_search %></button>
</form>
</section>
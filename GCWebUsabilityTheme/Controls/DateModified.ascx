<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DateModified.ascx.cs" Inherits="GCWebUsabilityTheme.Controls.DateModified" %>
<dl id="wb-dtmd">
<dt><%= Localization.TemplateStrings.tmpl_date_mod %></dt>
<dd><time property="dateModified"><%=this.PageDateModified%></time></dd>
</dl>
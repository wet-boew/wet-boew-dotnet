<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Search-GCWebUsability.ascx.cs" Inherits="GCWebUsability.Controls.Search_GCWebUsability" %>
<section id="wb-srch" class="visible-md visible-lg">
<h2>Search</h2>
<form action="https://google.ca/search" method="get" role="search" class="form-inline">
<div class="form-group">
<label for="wb-srch-q">Search website</label>
<input id="wb-srch-q" class="form-control" name="q" type="search" value="" size="27" maxlength="150">
<input type="hidden" name="q" value="site:wet-boew.github.io OR site:github.com/wet-boew/">
</div>
<button type="submit" id="wb-srch-sub" class="btn btn-default">Search</button>
</form>
</section>
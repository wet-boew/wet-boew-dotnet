<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SearchBox.ascx.cs" Inherits="WET_BOEW_dotnet.App_Master.SearchBox" %>
<div id="gcwu-srchbx"><h2><asp:Literal ID="ltlSrchHead" runat="server" Text="<%$ Resources:GCWU_FEGC, SrchHead %>"/></h2>
<form action="#" method="post"><div id="gcwu-srchbx-in">
<asp:Label ID="lblSearch" AssociatedControlID="gcwu_srch" runat="server" Text="<%$ Resources:GCWU_FEGC, Srchlbl %>"/>
<asp:TextBox ID="gcwu_srch" runat="server" type="search" MaxLength="150"/>
<asp:Button ID="gcwu_srch_submit" runat="server" Text="<%$ Resources:GCWU_FEGC, btnSrch %>"/>
</div></form>
</div>
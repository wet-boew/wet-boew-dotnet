<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LangSwitcher.ascx.cs" Inherits="WET_BOEW_dotnet.App_Master.LangSwitcher" %>
<asp:LinkButton ID="lbtnSwitch" runat="server" CausesValidation="False" 
    onclick="lbtnSwitch_Click" Text="<%$ Resources:GCWU_FEGC, hlkLangSwitch%>">LinkButton</asp:LinkButton>
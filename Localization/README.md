# WET-BOEW Localization files

Localization strings can be found here:  https://docs.google.com/spreadsheets/d/1BmMrKN6Rtx-dwgPNEZD6AIAQdI4nNlyVVVCml0U594o/edit?pli=1#gid=1

What won't work at this point is to use Resources expression, e.g., <asp:Button runat="server" Text="<%$ Resources:NameOfResx,MyButtonText %>" />.
To solve that problem, make a custom resource ExpressionBuilder.  See http://stackoverflow.com/questions/2140628/sharing-asp-net-resource-files-between-web-applications
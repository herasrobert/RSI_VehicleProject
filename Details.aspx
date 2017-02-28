<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Details.aspx.cs" Inherits="Details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:LinkButton ID="MainPageBtn" runat="server" PostBackUrl="~/Default.aspx">Main Page</asp:LinkButton>

        <br />
        <br />
        <br />
        Vehicle Type:&nbsp;&nbsp;&nbsp;
        <asp:Label ID="TypeLbl" runat="server" Text="Label"></asp:Label>
        <br />
        Make:&nbsp;&nbsp;&nbsp; <asp:Label ID="MakeLbl" runat="server" Text="Label"></asp:Label>
        <br />
        Model:&nbsp;&nbsp;&nbsp; <asp:Label ID="ModelLbl" runat="server" Text="Label"></asp:Label>
        <br />
        Color:&nbsp;&nbsp;Color:&nbsp;&nbsp;&nbsp;
        <asp:Label ID="ColorLbl" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="InteriorLbl" runat="server" Text="Interior: " Visible="False"></asp:Label>
        <asp:Label ID="InteriorVarLbl" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
                <asp:Label ID="NumDoorsLbl" runat="server" Text="Number of Doors: " Visible="False"></asp:Label>
        <asp:Label ID="NumDoorsVarLbl" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />        
        <asp:Label ID="KickStandExtLbl" runat="server" Text="Kick Stand Extended: " Visible="False"></asp:Label>
        <asp:TextBox ID="KickStandExtVarTxtBox" runat="server" Enabled="False" Visible="False"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Engine Status:"></asp:Label>
        <asp:TextBox ID="EngStatusTxtBox" runat="server" Enabled="False"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Fuel Level:"></asp:Label>
        <asp:TextBox ID="FuelLevelTxtBox" runat="server" Enabled="False"></asp:TextBox>
        <br />
        <br />
        Error: <asp:Label ID="errorLabel" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Button ID="StartEngBtn" runat="server" OnClick="StartEngBtn_Click" Text="Start Engine" />
        <asp:Button ID="StopEngBtn" runat="server" OnClick="StopEngBtn_Click" Text="Stop Engine" />
        <asp:Button ID="FuelUpBtn" runat="server" OnClick="FuelUpBtn_Click" Text="Fuel Up" />
        <asp:Button ID="AccelerateBtn" runat="server" OnClick="AccelerateBtn_Click" Text="Accelerate" />

        <asp:Button ID="KickStandBtn" runat="server" OnClick="KickStandBtn_Click" Text="Switch KickStand" Visible="False" />

    </div>
    </form>
</body>
</html>

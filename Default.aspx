<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged1" TabIndex="1">
            <asp:ListItem Selected="True">Select Vehicle Type</asp:ListItem>
            <asp:ListItem>Car</asp:ListItem>
            <asp:ListItem>Motorcyle</asp:ListItem>
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="AddBtn" runat="server" OnClick="AddBtn_Click" TabIndex="7" Text="Add" Visible="False" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Make: " Visible="False"></asp:Label>
        <asp:TextBox ID="MakeTxtBox" runat="server" OnTextChanged="MakeTxtBox_TextChanged" TabIndex="2" Visible="False"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Model: " Visible="False"></asp:Label>
        <asp:TextBox ID="ModelTxtBox" runat="server" TabIndex="3" Visible="False"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Color: " Visible="False"></asp:Label>
        <asp:TextBox ID="ColorTxtBox" runat="server" TabIndex="4" Visible="False"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Interior:" Visible="False"></asp:Label>
        <asp:RadioButtonList ID="InteriorRadioBtn" runat="server" OnSelectedIndexChanged="InteriorRadioBtn_SelectedIndexChanged" Visible="False">
            <asp:ListItem>Cloth</asp:ListItem>
            <asp:ListItem>Leather</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Num Doors:" Visible="False"></asp:Label>
        <asp:TextBox ID="NumDoorsTxtBox" runat="server" TabIndex="6" Visible="False" TextMode="Number">0</asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:GridView ID="VehicleGridView" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="VehicleGridView_SelectedIndexChanged">
            <columns>
              <asp:boundfield datafield="make" headertext="Make"/>
              <asp:boundfield datafield="model" headertext="Model"/>
              <asp:boundfield datafield="color" headertext="Color"/>
              <asp:HyperLinkField DataTextField="ID" DataNavigateUrlFields="Id" DataTextFormatString="View Details" DataNavigateUrlFormatString="~/Details.aspx?Id={0}" />
            </columns>   
        </asp:GridView>
        <br />
        <br />
        <br />
    </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>


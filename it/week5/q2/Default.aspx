<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label><asp:TextBox ID="TxtName" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label2" runat="server" Text="Roll"></asp:Label><asp:TextBox ID="TxtRoll" runat="server"></asp:TextBox><br />
        <asp:DropDownList ID="ddlSubjects" runat="server"></asp:DropDownList><br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button"/>
    </div>
    </form>
</body>
</html>

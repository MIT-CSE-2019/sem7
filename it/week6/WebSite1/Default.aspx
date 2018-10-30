<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Panel ID="Panel1" BorderStyle="Dashed" runat="server">
        <asp:Label ID="Label1" runat="server" Text="NAME"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br/>
        <asp:Label ID="Label2" runat="server" Text="AGE"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br/>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>

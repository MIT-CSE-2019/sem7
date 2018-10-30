<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <asp:DropDownList ID="DropDownList1" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true" runat="server"></asp:DropDownList>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <br />
        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="update" />
    

    </div>
    </form>
</body>
</html>

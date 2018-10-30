<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="pname" runat="server"></asp:TextBox>
        <asp:TextBox ID="cname" runat="server"></asp:TextBox>
        <asp:TextBox ID="sal" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" OnClick="Button1_Click" runat="server" Text="INSERT" />
        <br />

        <asp:TextBox ID="txtCname" runat="server"></asp:TextBox>
        <asp:Button ID="Button2" OnClick="Button2_Click" runat="server" Text="DISPLAY" />
        <br />
        <asp:Label ID="Label1" runat="server" ></asp:Label>


    </div>
    </form>
</body>
</html>

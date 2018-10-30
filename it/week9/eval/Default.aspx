<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Username <asp:TextBox ID="TextBox1" runat="server"  ></asp:TextBox><br />
        Password <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button2" runat="server" Text="Sign up" />
        <asp:Button ID="Button3" runat="server" Text="Log In" />
        <br />
        
        
        <asp:DropDownList ID="ddl_themes"  runat="server"></asp:DropDownList>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save Theme" />
    </div>
    </form>
</body>
</html>

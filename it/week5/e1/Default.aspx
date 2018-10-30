<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Button ID="BtnCounter" runat="server" Text="Button" OnClick="Button1_Click"/>
        <asp:Label ID="labelCounter" runat="server" />
    </div>
    </form>
    
</body>
</html>

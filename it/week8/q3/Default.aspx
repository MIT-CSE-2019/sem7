<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <asp:TextBox ID="txtItemid" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtFlavour" runat="server"></asp:TextBox>
       
        <asp:Button ID="btnAdd" OnClick="btnAdd_Click" runat="server" Text="ADD" />
        <br />
        <asp:Label ID="lblDisplay" runat="server" ></asp:Label>
        <asp:Button ID="btnDisplay" OnClick="btnDisplay_Click" runat="server" Text="DISPLAY" />
        <br />
        <asp:TextBox ID="txtVanila" runat="server"></asp:TextBox>
        <asp:Button ID="updateVanilla" OnClick="updateVanilla_Click" runat="server" Text="UPDATE" />

        
    </div>
    </form>
</body>
</html>

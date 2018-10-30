<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="overflow: hidden">
            
            <asp:Panel ID="Panel1" runat="server" BorderColor="#990000" BorderStyle="Double"
                Height="500px" Style="width: 48%; float: left">
                <br />choose a background color<br />
                <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
               <br /> <br />choose a font<br />
                <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
                <br /><br />enter a numeric font size<br />
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />enter border style<br/>
                <asp:RadioButtonList ID="RadioButtonList1" runat="server"></asp:RadioButtonList>
                <br />
             
                enter  message <br />
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <br /><br />
                <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />

                <br />
            </asp:Panel>
            
            
            <asp:Panel ID="Panel2" runat="server" HorizontalAlign="Center" BorderColor="#ff0000" BorderStyle="Solid"
                Height="500px" Style="width: 48%; float: right">
                <asp:Label ID="TextBox2" runat="server" Text="Hello world"></asp:Label>
              
                
                <br />
                <asp:Image ID="Image1" runat="server" Width="75%" Height="75%" />
               
            </asp:Panel>

        </div>

    </form>
</body>
</html>

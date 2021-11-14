<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebAppPhotEX.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" style="font-size: xx-large" Text="WELCOME TO PHOTEX LOGIN"></asp:Label>
        </div>
        <asp:Label ID="Label2" runat="server" Text="User_Name:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Height="19px" style="margin-left: 83px" Width="118px"></asp:TextBox>
        <div style="margin-left: 560px">
            <asp:Label ID="LblMessage" runat="server" Text="..."></asp:Label>
        </div>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 95px"></asp:TextBox>
        </p>
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Register_Account</asp:LinkButton>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 75px" Text="Login" Width="101px" />
        <asp:Button ID="Button2" runat="server" Height="26px" OnClick="Button2_Click" style="margin-left: 56px" Text="Exit" Width="50px" />
    </form>
</body>
</html>

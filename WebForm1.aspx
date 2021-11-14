<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebAppPhotEX.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>WELCOME TO PHOTEX</title>
    <style type="text/css">
        .auto-style2 {
            font-size: xx-large;
            margin-left: 3px;
            text-align: center;
        }
    </style>
</head>
<body style="height: 572px">
    <form id="form1" runat="server">
        
        <div>
            <asp:HiddenField ID="hfID_Number" runat="server" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
        <p class="auto-style2" style="border-style: solid">
            WELCOME TO PHOTEX</p>
        <asp:Label ID="Label1" runat="server" Text="ID_Number"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Height="16px" style="margin-left: 70px" Width="153px" MaxLength="13"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="LblMessage" runat="server" Text="  "></asp:Label>
&nbsp;<p>
            <asp:Label ID="Label2" runat="server" Text="First_Name"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 70px" Width="157px"></asp:TextBox>
        </p>
        <asp:Label ID="Label3" runat="server" Text="Last_Name"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 71px" Width="155px"></asp:TextBox>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Email_ID"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" style="margin-left: 83px" Width="153px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="User_Name"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server" style="margin-left: 70px" Width="151px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label6" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="TextBox6" runat="server" style="margin-left: 81px" Width="155px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label7" runat="server" Text="Confirm_Password"></asp:Label>
            <asp:TextBox ID="TextBox7" runat="server" style="margin-left: 24px" Width="159px"></asp:TextBox>
        </p>
        <asp:LinkButton ID="loginLinkBtn" runat="server" OnClick="LinkButton1_Click" style="font-size: x-large">Login</asp:LinkButton>
        <asp:Button ID="BtnRegister" runat="server" OnClick="Button1_Click" style="margin-left: 185px" Text="Submit" Width="82px" />
    </form>
</body>
</html>

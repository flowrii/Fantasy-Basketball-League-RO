<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginWebForm.aspx.cs" Inherits="Proiect_v2.LoginWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        

        .auto-style9 {
            height: 209px;
            width: 1021px;
            font-family: 'OCR A';
            font-style:normal;
            
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style9">
            <asp:Panel ID="Panel1" runat="server" BackImageUrl="~/Stockz/pagina web_Login.png" Direction="LeftToRight" Height="1080px" HorizontalAlign="Center" Width="1920px" >
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                &nbsp;
                <br />
                <br />
                Username
                <asp:TextBox ID="userTextBox" runat="server" Width="178px"></asp:TextBox>
                <br />
                <br />
                Password
                <asp:TextBox ID="passTextBox" runat="server" TextMode="Password" Width="176px"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="loginBtn" runat="server" OnClick="loginBtn_Click" Text="Login" Width="73px" />
                <br />
                <asp:Label ID="Label1" runat="server"></asp:Label>
                <br />
                <asp:Label ID="Label2" runat="server"></asp:Label>
                <br />
                <br />
                Don&#39;t have an account?
                <asp:Button ID="registerBtn" runat="server" OnClick="registerBtn_Click" Text="Register" Width="108px" />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
            </asp:Panel>
        </div>
    </form>
</body>
</html>

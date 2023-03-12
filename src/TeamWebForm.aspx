<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TeamWebForm.aspx.cs" Inherits="Proiect_v2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 1080px;
            font-family:'OCR A';
            font-style:normal;
        }
        .auto-style2 {
            width: 100%;
            height: 307px;
            font-family: 'OCR A';
            font-style:normal;
        }
        .auto-style3 {
            margin-left: 79px;
            font-family: 'OCR A';
            font-style:normal;
        }
        .auto-style4 {
            margin-left: 87px;
            margin-right: 823px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style1">
        <asp:Panel ID="Panel1" runat="server" Height="1080px" BackImageUrl="~/Stockz/TEAM_TEAM_TEAM.png" Width="1920px">
            &nbsp;<br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Font-Names="OCR A" Font-Size="25pt" Text="Insert a name for your team"></asp:Label>
            &nbsp;<br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="nameTextBox" runat="server" Height="60px" Width="797px"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" font-family="OCR A" Font-Names="OCR A" Font-Size="25pt" font-style="bold" Text="Insert a link for the logo of your team"></asp:Label>
            &nbsp;<br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="linkTextBox" runat="server" Height="60px" Width="797px"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <asp:Panel ID="Panel3" runat="server" CssClass="auto-style4" Font-Names="STAR7" Font-Size="30pt" ForeColor="#003049" Height="60px" HorizontalAlign="Center" Width="805px">
                Pick a team from each tier</asp:Panel>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label4" runat="server" Font-Size="20pt" ForeColor="#003049" Text="Tier 1"></asp:Label>
            &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label5" runat="server" Font-Size="20pt" ForeColor="#003049" Text="Tier 2"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label6" runat="server" Font-Size="20pt" ForeColor="#003049" Text="Tier 3"></asp:Label>
            <br />
            <asp:Panel ID="Panel2" runat="server" CssClass="auto-style3" Height="312px" Width="1074px">
                <table class="auto-style2">
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="RadioButtonList1" runat="server" Font-Names="OCR A" Font-Size="20pt">
                                <asp:ListItem Value="3419">U BT Cluj Napoca</asp:ListItem>
                                <asp:ListItem Value="975">CSM Oradea</asp:ListItem>
                                <asp:ListItem Value="983">CSO Voluntari</asp:ListItem>
                                <asp:ListItem Value="1651">Rapid Bucuresti</asp:ListItem>
                                <asp:ListItem Value="978">Dinamo Bucuresti</asp:ListItem>
                                <asp:ListItem Value="971">BC Timisoara</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td>
                            <asp:RadioButtonList ID="RadioButtonList2" runat="server" Font-Names="OCR A" Font-Size="20pt">
                                <asp:ListItem Value="981">SCM Craiova</asp:ListItem>
                                <asp:ListItem Value="972">BCM Pitesti</asp:ListItem>
                                <asp:ListItem Value="976">CSU Sibiu</asp:ListItem>
                                <asp:ListItem Value="4007">Petrolul Ploiesti</asp:ListItem>
                                <asp:ListItem Value="970">BC Steaua Bucuresti</asp:ListItem>
                                <asp:ListItem Value="969">Athletic Constanta</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td>
                            <asp:RadioButtonList ID="RadioButtonList3" runat="server" Font-Names="OCR A" Font-Size="20pt">
                                <asp:ListItem Value="980">CSM Galati</asp:ListItem>
                                <asp:ListItem Value="1648">BC Targu Mures</asp:ListItem>
                                <asp:ListItem Value="979">Miercurea Ciuc</asp:ListItem>
                                <asp:ListItem Value="973">CSM Focsani</asp:ListItem>
                                <asp:ListItem Value="5620">Laguna Bucuresti</asp:ListItem>
                                <asp:ListItem Value="2484">CSM Targu Jiu</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                </table>
            </asp:Panel>
            <br />
            &nbsp;&nbsp;<br /> &nbsp;
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:ImageButton ID="createBtn" runat="server" Height="96px" ImageUrl="~/Stockz/2.png" Width="382px" OnClick="ImageButton1_Click" />
            &nbsp;
            <asp:ImageButton ID="joinBtn" runat="server" ImageUrl="~/Stockz/joinleague.png" OnClick="ImageButton2_Click" />
            <br />
        </asp:Panel>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
    </form>
</body>
</html>

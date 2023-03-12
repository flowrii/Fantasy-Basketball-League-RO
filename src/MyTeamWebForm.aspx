<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyTeamWebForm.aspx.cs" Inherits="Proiect_v2.MyTeamWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            margin-top: 0px;
        }
        .auto-style9 {
            width: 385px;
        }
        .auto-style24 {
            width: 117px;
        }
        .auto-style25 {
            margin-top: 8px;
        }
        .auto-style43 {
            height: 61px;
        }
        .auto-style44 {
            width: 385px;
            height: 61px;
        }
        .auto-style45 {
            width: 117px;
            height: 61px;
        }
        .auto-style48 {
            width: 382px;
            height: 46px;
        }
        .auto-style49 {
            height: 212px;
            width: 382px;
        }
        .auto-style50 {
            width: 382px;
            height: 61px;
        }
        .auto-style51 {
            width: 382px;
        }
        .auto-style52 {
            height: 46px;
            width: 108px;
        }
        .auto-style53 {
            height: 212px;
            width: 108px;
        }
        .auto-style54 {
            width: 108px;
            height: 61px;
        }
        .auto-style55 {
            width: 108px;
        }
        .auto-style56 {
            height: 212px;
        }
        .auto-style57 {
            height: 212px;
            width: 385px;
        }
        .auto-style58 {
            height: 212px;
            width: 117px;
        }
        .auto-style59 {
            height: 46px;
            width: 128px;
        }
        .auto-style60 {
            height: 212px;
            width: 128px;
        }
        .auto-style61 {
            height: 61px;
            width: 128px;
        }
        .auto-style62 {
            width: 128px;
        }
        .auto-style63 {
            margin-left: 115px;
            margin-top: 7px;
        }
        .auto-style64 {
            margin-left: 7px;
            margin-top: 4px;
        }
        .auto-style65 {
            width: 206px;
        }
        .auto-style66 {
            margin-top: 0px;
            margin-left: 1px;
            margin-bottom: 0px;
        }
        .auto-style67 {
            height: 46px;
        }
        .auto-style68 {
            width: 385px;
            height: 46px;
        }
        .auto-style69 {
            height: 46px;
            width: 117px;
        }
        .auto-style70 {
            width: 128px;
            height: 394px;
        }
        .auto-style71 {
            height: 394px;
        }
        .auto-style72 {
            width: 385px;
            height: 394px;
        }
        .auto-style73 {
            width: 117px;
            height: 394px;
        }
        .auto-style74 {
            width: 108px;
            height: 394px;
        }
        .auto-style75 {
            width: 382px;
            height: 394px;
        }
        .auto-style76 {
            width: 128px;
            height: 42px;
        }
        .auto-style77 {
            height: 42px;
        }
        .auto-style78 {
            width: 385px;
            height: 42px;
        }
        .auto-style79 {
            width: 117px;
            height: 42px;
        }
        .auto-style80 {
            width: 108px;
            height: 42px;
        }
        .auto-style81 {
            width: 382px;
            height: 42px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel ID="Panel1" runat="server" Height="1080px" Width="1920px" BackImageUrl="~/Stockz/your GAME FMM_create-join copy 2.png" Direction="LeftToRight" HorizontalAlign="Center">
            <br />
            <br />
            <br />
            <table style="width:100%;">
                <tr>
                    <td class="auto-style60">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:ImageButton ID="editLogoBtn" runat="server" ImageAlign="Right" ImageUrl="~/Stockz/edit.png" OnClick="editLogoBtn_Click" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                    <td class="auto-style56">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Panel ID="Panel2" runat="server" CssClass="auto-style63" Height="216px" HorizontalAlign="Center" Width="220px">
                            &nbsp;&nbsp;
                            <asp:Image ID="Image1" runat="server" AlternateText="Crest couldn't load" BackColor="White" BorderStyle="None" CssClass="auto-style64" Height="196px" ImageAlign="Left" Width="210px" />
                        </asp:Panel>
                    </td>
                    <td class="auto-style57">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; </td>
                    <td class="auto-style57" colspan="4">&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                    <td class="auto-style58"></td>
                    <td class="auto-style58"></td>
                    <td class="auto-style58"></td>
                    <td class="auto-style53"></td>
                    <td class="auto-style56"></td>
                    <td class="auto-style49" colspan="3">&nbsp;<br />
                        <br />
                        <br />
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp; </td>
                    <td class="auto-style56">
                        <asp:ImageButton ID="settingsBtn" runat="server" CssClass="auto-style66" Height="47px" ImageAlign="Left" OnClick="ImageButton1_Click" Width="111px" ImageUrl="~/Stockz/settings.png" />
                    </td>
                    <td class="auto-style56"></td>
                    <td class="auto-style56"></td>
                </tr>
                <tr>
                    <td class="auto-style61"></td>
                    <td class="auto-style43">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
                        <br />
                        <br />
                    </td>
                    <td class="auto-style44"></td>
                    <td class="auto-style44" colspan="4">
                        <asp:TextBox ID="editTextBox" runat="server" Font-Names="OCR A" Font-Size="16pt" Height="28px" Width="408px"></asp:TextBox>
                    </td>
                    <td class="auto-style45"></td>
                    <td class="auto-style45"></td>
                    <td class="auto-style45"></td>
                    <td class="auto-style54"></td>
                    <td class="auto-style43"></td>
                    <td class="auto-style50" colspan="3"></td>
                    <td class="auto-style43"></td>
                    <td class="auto-style43"></td>
                    <td class="auto-style43"></td>
                </tr>
                <tr>
                    <td class="auto-style62">&nbsp;</td>
                    <td>
                        <asp:Label ID="TeamNameLabel" runat="server" Font-Bold="True" Font-Names="STAR7" Font-Size="30pt" ForeColor="#FFFFCC"></asp:Label>
                    </td>
                    <td class="auto-style9">
                        <asp:ImageButton ID="editNameBtn" runat="server" CssClass="auto-style25" Height="50px" ImageAlign="Top" ImageUrl="~/Stockz/editname_1.png" Width="172px" OnClick="editNameBtn_Click" />
                    </td>
                    <td class="auto-style65" colspan="2">
                        <asp:ImageButton ID="saveNBtn" runat="server" Height="51px" ImageAlign="Middle" ImageUrl="~/Stockz/Save.png" OnClick="saveNBtn_Click" Width="111px" />
                    </td>
                    <td class="auto-style9" colspan="2">
                        <asp:ImageButton ID="saveLBtn" runat="server" Height="51px" ImageAlign="Middle" ImageUrl="~/Stockz/Save.png" OnClick="saveLBtn_Click" Width="111px" />
                    </td>
                    <td class="auto-style24">&nbsp;</td>
                    <td class="auto-style24">&nbsp;</td>
                    <td class="auto-style24">&nbsp;</td>
                    <td class="auto-style55">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style51" colspan="3">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style59"></td>
                    <td class="auto-style67">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                    <td class="auto-style68"></td>
                    <td class="auto-style68" colspan="4">&nbsp; &nbsp;</td>
                    <td class="auto-style69"></td>
                    <td class="auto-style69"></td>
                    <td class="auto-style69"></td>
                    <td class="auto-style52"></td>
                    <td class="auto-style67"></td>
                    <td class="auto-style48" colspan="3"></td>
                    <td class="auto-style67"></td>
                    <td class="auto-style67"></td>
                    <td class="auto-style67"></td>
                </tr>
                <tr>
                    <td class="auto-style76"></td>
                    <td class="auto-style77">
                        <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="OCR A" Font-Size="20pt" Text="My Teams"></asp:Label>
                    </td>
                    <td class="auto-style78"></td>
                    <td class="auto-style78"></td>
                    <td class="auto-style78" colspan="2">
                        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="OCR A" Font-Size="20pt" Text="Ranking"></asp:Label>
                    </td>
                    <td class="auto-style78"></td>
                    <td class="auto-style79"></td>
                    <td class="auto-style79"></td>
                    <td class="auto-style79"></td>
                    <td class="auto-style80"></td>
                    <td class="auto-style77"></td>
                    <td class="auto-style81"></td>
                    <td class="auto-style81">
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="OCR A" Font-Size="20pt" Text="Last game"></asp:Label>
                    </td>
                    <td class="auto-style81"></td>
                    <td class="auto-style77"></td>
                    <td class="auto-style77"></td>
                    <td class="auto-style77"></td>
                </tr>
                <tr>
                    <td class="auto-style70">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                    <td class="auto-style71">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:GridView ID="myTeamsGrid" runat="server" CssClass="auto-style2" Font-Names="OCR A" GridLines="None" Height="386px" Width="407px" Font-Size="16pt">
                            <RowStyle Font-Names="OCR A" />
                        </asp:GridView>
                    </td>
                    <td class="auto-style72"></td>
                    <td class="auto-style72" colspan="4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:GridView ID="standingGrid" runat="server" CellPadding="5" Font-Names="OCR A" GridLines="None" Height="389px" HorizontalAlign="Center" Width="423px" Font-Size="16pt">
                            <RowStyle Font-Names="OCR A" />
                        </asp:GridView>
                    </td>
                    <td class="auto-style73">&nbsp;&nbsp; &nbsp;</td>
                    <td class="auto-style73"></td>
                    <td class="auto-style73"></td>
                    <td class="auto-style74"></td>
                    <td class="auto-style71">&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                    <td class="auto-style75" colspan="3">
                        <asp:GridView ID="lastGameGrid" runat="server" Font-Names="OCR A" GridLines="None" Height="386px" HorizontalAlign="Center" Width="415px" Font-Size="16pt">
                            <SelectedRowStyle BackColor="#FF9933" />
                        </asp:GridView>
                    </td>
                    <td class="auto-style71">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                    <td class="auto-style71"></td>
                </tr>
                <tr>
                    <td class="auto-style62">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style9" colspan="4">&nbsp;</td>
                    <td class="auto-style24">&nbsp;</td>
                    <td class="auto-style24">&nbsp;</td>
                    <td class="auto-style24">&nbsp;</td>
                    <td class="auto-style55">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style51" colspan="3">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <br />
            <br />
        </asp:Panel>
    </form>
</body>
</html>

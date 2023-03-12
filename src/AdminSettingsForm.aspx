<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminSettingsForm.aspx.cs" Inherits="Proiect_v2.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 1080px;
        }
        .auto-style2 {
            margin-left: 76px;
            margin-top: 118px;
            font-family : "OCR A";
            font-size : 20;
            margin-bottom: 9px;
        }
        .auto-style3 {
            height: 51px;
             font-family : "OCR A";
            font-size : 20;
            width: 198px;
        }
        .auto-style5 {
            width: 198px;
        }
        .auto-style6 {
            width: 198px;
            height: 59px;
        }
        .auto-style7 {
            height: 59px;
        }
        .auto-style8 {
            width: 164px;
            height: 59px;
        }
        .auto-style9 {
            margin-left: 0px;
        }
        .auto-style13 {
            width: 247px;
            height: 59px;
        }
        .auto-style14 {
            margin-left: 25px;
        }
    </style>
</head>
<body style="height : 1080px, width : 1920 px;">
    <form id="form1" runat="server" class="auto-style1">
        <asp:Panel ID="Panel1" runat="server" Height="1080px" BackImageUrl="~/Stockz/settingz_create-join copy 3.png" Width="1920px">
            <br />
            <br />
            <br />
            <br />
            <asp:Panel ID="Panel2" runat="server" CssClass="auto-style2" Height="244px" Width="1133px">
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style3">
                            <asp:Label ID="Label1" runat="server" Text="ScoreValue" Font-Names="OCR A" Font-Size="20pt" ForeColor="#F77F00"></asp:Label>
                        </td>                       
                        <td colspan="2">
                            <asp:TextBox ID="scoreTxtBox0" runat="server" Height="35px" Width="234px" CssClass="auto-style14"></asp:TextBox>
                        </td>                               
                        <td colspan="2">
                            <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="OCR A" Font-Size="20pt" ForeColor="#F77F00" Text="Your League Code:"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5">&nbsp;</td>
                        <td colspan="4">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style5">
                            <asp:Label ID="Label2" runat="server" Text="QuarterValue" Font-Names="OCR A" Font-Size="20pt" ForeColor="#F77F00"></asp:Label>
                        </td>
                        <td colspan="2">
                            <asp:TextBox ID="quarterTxtBox" runat="server" Height="35px" Width="234px" CssClass="auto-style14"></asp:TextBox>
                        </td>
                        <td colspan="2">
                            <asp:Label ID="codeLabel" runat="server" Font-Bold="True" Font-Names="OCR A" Font-Size="35pt" ForeColor="#F77F00"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5">&nbsp;</td>
                        <td colspan="4">
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6">
                            &nbsp;</td>
                        <td class="auto-style8">
                            <asp:ImageButton ID="ConfirmChanges" runat="server" AlternateText="Save" Height="55px" ImageAlign="Left" ImageUrl="~/Stockz/Save.png" OnClick="ConfirmChanges_Click" Width="120px" />
                        </td>
                        <td class="auto-style13">
                            <asp:ImageButton ID="Cancel" runat="server" AlternateText="Cancel" CssClass="auto-style9" Height="55px" ImageUrl="~/Stockz/cancel_1.png" OnClick="Cancel_Click" Width="120px" />
                        </td>
                        <td class="auto-style7">&nbsp;</td>
                        <td class="auto-style7">&nbsp;</td>
                    </tr>
                </table>
            </asp:Panel>
        </asp:Panel>
    </form>
</body>
</html>

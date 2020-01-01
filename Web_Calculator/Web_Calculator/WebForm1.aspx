<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Web_Calculator.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: center;
        }
    </style>
</head>
<body style="width: 416px">
    <form id="form1" runat="server">
        <div>
            <div class="auto-style2">
                WebCalculator V1.0</div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2" colspan="2">Input X</td>
                    <td class="auto-style2" colspan="2">
                        <asp:TextBox ID="InputX" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="2">Input Y</td>
                    <td class="auto-style2" colspan="2">
                        <asp:TextBox ID="InputY" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="2">Solution:</td>
                    <td class="auto-style2" colspan="2">
                        <asp:Label ID="labelSolution" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="btnAddition" runat="server" Text="+" Width="100px" OnClick="btnAdd_Click1" />
                    </td>
                    <td class="auto-style2">
                        <asp:Button ID="btnSubtraction" runat="server" Text="-" Width="100px" OnClick="btnSub_Click1" />
                    </td>
                    <td class="auto-style2">
                        <asp:Button ID="btnMultiplication" runat="server" Text="x" Width="100px" OnClick="btn_Mult_Click" />
                    </td>
                    <td class="auto-style2">
                        <asp:Button ID="btnDivision" runat="server" Text="/" Width="100px" OnClick="btn_Div_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

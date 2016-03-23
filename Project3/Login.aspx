<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Project3.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Login Page</title>
    <style type="text/css">
        .auto-style1 {
            width: 61px;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">
    <div>
        <h2>Login</h2>
        <asp:Label ID="lblWarning" runat="server" forecolor="red"></asp:Label>
        <br />
        <asp:Label ID="lblShow" runat="server" forecolor="green"></asp:Label>
        <br />

        <table>
            <tr>
                <td>
                    <asp:Label ID="lblUsername" runat="server" Text="Username"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>

        <br />
        <asp:Button type="submit" ID="btnSubmit" runat="server" Text="Login" onclick="btnSubmit_Click"/>

        <br />
        <asp:Button ID="btnCreate" runat="server" Text="New Account" OnClick="btnCreate_Click" />
    </div>

    </form>
</body>
</html>

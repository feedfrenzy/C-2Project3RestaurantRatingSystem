<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewAccount.aspx.cs" Inherits="Project3.NewAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Account Creation</h2>
        <asp:Label ID="lblShow" Forecolor="Green" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblWarning" Forecolor="Red" runat="server"></asp:Label>
        <br /><br />

        <asp:Label ID="lblUsername" runat="server" Text="Username: "></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
        <br />

        <asp:Label ID="lblPassword" runat="server" Text="Password: "></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <br />

        <asp:Label ID="lblSelectType" runat="server" Text="Account Type: "></asp:Label>

        <asp:DropDownList ID="ddlAccountType" runat="server">
             <asp:ListItem>Reviewer</asp:ListItem>
             <asp:ListItem>Representative</asp:ListItem>
        </asp:DropDownList>
        <br />

        <asp:Button ID="btnCreate" runat="server" Text="Create Account" OnClick="btnCreate_Click"/>
      
    </div>

    </form>
</body>
</html>

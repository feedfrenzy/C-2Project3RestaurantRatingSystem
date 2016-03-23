<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReservationDetail.aspx.cs" Inherits="Project3.ReservationDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblShow" runat="server" ForeColor="Green"></asp:Label>
        <asp:Label ID="lblWarning" runat="server" ForeColor="Red"></asp:Label>
        <br />
    
    </div>

        <asp:GridView ID="gvReservation" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="RestaurantName" HeaderText="Restaurant Name" />
                <asp:BoundField DataField="RestaurantType" HeaderText="Restaurant Type" />
                <asp:BoundField DataField="RestaurantDesc" HeaderText="Restaurant Description" />
            </Columns>
        </asp:GridView>

        <br /><br />


        <asp:Label ID="lblName" runat="server" Text="Customer name: "></asp:Label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>

        <asp:Label ID="lblCount" runat="server" Text="Numbers of People: "></asp:Label>
        <asp:TextBox ID="txtCount" runat="server"></asp:TextBox>

        <br />
        <asp:Label ID="lblTime" runat="server" Text="Reservation Time: "></asp:Label>
        <asp:DropDownList ID="ddlTime" runat="server">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>1100</asp:ListItem>
            <asp:ListItem>1200</asp:ListItem>
            <asp:ListItem>1300</asp:ListItem>
            <asp:ListItem>1400</asp:ListItem>
            <asp:ListItem>1500</asp:ListItem>
            <asp:ListItem>1600</asp:ListItem>
            <asp:ListItem>1700</asp:ListItem>
            <asp:ListItem>1800</asp:ListItem>
            <asp:ListItem>1900</asp:ListItem>
            <asp:ListItem>2000</asp:ListItem>
            <asp:ListItem>2100</asp:ListItem>
            <asp:ListItem>2200</asp:ListItem>
        </asp:DropDownList>
        

        <br />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit Reservation" OnClick="Button1_Click"/>
        <asp:button ID="btnBack" runat="server" text="Back" OnClick="btnBack_Click" />
    </form>
</body>

</html>

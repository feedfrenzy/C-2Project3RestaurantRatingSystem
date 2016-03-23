<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Restaurant.aspx.cs" Inherits="Project3.Restaurant" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Restaurant</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <h2>Add New Restaurant</h2>
        <asp:Label ID="lblRestName" runat="server" Text="Restaurant Name: "></asp:Label>
        <asp:TextBox ID="txtRestName" runat="server"></asp:TextBox>
        <br />

        <asp:Label ID="lblRestType" runat="server" Text="Restaurant Type"></asp:Label>
        <asp:TextBox ID="txtRestType" runat="server"></asp:TextBox>
        <br />

        <asp:Label ID="lblRestDesc" runat="server" Text="Restaurant Description: "></asp:Label>
        <br />
        <asp:TextBox ID="txtRestDesc" runat="server" Height="58px" Width="192px"></asp:TextBox>
        <br />

        <asp:Button ID="btnAddRest" runat="server" Text="Add New Restaurant" OnClick="btnAddRest_Click"/>

        <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" />

        <br /><br /><br />
        <asp:Button ID="btnReview" runat="server" Text="Review Restaurant" OnClick="btnReview_Click" />
        <br />
        <asp:Button ID="btnReservation" runat="server" Text="Make Reservation" OnClick="btnReservation_Click"/>




        <br /><br />
        <asp:Label ID="lblShow" runat="server" forecolor="Green"></asp:Label>
        <br />
        <asp:Label ID="lblWarning" runat="server" forecolor="Red"></asp:Label>
        <br />

        <h3>Current Restaurant Lists: </h3>
        <asp:GridView ID="gvRestaurant" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="RestaurantID" HeaderText="Restaurant ID" />
                <asp:BoundField DataField="RestaurantName" HeaderText="Restaurant Name" />
                <asp:BoundField DataField="RestaurantType" HeaderText="Restaurant Type" />
                <asp:BoundField DataField="RestaurantDesc" HeaderText="Restaurant Description" />
            </Columns>
        </asp:GridView>
    </div>

    </form>
</body>
</html>

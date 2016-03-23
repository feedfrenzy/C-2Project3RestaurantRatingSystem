<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReservationManage.aspx.cs" Inherits="Project3.ReservationManage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="gvReservation" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="ReservationID" HeaderText="Reservation ID" />
                <asp:BoundField DataField="RestaurantID" HeaderText="Restaurant ID" />
                <asp:BoundField DataField="RestaurantName" HeaderText="Restaurant Name" />
                <asp:BoundField DataField="ReservationCount" HeaderText="Reservation People" />
                <asp:BoundField DataField="ReservationTime" HeaderText="Reservation time" />
                <asp:BoundField DataField="ReservationCustomerName" HeaderText="Customer Name" />
                <asp:ButtonField ButtonType="Button" CommandName="cancelReservation" HeaderText="Cancel" Text="Cancel Reservation" />
            </Columns>
        </asp:GridView>
    
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <asp:Button ID="Button2" runat="server" Text="Button" />
    
    </div>
    </form>
</body>
</html>

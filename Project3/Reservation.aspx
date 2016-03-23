<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reservation.aspx.cs" Inherits="Project3.Reservation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="gvReservation" runat="server" AutoGenerateColumns="False" OnRowCommand="gvReservation_RowCommand">
            <Columns>
                <asp:ButtonField ButtonType="Button" CommandName="Reservation" HeaderText="Reservation" Text="Make Reservation" />
                <asp:BoundField DataField="RestaurantName" HeaderText="Restaurant Name" />
                <asp:BoundField DataField="RestaurantType" HeaderText="Restaurant Type" />
                <asp:BoundField DataField="RestaurantDesc" HeaderText="Restaurant Description" />
                <asp:BoundField DataField="RestaurantID" HeaderText="Restaurant ID" />
                <asp:ButtonField ButtonType="Button" CommandName="ManageReservation" HeaderText="Manage" Text="Manage Reservation" />
            </Columns>
        </asp:GridView>



    </div>
        <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" />
    </form>
</body>
</html>

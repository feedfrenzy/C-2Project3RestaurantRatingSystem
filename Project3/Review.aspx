<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Review.aspx.cs" Inherits="Project3.Review" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <asp:GridView ID="gvReviewRestaurant" runat="server" AutoPostBack="true" AutoGenerateColumns="False" OnRowCommand="gvReviewRestaurant_RowCommand">
            <Columns>
                <asp:ButtonField ButtonType="Button" CommandName="Review" HeaderText="Review" Text="Write Review" />
                <asp:BoundField DataField="RestaurantName" HeaderText="Restaurant Name" />
                <asp:BoundField DataField="RestaurantType" HeaderText="Restaurant Type" />
                <asp:BoundField DataField="RestaurantDesc" HeaderText="Restaurant Description" />
                <asp:BoundField DataField="RestaurantID" HeaderText="Restaurant ID"/>
                <asp:ButtonField ButtonType="Button" CommandName="ManageReview" HeaderText="Manage" Text="Manage Reviews" />
            </Columns>
        </asp:GridView>

        <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click"/>

        <asp:Label ID="lblShow" runat="server" ForeColor="Red"></asp:Label>

    </div>
    </form>
</body>
</html>

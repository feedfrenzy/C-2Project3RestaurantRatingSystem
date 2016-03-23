<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReviewManage.aspx.cs" Inherits="Project3.ReviewManage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
   
        <asp:Label ID="lblShow" runat="server" Text="If you see nothing in this page, that means the account you currently login now got no review for this restaurant." ForeColor="Blue"></asp:Label>
        <br />
        <asp:GridView ID="gvReviews" runat="server" AutoPostBack="true" AutoGenerateColumns="False" OnRowCommand="gvReviews_RowCommand">
            <Columns>
                <asp:BoundField DataField="RestaurantName" HeaderText="Restaurant Name" />
                <asp:BoundField DataField="ReviewerName" HeaderText="Reviewer" />
                <asp:BoundField DataField="ReviewFood" HeaderText="Food Rate" />
                <asp:BoundField DataField="ReviewService" HeaderText="Service Rate" />
                <asp:BoundField DataField="ReviewPrice" HeaderText="Price Rate" />
                <asp:BoundField DataField="ReviewComments" HeaderText="Comments" />
                <asp:BoundField DataField="ReviewID" HeaderText="Review ID" />

                <asp:ButtonField ButtonType="Button" CommandName="deleteReview" HeaderText="Delete" Text="Delete Review" />

            </Columns>
        </asp:GridView>

    </div>
        <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" /><br />
        <asp:Label ID="lblShowAdd" runat="server" ForeColor="Green"></asp:Label><br />
        <asp:Label ID="lblWarning" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <asp:Panel ID="Panel1" runat="server">


            <asp:Label ID="lblID" runat="server" Text="Review ID: "></asp:Label>
            <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="lblName" runat="server" Text="Reviewer: "></asp:Label>
            <asp:TextBox ID="txtName" runat="server" style="margin-left: 3px" Width="156px"></asp:TextBox>
            
            <br />
            <asp:Label ID="lblComments" runat="server" Text="Comments: "></asp:Label>
            <asp:TextBox ID="txtComments" runat="server" Height="32px" Width="158px" style="margin-top: 15px"></asp:TextBox>

            <br /><br />
            <asp:Label ID="lblFood" runat="server" Text="Food Rating: "></asp:Label>
            <input name="radioFoodRate" type="radio" value="1" />1
             <input name="radioFoodRate" type="radio" value="2" />2
                <input name="radioFoodRate" type="radio" value="3" />3
                <input name="radioFoodRate" type="radio" value="4" />4
                <input name="radioFoodRate" type="radio" value="5" />5<br />

            <br />
            <asp:Label ID="lblService" runat="server" Text="Service Rating: "></asp:Label>
            <input name="radioServiceRate" type="radio" value="1" />1
                <input name="radioServiceRate" type="radio" value="2" />2
                <input name="radioServiceRate" type="radio" value="3" />3
                <input name="radioServiceRate" type="radio" value="4" />4
                <input name="radioServiceRate" type="radio" value="5" />5<br />

            <br />
            <asp:Label ID="lblPrice" runat="server" Text="Price Rating: "></asp:Label>
            <input name="radioPriceRate" type="radio" value="1" />1
                <input name="radioPriceRate" type="radio" value="2" />2
                <input name="radioPriceRate" type="radio" value="3" />3
                <input name="radioPriceRate" type="radio" value="4" />4
                <input name="radioPriceRate" type="radio" value="5" />5
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Modify Review" OnClick="btnSubmit_Click" />
            <br />
        </asp:Panel>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReviewDetail.aspx.cs" Inherits="Project3.ReviewDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h2>Review Restaurant</h2>
            <br />

            <asp:GridView ID="gvReviewRest" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="RestaurantName" HeaderText="Restaurant Name" />
                    <asp:BoundField DataField="RestaurantType" HeaderText="Restaurant Type" />
                    <asp:BoundField DataField="RestaurantDesc" HeaderText="Restaurant Description " />
                </Columns>
            </asp:GridView>
            <br />
            <asp:Label ID="lblRating" runat="server" Text="Average rating will show after you submit the review." ForeColor="Blue"></asp:Label>


            <asp:GridView ID="gvReviews" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="RestaurantName" HeaderText="Restaurant Name" />
                    <asp:BoundField DataField="ReviewerName" HeaderText="Reviewer Name" />
                    <asp:BoundField DataField="ReviewFood" HeaderText="Food Rate" />
                    <asp:BoundField DataField="ReviewService" HeaderText="Service Rate" />
                    <asp:BoundField DataField="ReviewPrice" HeaderText="Price Rate" />
                    <asp:BoundField DataField="ReviewComments" HeaderText="Restaurant Comments" />
                </Columns>
            </asp:GridView>

            <br />
            <h2>Write Review</h2>

            <asp:Label ID="lblReviewName" runat="server" Text="Reviewer Name: "></asp:Label>
            <asp:TextBox ID="txtReviewName" runat="server"></asp:TextBox>
            <br />

            <br />

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
                <input name="radioPriceRate" type="radio" value="5" />5<br />

            <br />
            <asp:Label ID="lblComment" runat="server" Text="Write Comments: "></asp:Label>
            <asp:Label ID="lblShow" runat="server" forecolor ="Green"></asp:Label>
            <asp:Label ID="lblWarning" runat="server" forecolor="Red"></asp:Label>
            <br />

            <asp:TextBox ID="txtComments" runat="server" Height="68px" Width="250px"></asp:TextBox>

            <br />
            <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click"/>
            <asp:Button ID="btnReview" runat="server" Text="Submit Review" OnClick="btnReview_Click" />


        </div>
    </form>
</body>
</html>

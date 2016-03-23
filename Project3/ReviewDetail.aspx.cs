using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using System.Data.SqlClient;
using System.Data;
using RestaurantClass;

namespace Project3
{
    public partial class ReviewDetail : System.Web.UI.Page
    {
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();
        SqlCommand objCommand1 = new SqlCommand();
        SqlCommand objCommand2 = new SqlCommand();
        SqlCommand objCommand3 = new SqlCommand();
        Account review = new Account();

        protected void Page_Load(object sender, EventArgs e)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "MatchRestaurant";
            SqlParameter inputParameter = new SqlParameter("@theRestaurantID", Session["ID"]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(inputParameter);
            DataSet ds = objDB.GetDataSetUsingCmdObj(objCommand);
            gvReviewRest.DataSource = ds;
            gvReviewRest.DataBind();


            objCommand2.CommandType = CommandType.StoredProcedure;
            objCommand2.CommandText = "ShowReviews";
            SqlParameter input = new SqlParameter("@restID", Session["ID"]);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.Int;
            objCommand2.Parameters.Add(input);
            DataSet dsNew = objDB.GetDataSetUsingCmdObj(objCommand2);
            gvReviews.DataSource = dsNew;
            gvReviews.DataBind();

        }

        protected void btnReview_Click(object sender, EventArgs e)
        {
            objCommand1.CommandType = CommandType.StoredProcedure;
            objCommand1.CommandText = "AddReview";

            SqlParameter inputParameter = new SqlParameter("@theRestID", Session["ID"]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Int;
            objCommand1.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@theUserID", Session["UserID"]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Int;
            objCommand1.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@theName", Session["Name"]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand1.Parameters.Add(inputParameter);


            inputParameter = new SqlParameter("@theComments", txtComments.Text);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand1.Parameters.Add(inputParameter);

            if(String.IsNullOrEmpty(txtReviewName.Text)==false)
            {
                inputParameter = new SqlParameter("@theReviewerName", txtReviewName.Text);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.VarChar;
                objCommand1.Parameters.Add(inputParameter);

                if (Request.Form["radioFoodRate"] != null)
                {
                    inputParameter = new SqlParameter("@theFood", int.Parse(Request.Form["radioFoodRate"]));
                    inputParameter.Direction = ParameterDirection.Input;
                    inputParameter.SqlDbType = SqlDbType.Int;
                    objCommand1.Parameters.Add(inputParameter);

                    if (Request.Form["radioServiceRate"] != null)
                    {
                        inputParameter = new SqlParameter("@theService", int.Parse(Request.Form["radioServiceRate"]));
                        inputParameter.Direction = ParameterDirection.Input;
                        inputParameter.SqlDbType = SqlDbType.Int;
                        objCommand1.Parameters.Add(inputParameter);

                        if (Request.Form["radioPriceRate"] != null)
                        {
                            inputParameter = new SqlParameter("@thePrice", int.Parse(Request.Form["radioPriceRate"]));
                            inputParameter.Direction = ParameterDirection.Input;
                            inputParameter.SqlDbType = SqlDbType.Int;
                            objCommand1.Parameters.Add(inputParameter);


                            objDB.DoUpdateUsingCmdObj(objCommand1);

                            DataSet dsNew = objDB.GetDataSetUsingCmdObj(objCommand2);

                            gvReviews.DataSource = dsNew;
                            gvReviews.DataBind();


                            objCommand3.CommandType = CommandType.StoredProcedure;
                            objCommand3.CommandText = "GetAverageRate";

                            objCommand3.Parameters.AddWithValue("@restID", Session["ID"]);
                            SqlParameter outputParameter = new SqlParameter("@average", 0);
                            outputParameter.Direction = ParameterDirection.Output;
                            objCommand3.Parameters.Add(outputParameter);
                            DataSet output = objDB.GetDataSetUsingCmdObj(objCommand3);

                            int average = int.Parse(objCommand3.Parameters["@average"].Value.ToString());
                            lblRating.Text = "Average Rating: " + average;

                            lblShow.Text = "Review Added!";
                            lblWarning.Text = "";
                            txtComments.Text = "";
                            txtReviewName.Text = "";
                        }
                        else
                        {
                            lblWarning.Text = "price rating can not be empty!";
                        }
                    }
                    else
                    {
                        lblWarning.Text = "service rating can not be empty!";
                    }
                }
                else
                {
                    lblWarning.Text = "food rating can not be empty!";
                }
            }
            else
            {
                lblWarning.Text = "Please enter reviewer name!";
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Review.aspx");
        }


    }
}
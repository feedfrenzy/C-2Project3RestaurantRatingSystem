using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using System.Data.SqlClient;
using System.Data;

namespace Project3
{
    public partial class ReviewManage : System.Web.UI.Page
    {
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();
        SqlCommand objCommand1 = new SqlCommand();
        SqlCommand objCommand2 = new SqlCommand();
        //int index;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "ShowUserReview";
                SqlParameter input = new SqlParameter("@theUserID", Session["UserID"]);
                input.Direction = ParameterDirection.Input;
                input.SqlDbType = SqlDbType.Int;
                objCommand.Parameters.Add(input);

                input = new SqlParameter("@theRestName", Session["Name"]);
                input.Direction = ParameterDirection.Input;
                input.SqlDbType = SqlDbType.VarChar;
                objCommand.Parameters.Add(input);

                DataSet dsNew = objDB.GetDataSetUsingCmdObj(objCommand);
                gvReviews.DataSource = dsNew;
                gvReviews.DataBind();

                //gvReviews.Columns[6].Visible = false;
            }

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Review.aspx");
        }

        protected void gvReviews_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //if (e.CommandName == "updateReview")
            //{
            //    Panel1.Visible = true;
            //    index = Convert.ToInt32(e.CommandArgument);


            //    btnSubmit_Click(sender, e);

            //}
            //else if (e.CommandName == "deleteReview")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                int reviewID = int.Parse(gvReviews.Rows[index].Cells[6].Text);
                
                objCommand1.CommandType = CommandType.StoredProcedure;
                objCommand1.CommandText = "DeleteReviews";
                SqlParameter input = new SqlParameter("@theReviewID", reviewID);
                input.Direction = ParameterDirection.Input;
                input.SqlDbType = SqlDbType.Int;
                objCommand1.Parameters.Add(input);

                DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand1);

                Response.Redirect(Request.RawUrl);

            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            objCommand2.CommandType = CommandType.StoredProcedure;
            objCommand2.CommandText = "updateReviews";

            SqlParameter inputParameter = new SqlParameter("@theID", int.Parse(txtID.Text));
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Int;
            objCommand2.Parameters.Add(inputParameter);

            //if (String.IsNullOrEmpty(txtName.Text))
            //{
                inputParameter = new SqlParameter("@theName", txtName.Text);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.VarChar;
                objCommand2.Parameters.Add(inputParameter);
                //if (Request.Form["radioFoodRate"] != null)
                //{
                    inputParameter = new SqlParameter("@theFood", int.Parse(Request.Form["radioFoodRate"]));
                    inputParameter.Direction = ParameterDirection.Input;
                    inputParameter.SqlDbType = SqlDbType.Int;
                    objCommand2.Parameters.Add(inputParameter);

                    //if (Request.Form["radioServiceRate"] != null)
                    //{
                        inputParameter = new SqlParameter("@theService", int.Parse(Request.Form["radioServiceRate"]));
                        inputParameter.Direction = ParameterDirection.Input;
                        inputParameter.SqlDbType = SqlDbType.Int;
                        objCommand2.Parameters.Add(inputParameter);

                        //if (Request.Form["radioPriceRate"] != null)
                        //{
                            inputParameter = new SqlParameter("@thePrice", int.Parse(Request.Form["radioServiceRate"]));
                            inputParameter.Direction = ParameterDirection.Input;
                            inputParameter.SqlDbType = SqlDbType.Int;
                            objCommand2.Parameters.Add(inputParameter);

                            inputParameter = new SqlParameter("@theComments", txtComments.Text);
                            inputParameter.Direction = ParameterDirection.Input;
                            inputParameter.SqlDbType = SqlDbType.VarChar;
                            objCommand2.Parameters.Add(inputParameter);

                            objDB.DoUpdateUsingCmdObj(objCommand2);


                            Response.Redirect(Request.RawUrl);

                            //DataSet dsNew = objDB.GetDataSetUsingCmdObj(objCommand2);

                            //gvReviews.DataSource = dsNew;
                            //gvReviews.DataBind();

                            txtName.Text = "";
                            txtComments.Text = "";
                            lblWarning.Text = "";
                            lblShowAdd.Text = "Review Updated! ";
                        }
            //            else
            //            {
            //                lblWarning.Text = "Price Rating can not be empty! ";
            //            }
            //        }
            //        else
            //        {
            //            lblWarning.Text = "Service Rating can not be empty! ";
            //        }
            //    }
            //    else
            //    {
            //        lblWarning.Text = "Food Rating can not be empty! ";
            //    }
            //}
            //else
            //{
            //    lblWarning.Text = "Reviewer name can not be emtpy! ";
            //}
        }


    }

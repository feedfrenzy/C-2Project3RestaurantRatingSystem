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
    public partial class ReservationDetail : System.Web.UI.Page
    {

        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();
        SqlCommand objCommand1 = new SqlCommand();

        protected void Page_Load(object sender, EventArgs e)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "MatchRestaurant";

            SqlParameter inputParameter = new SqlParameter("@theRestaurantID", Session["ID"]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(inputParameter);

            DataSet ds = objDB.GetDataSetUsingCmdObj(objCommand);

            gvReservation.DataSource = ds;
            gvReservation.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objCommand1.CommandType = CommandType.StoredProcedure;
            objCommand1.CommandText = "AddReservation";

            SqlParameter inputParameter = new SqlParameter("@theRestID", Session["ID"]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Int;
            objCommand1.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@theRestName", Session["Name"]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand1.Parameters.Add(inputParameter);


            int number;


            if (String.IsNullOrEmpty(txtName.Text) == false)
            {
                inputParameter = new SqlParameter("@theCName", txtName.Text);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.VarChar;
                objCommand1.Parameters.Add(inputParameter);

                if (String.IsNullOrEmpty(txtCount.Text) == false)
                {
                    if (int.TryParse(txtCount.Text, out number))
                    {
                        inputParameter = new SqlParameter("@theCount", txtCount.Text);
                        inputParameter.Direction = ParameterDirection.Input;
                        inputParameter.SqlDbType = SqlDbType.Int;
                        objCommand1.Parameters.Add(inputParameter);

                        if (String.IsNullOrEmpty(ddlTime.SelectedValue) == false)
                        {
                            inputParameter = new SqlParameter("@theTime", ddlTime.SelectedValue);
                            inputParameter.Direction = ParameterDirection.Input;
                            inputParameter.SqlDbType = SqlDbType.Int;
                            objCommand1.Parameters.Add(inputParameter);

                            objDB.DoUpdateUsingCmdObj(objCommand1);

                            lblShow.Text = "Restaurant Reserved!";

                            txtCount.Text = "";
                            txtName.Text = "";
                            ddlTime.SelectedValue = "";
                            lblWarning.Text = "";
                        }
                        else
                        {
                            lblWarning.Text = "Time can not be empty!";
                        }
                    }
                    else
                    {
                        lblWarning.Text = "Numbers of people must be numeric!";
                    }
                }
                else
                {
                    lblWarning.Text = "Numbers of people can not be empty!";
                }
            }
            else
            {
                lblWarning.Text = "Name can not be empty!";
            }



        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Reservation.aspx");
        }
    }
}